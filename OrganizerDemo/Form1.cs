using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Configuration;
using OrganizerDemo.Models;

namespace OrganizerDemo
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        List<Category> categories;
        List<Task_> tasks;
        List<Reminder> reminders;

        protected bool PasswProtection { get; set; }
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
            categories = new List<Category>();
            tasks = new List<Task_>();
            reminders = new List<Reminder>();
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
                    string passw = loginWindow.Passw;
                    passw = GetHash(passw);

                    string sqlQuery = $"select Password from Passwords where Password='{passw}'";
                    try
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            MessageBox.Show("Авторизація успішна", "Сповіщення",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            next = true;
                        }
                        else
                        {
                            MessageBox.Show("Пароль невірний", "Попередження",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Помилка виконання",
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
            string sqlQuery = "select count(Password) from Passwords";
            SqlCommand cmd = new SqlCommand(sqlQuery, connection);
            //MessageBox.Show(cmd.ExecuteScalar().ToString(), "", MessageBoxButtons.OK);
            if ((int)cmd.ExecuteScalar() != 0)
            {
                PasswProtection = true;
                AuthUser();
            }
            else
                PasswProtection = false;
 
            connection.Close();
            LoadCategories();
            LoadTasks();
        }

        private void LoadCategories()
        {
            try
            {
                string query = "select * from Categories";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                categoriesList.Items.Clear();
                categories.Clear();
                int counter = 0;
                while (reader.Read())
                {
                    Category category = new Category()
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString()
                    };
                    categoriesList.Items.Add(category);
                    categoriesList.SetItemChecked(counter, true);
                    counter++;
                    categories.Add(category);
                }
                categoriesList.CheckOnClick = true;
                categoriesList.DisplayMember = "Name";
                categoriesList.ValueMember = "Id";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Помилка завантаження категорій",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void LoadTasks()
        {
            try
            {
                //string query = "select * from Tasks";
                string query = "select t.Id, t.Name, t.Info, t.Date, t.Time, t.IsDone, t.Flagged, c.Name CategoryName, t.CategoryId from Tasks t, Categories c where t.CategoryId = c.Id";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                tasksList.Items.Clear();
                tasks.Clear();
                while (reader.Read())
                {
                    Task_ task = new Task_()
                {
                    Id = (int)reader["Id"],
                    Name = reader["Name"].ToString(),
                    Info = reader["Info"].ToString(),
                    Date = (DateTime)reader["Date"],
                    Time = DateTime.Parse(reader["Time"].ToString(), System.Globalization.CultureInfo.CurrentCulture),
                    IsDone = (bool)reader["IsDone"],
                    Flagged = (bool)reader["Flagged"],
                    CategoryId = (int)reader["CategoryId"],
                    CategoryName = reader["CategoryName"].ToString()
                    };
                    if (ignoreDate.CheckState == CheckState.Checked)
                    {
                        int index = task.CategoryId - 1;
                        if (categoriesList.GetItemChecked(index))
                        {
                            var current = tasksList.Items.Add(task.Name);
                            current.SubItems.Add(task.CategoryName);
                            current.SubItems.Add(task.Date.ToString("D"));
                            current.SubItems.Add(task.Time.ToString("HH:MM"));
                            if (task.IsDone)
                                current.SubItems.Add("+");
                            else
                                current.SubItems.Add("-");
                            if (task.Flagged)
                                current.SubItems.Add("+");
                            else
                                current.SubItems.Add("-");
                            tasks.Add(task);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Помилка завантаження задач",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void authControlMenuItem_Click(object sender, EventArgs e)
        {
            AuthorizationControl authorizationControl;
            authorizationControl = new AuthorizationControl();
            authorizationControl.Show();
        }

        private void tasksList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tasksList.FocusedItem != null)
            {
                int index = tasksList.FocusedItem.Index;
                textInfo.Text = tasks[index].Info;
            }
        }

        private void categoriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void ignoreDate_CheckedChanged(object sender, EventArgs e)
        {
            LoadTasks();
            dateTime.Enabled = !dateTime.Enabled;
        }

        private void addCatStripMenuItem_Click(object sender, EventArgs e)
        {

            CategoriesEditor categoriesEditor = new CategoriesEditor();
            categoriesEditor.OperationTitle = "Добавление категории";
            categoriesEditor.Categories = categories;
            if (categoriesEditor.ShowDialog() == DialogResult.OK)
            {
                string query = $"insert into Categories (Name) values (@p1)";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@p1", SqlDbType.NVarChar).Value = categoriesEditor.CategoryName;
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Категорія додана", "Сповіщення",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategories();
            }
        }

        private void deleteCatStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriesEditor categoriesEditor = new CategoriesEditor();
            categoriesEditor.OperationTitle = "Видалення категорії";
            categoriesEditor.CategoryName = (categoriesList.SelectedItem as Category).Name;
            int id = (categoriesList.SelectedItem as Category).Id;
            categoriesEditor.Categories = categories;
            //
            if (categoriesEditor.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string query = $"delete from Categories where Id=@p2";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@p2", SqlDbType.Int).Value = id;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Категория успешно удалена", "Сообщение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                    LoadCategories();
                    LoadTasks();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Ошибка удаления категории",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }

        private void editCatStripMenuItem_Click(object sender, EventArgs e)
        {
            if (categoriesList.SelectedItem != null)
            {
                CategoriesEditor categoriesEditor = new CategoriesEditor();
                categoriesEditor.OperationTitle = "Редагування категорії";
                categoriesEditor.CategoryName = (categoriesList.SelectedItem as Category).Name;
                int id = (categoriesList.SelectedItem as Category).Id;
                categoriesEditor.Categories = categories;
                // !!! ADD PROTECTION OF DELETING CATEGORY WHITH ACTIVE TASKS !!!
                if (categoriesEditor.ShowDialog() == DialogResult.OK)
                {
                    string query = $"update Categories set Name=@p1 where Id=@p2";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@p1", SqlDbType.NVarChar).Value = categoriesEditor.CategoryName;
                    cmd.Parameters.Add("@p2", SqlDbType.Int).Value = id;
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Категорія успішно змінена", "Сповіщення",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    LoadCategories();
                }
            }
            else
                MessageBox.Show("Оберіть категорію для редагування", "Попередження",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addTaskMenuItem_Click(object sender, EventArgs e)
        {
                TaskEditor taskEditor = new TaskEditor();
                taskEditor.OperationTitle = "Нова задача";
                taskEditor.Categories = categories;
                //taskEditor.CategoryName = tasksList.FocusedItem.SubItems[1].Text;
                taskEditor.Tasks = tasks;
                if (taskEditor.ShowDialog() == DialogResult.OK)
                {
                    string query = "insert into Tasks (Name, Info, Date, Time, IsDone, Flagged, CategoryId) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.Add("@p1", SqlDbType.NVarChar).Value = taskEditor.TaskName;
                    cmd.Parameters.Add("@p2", SqlDbType.NVarChar).Value = taskEditor.Info;
                    cmd.Parameters.Add("@p3", SqlDbType.Date).Value = taskEditor.Date;
                    cmd.Parameters.Add("@p4", SqlDbType.Time).Value = taskEditor.Time.TimeOfDay;
                    cmd.Parameters.Add("@p5", SqlDbType.Bit).Value = taskEditor.IsDone;
                    cmd.Parameters.Add("@p6", SqlDbType.Bit).Value = taskEditor.Flagged;
                    cmd.Parameters.Add("@p7", SqlDbType.Int).Value = taskEditor.CategoryId;
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Задача успішно змінена", "Сповіщення",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategories();
                    LoadTasks();
                }

        }

        private void editTaskMenuItem_Click(object sender, EventArgs e)
        {
            if (tasksList.FocusedItem != null)
            {
                TaskEditor taskEditor = new TaskEditor();
                taskEditor.OperationTitle = "Редагувння задачі";
                taskEditor.Tasks = tasks;
                taskEditor.Categories = categories;
                Task_ editTask = tasks[tasksList.FocusedItem.Index];
                int id = editTask.Id;
                taskEditor.TaskName = editTask.Name;
                taskEditor.CategoryName = editTask.CategoryName;
                taskEditor.Info = editTask.Info;
                taskEditor.Date = editTask.Date;
                taskEditor.Time = editTask.Time;
                taskEditor.IsDone = editTask.IsDone;
                taskEditor.Flagged = editTask.Flagged;
                taskEditor.CategoryId = editTask.CategoryId;

                if (taskEditor.ShowDialog() == DialogResult.OK)
                {
                    string query = "update Tasks set Name=@p1, Info=@p2, Date=@p3, Time=@p4, IsDone=@p5, Flagged=@p6, CategoryId=@p7 where Id=@p0";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@p0", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@p1", SqlDbType.NVarChar).Value = taskEditor.TaskName;
                    cmd.Parameters.Add("@p2", SqlDbType.NVarChar).Value = taskEditor.Info;
                    cmd.Parameters.Add("@p3", SqlDbType.Date).Value = taskEditor.Date;
                    cmd.Parameters.Add("@p4", SqlDbType.Time).Value = taskEditor.Time.TimeOfDay;
                    cmd.Parameters.Add("@p5", SqlDbType.Bit).Value = taskEditor.IsDone;
                    cmd.Parameters.Add("@p6", SqlDbType.Bit).Value = taskEditor.Flagged;
                    cmd.Parameters.Add("@p7", SqlDbType.Int).Value = taskEditor.CategoryId;
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Задача успішно змінена", "Сповіщення",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategories();
                    LoadTasks();
                }
            }
            else
                MessageBox.Show("Оберіть задачу для редагування", "Попередження",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
