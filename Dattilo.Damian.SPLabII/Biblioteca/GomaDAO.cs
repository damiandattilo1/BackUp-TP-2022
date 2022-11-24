using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Biblioteca
{
    public class GomaDAO
    {
        SqlConnection conexion;
        SqlCommand command;
        SqlDataReader reader;

        static string connectionString;

        static GomaDAO()
        {
            connectionString = @"Server=localhost\SQLEXPRESS;Database=Dattilo.Damian.SPLabII; Trusted_Connection=True;";
        }

       
        /// <summary>
        /// lee todas las entradas de la tabla goma y las devuelve en una lista
        /// </summary>
        /// <returns></returns>
        public List<Goma> Leer()
        {
            List<Goma> listaGomas = new List<Goma>();
            string query = "SELECT * FROM GOMAS";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {

                        SqlDataReader reader;
                        connection.Open();


                        reader = command.ExecuteReader();

                        while (reader.Read())
                        {

                            string marca = reader["MARCA"].ToString();
                            int precio = reader.GetInt32(2);

                            bool paraLapiz = reader.GetBoolean(3);
                            int largo = reader.GetInt32(4);


                            Goma goma = new Goma(marca, precio, paraLapiz, largo);
                            listaGomas.Add(goma);
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            
            return listaGomas;

        }



        
        /// <summary>
        /// Agrega una goma a la tabla de la bse de datos
        /// </summary>
        /// <param name="goma"></param>
        public void Insertar(Goma goma)
        {
            string query = $"INSERT INTO GOMAS (marca, precio, paraLapiz, largo) VALUES (@marca, @precio, @paraLapiz, @largo)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        int afectadas;
                
                        connection.Open();
             
                        //command.CommandText = $"INSERT INTO GOMAS (marca, precio, paraLapiz, largo) VALUES (@marca, @precio, @paraLapiz, @largo)";
                        command.Parameters.AddWithValue("@marca", goma.Marca);
                        command.Parameters.AddWithValue("@precio", goma.Precio);
                        command.Parameters.AddWithValue("@paraLapiz", goma.ParaLapiz);
                        command.Parameters.AddWithValue("@largo", goma.Largo);
                        afectadas = command.ExecuteNonQuery();
                        Console.WriteLine($"Se vieron afectadas {afectadas}");

                    }
                    catch (Exception)
                    {
                        throw;
                    }

                }
            }

        }

        public void Modificar(Goma goma, int id)
        {
            string query = $"UPDATE GOMAS SET Marca = @marca WHERE ID = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        int afectadas;

                        conexion.Open();
                        command.Parameters.AddWithValue("@marca", goma.Marca);
                        command.Parameters.AddWithValue("@id", id);
                        afectadas = command.ExecuteNonQuery();

                    }
                    catch (Exception)
                    {
                        throw;
                    }

                }
               
            }
        }

        /// <summary>
        /// Elimina de la tabla el objeto pasado por parametro
        /// </summary>
        /// <param name="goma"></param>
        public void Eliminar(Goma goma)
        {
            string query = $"DELETE FROM GOMAS WHERE MARCA = @marca";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        int afectadas;

                        connection.Open();
                        command.Parameters.AddWithValue("@marca", goma.Marca);
                        afectadas = command.ExecuteNonQuery();
                        Console.WriteLine($"Se vieron afectadas: {afectadas}");

                    }
                    catch (Exception)
                    {
                        throw;
                    }

                }

            }
        }


    }
}
