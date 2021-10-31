using System;
using System.Data;
using System.Data.SqlClient;

namespace AandelenBeheerData
{

    public class Rss
    {

        public string connectionString; public string ConnectionString

        {

            get { return connectionString; }
            set { connectionString = value; }

        }

        private SqlConnection GetDbConnectie()

        {

            return new SqlConnection(connectionString);

        }

        public void Bewaar(string titel, string auteur, string inhoud, string link, DateTime publicatieTijd)

        {

            string insertSqlText = "INSERT INTO Rss(Title, Auteur, Inhoud, Link, PublicatieTijd)     VALUES(@Title,  @Auteur,  @Inhoud,  @Link, @PublicatieTijd)";

            SqlCommand insertSql = new SqlCommand(insertSqlText);

            insertSql.Connection = GetDbConnectie();

            insertSql.Parameters.Add(new SqlParameter("@Title", titel));

            insertSql.Parameters.Add(new SqlParameter("@Auteur", auteur));

            insertSql.Parameters.Add(new SqlParameter("@Inhoud", inhoud));

            insertSql.Parameters.Add(new SqlParameter("@Link", link));

            insertSql.Parameters.Add(new SqlParameter("@PublicatieTijd", publicatieTijd));

            try

            {

                insertSql.Connection.Open(); insertSql.ExecuteNonQuery();

            }

            catch (SqlException ex)

            {

                Console.WriteLine("Bewaar Rss mislukt." + ex.Message);

            }

            finally

            {

                if (insertSql.Connection.State == ConnectionState.Open)

                {

                    insertSql.Connection.Close();

                }

            }

        }


}
}
