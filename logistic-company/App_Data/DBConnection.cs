using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace logistic_company.App_Data
{
    class DBConnection
    {

        private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\App_Data\Clients.mdf;Integrated Security=True";
        private static SqlConnection sqlConnection = new SqlConnection(connectionString);

        public static void GetAuthClient(string Login, string Password)
        {
            string queryGetAuthClient = $"SELECT Login, Password FROM Clients WHERE Login = '{Login}' AND Password = '{Password}'";

            sqlConnection.Open();
            SqlCommand commGetAuthClient = new SqlCommand(queryGetAuthClient, sqlConnection);
            SqlDataReader sqlDataReader = commGetAuthClient.ExecuteReader();

            if(sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    MessageBox.Show("Добро пожаловать!");
                }
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует!");
            }
            sqlConnection.Close();
        }

    }
}
