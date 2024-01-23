using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Entidades;

namespace Datos
{
    public class DbConnectionException : Exception
    {
        public DbConnectionException(string message) : base(message) { }
        public DbConnectionException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class DbEmptyException : Exception
    {
        public DbEmptyException(string message) : base(message) { }
        public DbEmptyException(string message, Exception innerException) : base(message, innerException) { }
    }
    public class DbException : Exception
    {
        public DbException(string message) : base(message) { }

        public DbException(string message, Exception innerException) : base(message, innerException) { }
    }
    public class DUsuario : Conexion
    {
        public bool Login(string nombreUsuario, string password)
        {
            try
            {
                using (MySqlConnection conexion = GetConnection())
                {
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "SELECT COUNT(*) FROM usuarios WHERE nombreUsuario = BINARY @nombreUsuario AND password = BINARY @password";//Binary para que sea sensible a mayúsculas y minúsculas
                        command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                        command.Parameters.AddWithValue("@password", password);
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count == 1;
                    }
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine($"Error en el método Login: {e.Message}");
                return false;
            }
        }//Ingreso de usuario
        public int ObtenerIdUsuario(string nombreUsuario)
        {
            int idUsuario = -1;
            try
            {
                using (MySqlConnection conexion = GetConnection())
                {
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "SELECT idUsuario FROM usuarios WHERE nombreUsuario = @nombreUsuario";
                        command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                        var result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            idUsuario = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine($"Error en el método ObtenerIdUsuario: {e.Message}");
            }
            return idUsuario;
        }//Obtengo el ID del usuario para usarlo en "FlagBajaLogica" y en el login
        public int FlagBajaLogica(string usuarioActual)
        {
            int idUsuario = ObtenerIdUsuario(usuarioActual);
            int flagBaja = -1;
            try
            {
                using (MySqlConnection conexion = GetConnection())
                {
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        command.Connection = conexion;
                        command.CommandText = "SELECT flagBajaLogica FROM usuarios WHERE idUsuario = @idUsuario";
                        command.Parameters.AddWithValue("@idUsuario", idUsuario);
                        var result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            flagBaja = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine($"Error en el método FlagBajaLogica: {e.Message}");
            }
            return flagBaja;
        }//¿Tiene la baja lógica?
        public bool FlagBloqueado(string nombreUsuario)//¿Está bloqueado?
        {
            try
            {
                using (MySqlConnection conexion = GetConnection())
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT flagBloqueado FROM usuarios WHERE nombreUsuario = @nombreUsuario", conexion))
                    {
                        command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToBoolean(result);
                        }
                    }
                }
                return false;
            }
            catch (MySqlException e)
            {
                Console.WriteLine($"Error en el método FlagBloqueado: {e.Message}");
                return false;
            }
        }
        public int QintentosFallidosLogin(string nombreUsuario)
        {
            int intentosFallidos = 0;
            try
            {
                using (MySqlConnection conexion = GetConnection())
                using (MySqlCommand command = new MySqlCommand("SELECT qIntentosFallidosLogin FROM usuarios WHERE nombreUsuario = @nombreUsuario", conexion))
                {
                    command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        intentosFallidos = Convert.ToInt32(result);
                    }
                }
                return intentosFallidos;
            }
            catch (MySqlException e)
            {
                Console.WriteLine($"Error en el método QintentosFallidosLogin: {e.Message}");
                return intentosFallidos;
            }
        }//Cuantos intentos fallidos tiene
        public void IncrementarIntentosFallidos(string nombreUsuario)
        {
            try
            {
                using (MySqlConnection conexion = GetConnection())
                using (MySqlCommand command = new MySqlCommand("UPDATE usuarios SET qIntentosFallidosLogin = qIntentosFallidosLogin + 1 WHERE nombreUsuario = @nombreUsuario", conexion))
                {
                    command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    command.ExecuteNonQuery();
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine($"Error en el método IncrementarIntentosFallidos: {e.Message}");
            }
        }//Aumenta los intentos fallidos
        public void RestaurarQIntentosFallidos(string nombreUsuario)
        {
            try
            {
                using (MySqlConnection conexion = GetConnection())
                using (MySqlCommand command = new MySqlCommand("UPDATE usuarios SET qIntentosFallidosLogin = 0 WHERE nombreUsuario = @nombreUsuario", conexion))
                {
                    command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    command.ExecuteNonQuery();
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine($"Error en el método RestaurarQIntentosFallidos: {e.Message}");
            }
        }//Vuelve a 0 la cantidad de intentos fallidos
        public void BloquearUsuario(string nombreUsuario)
        {
            try
            {
                using (MySqlConnection conexion = GetConnection())
                using (MySqlCommand command = new MySqlCommand("UPDATE usuarios SET flagBloqueado = 1 WHERE nombreUsuario = @nombreUsuario", conexion))
                {
                    command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    command.ExecuteNonQuery();
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine($"Error en el método BloquearUsuario: {e.Message}");
            }
        }//Bloqueamos el usuario cambiando su flagBloqueado a true/1.
        public DataTable ObtenerUsuarioConRol(string nombreUsuario)
        {
            DataTable dtUsuarioRol = new DataTable();
            string strSQL = "SELECT usuarios.nombreUsuario, roles.descripcion AS rol" +
                            " FROM usuarios" +
                            " JOIN usuario_rol ON usuarios.idUsuario = usuario_rol.idUsuario" +
                            " JOIN roles ON usuario_rol.idRol = roles.idRol" +
                            " WHERE usuarios.nombreUsuario = @nombreUsuario AND usuarios.flagBajaLogica = 0 AND roles.flagBajaLogica = 0";

            using (MySqlConnection conexion = GetConnection())
            {
                using (MySqlCommand command = new MySqlCommand(strSQL, conexion))
                {
                    command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                    using (MySqlDataReader lector = command.ExecuteReader())
                    {
                        dtUsuarioRol.Load(lector);
                    }
                }
            }
            return dtUsuarioRol;
        }
    }
}
