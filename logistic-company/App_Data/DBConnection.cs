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

            try
            {
                sqlConnection.Open();
                SqlCommand commGetAuthClient = new SqlCommand(queryGetAuthClient, sqlConnection);
                SqlDataReader sqlDataReader = commGetAuthClient.ExecuteReader();

                if (sqlDataReader.HasRows)
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
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

        private static void AddClient(string Login, string Password, string Email)
        {
            try
            {
                string queryAddClient = $"INSERT INTO Clients(Login, Password, Email) VALUES('{Login}', '{Password}', '{Email}')";

                SqlCommand commAddClient = new SqlCommand(queryAddClient, sqlConnection);
                commAddClient.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

        public static void CheckClientAccount(string Login, string Password, string Email)
        {
            string queryCheckClientAccount = $"SELECT Login FROM Clients WHERE Login = '{Login}' OR Email = '{Email}'";

            try
            {
                sqlConnection.Open();
                SqlCommand commCheckClientAccount = new SqlCommand(queryCheckClientAccount, sqlConnection);
                SqlDataReader sqlDataReader = commCheckClientAccount.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        sqlDataReader.Close();
                        MessageBox.Show("Такой пользователь уже существует!");
                    }
                }
                else
                {
                    sqlDataReader.Close();
                    AddClient(Login, Password, Email);
                    MessageBox.Show("Пользователь успешно добавлен!");
                }

                sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
