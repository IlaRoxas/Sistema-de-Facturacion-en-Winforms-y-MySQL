using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Logica
{
    public class LUsuario
    {
        private DUsuario usuario;

        public LUsuario()
        {
            usuario = new DUsuario();
        }
        public bool UserLogin(string user, string pass, out string mensaje)
        {
            //Validar campos vacíos
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                mensaje = "Ingrese usuario y contraseña";
                return false;
            }
            try
            {
                //1 - Preguntamos si el usuario tiene baja logica
                if (usuario.FlagBajaLogica(user) == 1)
                {
                    mensaje = "Usuario dado de baja";
                    return false;
                }

                //2 - Preguntamos si fué bloqueado por reiterados intentos fallidos
                if (usuario.FlagBloqueado(user) is true)
                {
                    mensaje = "Usuario bloqueado";
                    return false;
                }

                //3 - Si hasta aca llegamos ok, trataremos de hacer el login:
                if (usuario.Login(user, pass))
                {
                    usuario.RestaurarQIntentosFallidos(user);
                    mensaje = "Inicio de sesión exitoso";

                    // Obtener DataTable con usuarios y roles para un usuario específico
                    DataTable dtUsuarioRol = usuario.ObtenerUsuarioConRol(user);

                    // Mostrar información en la consola 
                    if (dtUsuarioRol.Rows.Count > 0)
                    {
                        DataRow row = dtUsuarioRol.Rows[0];
                        string nombreUsuario = row["nombreUsuario"].ToString();
                        string rol = row["rol"].ToString();
                        mensaje = $"Usuario: {nombreUsuario}, Rol: {rol}";
                    }
                    else
                    {
                        mensaje = "No se encontró información para el usuario proporcionado.";
                    }
                    return true;
                }
                //4 - Si no logra hacer el login, aumentamos la cantidad de intentos fallidos
                else
                {
                    usuario.IncrementarIntentosFallidos(user);
                }

                //5 - Si los intentos fallidos son >= 3, entonces bloqueamos el usuario:
                if (usuario.QintentosFallidosLogin(user) >= 3)
                {
                    usuario.BloquearUsuario(user);
                }
                mensaje = "Inicio de sesión fallido";
                return false;
            }
            catch (DbConnectionException ex)
            {
                // Manejar la excepción relacionada con la conexión a la base de datos
                mensaje = $"Error de conexión a la base de datos: {ex.Message}";
                return false;
            }
            catch (DbEmptyException ex)
            {
                // Manejar la excepción relacionada con la base de datos vacía
                mensaje = $"La base de datos está vacía: {ex.Message}";
                return false;
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones generales
                mensaje = $"Error desconocido: {ex.Message}";
                return false;
            }
        }   
    }
}