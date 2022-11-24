using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Biblioteca
{
    public class SacapuntasDAO
    {
        SqlConnection conexion;
        SqlCommand command;
        SqlDataReader reader;

        static string connectionString;

        static SacapuntasDAO()
        {
            connectionString = @"Server=localhost\SQLEXPRESS;Database=Dattilo.Damian.SPLabII; Trusted_Connection=True;";
        }


        /// <summary>
        /// lee todas las entradas de la tabla lapiz y las retorna en una lista
        /// </summary>
        /// <returns></returns>
        public List<Sacapunta> Leer()
        {
            List<Sacapunta> listaSacapuntas = new List<Sacapunta>();
            string query = "SELECT * FROM Sacapuntas";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
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

                            bool esElectrico = reader.GetBoolean(3);
                            int capacidad = reader.GetInt32(4);


                            Sacapunta sacapunta = new Sacapunta(marca, precio, esElectrico, capacidad);
                            listaSacapuntas.Add(sacapunta);
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }

            return listaSacapuntas;

        }



        
        /// <summary>
        /// inserta el sacapuntas recibido por parametro
        /// </summary>
        /// <param name="sacapunta"></param>
        public void Insertar(Sacapunta sacapunta)
        {
            string query = $"INSERT INTO Sacapuntas (marca, precio, esElectrico, capacidad) VALUES (@marca, @precio, @esElectrico, @capacidad)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        int afectadas;

                        connection.Open();

                        
                        command.Parameters.AddWithValue("@marca", sacapunta.Marca);
                        command.Parameters.AddWithValue("@precio", sacapunta.Precio);
                        command.Parameters.AddWithValue("@esElectrico", sacapunta.EsElectrico);
                        command.Parameters.AddWithValue("@capacidad", sacapunta.Capacidad);
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

        public void Modificar(Sacapunta sacapunta, int id)
        {
            string query = $"UPDATE SACAPUNTAS SET Marca = @marca WHERE ID = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        int afectadas;

                        conexion.Open();
                        command.Parameters.AddWithValue("@marca", sacapunta.Marca);
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
        /// elimina el sacapuntas recibido por parametro
        /// </summary>
        /// <param name="sacapunta"></param>
        public void Eliminar(Sacapunta sacapunta)
        {
            string query = $"DELETE FROM SACAPUNTAS WHERE MARCA = @marca";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        int afectadas;

                        connection.Open();
                        command.Parameters.AddWithValue("@marca", sacapunta.Marca);
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
