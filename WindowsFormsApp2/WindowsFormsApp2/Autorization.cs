using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }
        string SqlStr;
        private void EnterBtn_Click(object sender, EventArgs e)
        {
            Sql.Connection.Open();
            SqlStr = $"select * from users where Login='{LogBox.Text}' and Password='{PassBox.Text}';";
            MySqlCommand cmd = new MySqlCommand(SqlStr, Sql.Connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Program.Role = reader[3].ToString();
            }
            reader.Close();
            Sql.Connection.Close();
            if (Program.Role == "Manager")
            {
                MessageBox.Show($"Вход выполнен успешно", "Success");
                ManagerForm newForm = new ManagerForm();
                newForm.Show();
            }

            if (Program.Role == "User")
            {
                MessageBox.Show($"Вход выполнен успешно", "Success");
                UserForm newForm = new UserForm();
                newForm.Show();
            }
            this.Hide();
            Sql.Connection.Close();
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            Registration NewRegForm = new Registration();
            NewRegForm.ShowDialog();
        }

        private void Autorization_Load(object sender, EventArgs e)
        {

        }

        private void Autorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
