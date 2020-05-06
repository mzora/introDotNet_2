using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Introduzione
{
    public static class DAL
    {
        public static void insertUser(Persona p)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["MainDB"].ConnectionString;
            string query = "insert into [dbo].[Persone] values (newid(), @nome, @cognome, @eta)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@nome", p.Nome);
                    command.Parameters.AddWithValue("@cognome", p.Cognome);
                    command.Parameters.AddWithValue("@eta", p.Eta);
                    
                    connection.Open();
                    command.ExecuteReader();

                }
                catch (Exception ex)
                {

                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public static List<Persona> getPersone()
        {
            List<Persona> persone = new List<Persona>();

            string connectionString = WebConfigurationManager.ConnectionStrings["MainDB"].ConnectionString;
            string query = "SELECT [ID],[Nome],[Cognome],[Eta] FROM [dbo].[persone]";  

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    DataTable dt = new DataTable();

                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        da.Fill(dt);
                    }

                    foreach (DataRow row in dt.Rows)
                    {
                        Persona p = new Persona();
                        p.ID = Guid.Parse(row["IDuser"].ToString());
                        p.Nome = row["Nome"].ToString();
                        p.Cognome = row["Cognome"].ToString();
                        p.Eta = int.Parse(row["Eta"].ToString());
                        persone.Add(p);
                    }

                }
                catch (Exception ex)
                {

                }
                finally
                {
                    connection.Close();
                }
            }
            return persone;
        }
    }
}