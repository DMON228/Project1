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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        MySqlCommand cmd;
        string SqlStr;
        private void RegForm_Load(object sender, EventArgs e)
        {
         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Sql.Connection.Open();
            SqlStr = $"insert into users(Login, Password, Role) " +
                     $"values('{LogBox.Text}','{PassBox.Text}', 'User');";
            cmd = new MySqlCommand(SqlStr, Sql.Connection);
            cmd.ExecuteNonQuery();
            this.Close();
            Sql.Connection.Close();
        }
    }
}
