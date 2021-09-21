using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizerDemo
{
    public partial class LoginWindow : Form
    {
        public string Login { get; set; }
        public string Passw { get; set; }
        public LoginWindow()
        {
            InitializeComponent();
            //MessageBox.Show("Enter login & passw for registration", "First enter", 
            //    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login = loginField.Text;
            Passw = passwField.Text;

            if (String.IsNullOrWhiteSpace(Login))
                MessageBox.Show("Логін не введений!", "Попередження",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (String.IsNullOrWhiteSpace(Passw))
                MessageBox.Show("Пароль не введений!", "Попередження",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
                this.DialogResult = DialogResult.;
        }
    }
}
