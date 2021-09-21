using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Configuration;

namespace OrganizerDemo
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);

        }
        private string GetHash(string passw)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] data = sha256.ComputeHash(Encoding.UTF8.GetBytes(passw));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < data.Length; i++) 
            {
                builder.Append(data[i].ToString("x2"));
            }
            return builder.ToString();
        }

        private void AuthUser()
        {
            bool next = false;
            LoginWindow loginWindow;
            do
            {
                loginWindow = new LoginWindow();
                if (loginWindow.ShowDialog() == DialogResult.OK)
                {
                    string login = loginWindow.Login;
                    string passw = loginWindow.Passw;
                    passw = GetHash(passw);

                    string sqlQuery = $"select Login, Password from Users where Login='{login}' and Password='{passw}'";
                    try
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            MessageBox.Show("Вы успешно авторизованы", "Сообщение",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            next = true;
                        }
                        else
                        {
                            MessageBox.Show("Пользователь не найден", "Предупреждение",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Ошибка выполнения",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                            connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Вихід з програми", "Вихід",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    next = true;
                    this.Close();
                }
            } while (!next);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();
            string sqlQuery = "select count(Login) from Users";
            SqlCommand cmd = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show($"Count: {((IDataRecord)reader)[0]}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //var item = ((IDataRecord)reader)[0].ToString();
            }

            //MessageBox.Show($"Count: {s}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
            AuthUser();
        }
    }
}
