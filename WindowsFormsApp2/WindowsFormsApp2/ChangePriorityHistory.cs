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
    public partial class ChangePriorityHistory : Form
    {
        public ChangePriorityHistory()
        {
            InitializeComponent();
        }
        string SqlStr;
        MySqlDataAdapter Adapter;

        private void ChangePriorityHistory_Load(object sender, EventArgs e)
        {
            DataTable Table = new DataTable();
            SqlStr = "SELECT agent.Title as 'Наименование агента' ,ChangeDate as 'Дата изменения',PriorityValue as 'Приоритет' FROM glazki_save.agentpriorityhistory "+
                     "inner join agent on agentpriorityhistory.AgentID = agent.ID";
            Adapter = new MySqlDataAdapter(SqlStr, Sql.Connection);
            Adapter.Fill(Table);
            HistoryBox.DataSource = Table;

        }
    }
}
