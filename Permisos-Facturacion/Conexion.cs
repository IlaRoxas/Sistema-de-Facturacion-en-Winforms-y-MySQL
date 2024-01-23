using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Datos
{
    public abstract class Conexion //Solo se usa como una clase base. No puede ser instanciada
    {
        private readonly string conexionString;//Encapsulación
        private string server = "localhost";
        private string database = "seminario";
        private string user = "root";
        private string password = "";


        public Conexion()
        {
            conexionString = "Database=" + database +
                "; DataSource=" + server + "; User Id=" + user +
                "; Password=" + password;
        }
        protected MySqlConnection GetConnection()
        {
            MySqlConnection conexion = new MySqlConnection(conexionString);
            try
            {
                conexion.Open();    
            }

            catch (MySqlException ex)
            {
                Console.WriteLine($"Error al abrir la conexión: {ex.Message}");
                HandleDatabaseException(ex);
                throw new DbConnectionException("Error al abrir la conexión.", ex);

            }
            return conexion;
        }
        private void HandleDatabaseException(MySqlException ex)
        {
            if (ex.Number == 0)
            {
                Console.WriteLine($"Error de conexión a la base de datos. Verifica la conexión: {ex.Message}");
                throw new DbConnectionException("Error de conexión a la base de datos. Verifica la conexión.", ex);

            }
            else if (ex.Number == 1046)
            {
                Console.WriteLine($"La base de datos está vacía: {ex.Message}");
                throw new DbEmptyException("La base de datos está vacía.", ex);

            }
            else
            {
                Console.WriteLine($"Error en la base de datos: {ex.Message}");
                throw new DbException($"Error en la base de datos: {ex.Message}", ex);

            }
        }

    }
}
