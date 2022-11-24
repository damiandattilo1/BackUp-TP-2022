using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Biblioteca;

namespace Biblioteca
{
    public class LapizDAO
    {
        SqlConnection conexion;
        SqlCommand command;
        SqlDataReader reader;

        static string connectionString;

        static LapizDAO()
        {
            connectionString = @"Server=localhost\SQLEXPRESS;Database=Dattilo.Damian.SPLabII; Trusted_Connection=True;";
        }

        /// <summary>
        /// lee todas las entradas de la tabla lapiz y las retorna en una lista
        /// </summary>
        /// <returns></returns>
        public List<Lapiz> Leer()
        {
            List<Lapiz> listaLapices = new List<Lapiz>();
            string query = "SELECT * FROM LAPICES";

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
                            string colorString = reader["COLOR"].ToString();
                            string trazoString = reader["TRAZO"].ToString();
                            eColor color;
                            eTrazo trazo;
                            switch (colorString)
                            {
                                case "Rojo":
                                    color = eColor.Rojo;
                                    break;
                                case "Verde":
                                    color = eColor.Verde;
                                    break;
                                case "Azul":
                                    color = eColor.Azul;
                                    break;
                                default:
                                    color = eColor.Rojo;
                                    break;

                            }
                            switch (trazoString)
                            {
                                case "H":
                                    trazo = eTrazo.H;
                                    break;
                                case "B":
                                    trazo = eTrazo.B;
                                    break;
                                case "HB":
                                    trazo = eTrazo.HB;
                                    break;
                                default:
                                    trazo = eTrazo.H;
                                    break;

                            }
                            Lapiz lapiz = new Lapiz(marca, precio, color, trazo);
                            listaLapices.Add(lapiz);
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }

            }
            
            return listaLapices;

        }



        
        /// <summary>
        /// agrega el lapiz recibido por parametro a la tabla
        /// </summary>
        /// <param name="lapiz"></param>
        public void Insertar(Lapiz lapiz)
        {
            string query = $"INSERT INTO LAPICES VALUES(@marca, @precio, @color, @trazo)";
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        int afectadas;
                        connection.Open();
                        command.Parameters.AddWithValue("@marca", lapiz.Marca);
                        command.Parameters.AddWithValue("@precio", lapiz.Precio);
                        command.Parameters.AddWithValue("@color", lapiz.Color.ToString());
                        command.Parameters.AddWithValue("@trazo", lapiz.Trazo.ToString());
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

        public void Modificar(Lapiz lapiz, int id)
        {
            string query = $"UPDATE LAPICES SET Marca = @marca WHERE ID = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        int afectadas;

                        conexion.Open();
                        command.Parameters.AddWithValue("@marca", lapiz.Marca);
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
        /// elimina el lapiz recibido por parametro
        /// </summary>
        /// <param name="lapiz"></param>
        public void Eliminar(Lapiz lapiz)
        {
            string query = $"DELETE FROM LAPICES WHERE MARCA = @marca";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                { 
                
                    try
                    {
                        int afectadas;

                        connection.Open();
                      
                        command.Parameters.AddWithValue("@marca", lapiz.Marca);
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
