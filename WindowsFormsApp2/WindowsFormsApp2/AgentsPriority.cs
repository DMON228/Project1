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
    public partial class AgentsPriority : Form
    {
        Agents F1;
        public AgentsPriority()
        {
            InitializeComponent();
        }

        string SqlStr;
        MySqlCommand Cmd;
        private void button1_Click(object sender, EventArgs e)
        {
            Sql.Connection.Open();
            for (int i =0; i < F1.SelectedAgentIDsForChange.Count; i++)
            {
                SqlStr = $"update agent set Priority = {PriorityValue.Value} where ID = {F1.SelectedAgentIDsForChange[i]}";
                Cmd = new MySqlCommand(SqlStr, Sql.Connection);
                Cmd.ExecuteNonQuery();

                SqlStr = $"insert into agentpriorityhistory (`AgentID`, `ChangeDate`, `PriorityValue`) " +
                    $"VALUES ('{F1.SelectedAgentIDsForChange[i]}', '{DateTime.Now.ToString("yyyy-MM-dd")}', '{PriorityValue.Value}');";
                Cmd = new MySqlCommand(SqlStr, Sql.Connection);
                Cmd.ExecuteNonQuery();

                
            }
            MessageBox.Show("Приоритеты изменены");
            Sql.Connection.Close();
            this.Close();
            F1.LoadData();
        }

        private void ChangeAgentsPriority_Load(object sender, EventArgs e)
        {
            F1 = this.Owner as Agents;
        }
    }
}
