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
    public partial class Agents : Form
    {
        public Agents()
        {
            InitializeComponent();
        }
        string SqlStr;
        string AddSearchSqlStr;
        string AddFilterSqlStr;
        string AddSortSqlStr;
        string AddPagesSqlStr;
        const int PageSize = 10;
        uint CurPage = 1;
        int NumOfAgents = 0;
        int MaxPages = 0;

        MySqlCommand Cmd;
        MySqlDataReader Reader;
        public List<int> SelectedAgentIDsForChange = new List<int>();
        private void Form1_Load(object sender, EventArgs e)
        {
            GetUniqueValues();
        }
        void GetUniqueValues()
        {
            Sql.Connection.Open();
            AgentTypeBox.Items.Add("Нет фильтрации");
            SqlStr = "select Title from agenttype";
            Cmd = new MySqlCommand(SqlStr, Sql.Connection);
            Reader = Cmd.ExecuteReader();

            while (Reader.Read())
            {
                AgentTypeBox.Items.Add(Reader[0].ToString());
            }
            Reader.Close();

            SqlStr = "select count(*) from agent";
            Cmd = new MySqlCommand(SqlStr, Sql.Connection);
            NumOfAgents = Convert.ToInt32(Cmd.ExecuteScalar().ToString());
            MaxPages = (NumOfAgents / PageSize)+1;
            Sql.Connection.Close();
           

            SortBox.DisplayMember = "Text";
            SortBox.ValueMember = "Value";

            var ItemsForSort = new[]
            {
            new { Text = "Нет сортировки", Value = "" },
            new { Text = "По возрастанию", Value = "ASC" },
            new { Text = "По убыванию", Value = "DESC" }
            };
            SortBox.DataSource = ItemsForSort;


            SelectNameOfSort.DisplayMember = "Text";
            SelectNameOfSort.ValueMember = "Value";

            var ItemsOfNamesForSort = new[]
            {
            new { Text = "Наименованию", Value = "agent.Title" },
            new { Text = "Приоритету", Value = "agent.Priority" },
            };
            SelectNameOfSort.DataSource = ItemsOfNamesForSort;

            AgentTypeBox.SelectedIndex = 0;
        }

        public void LoadData()
        {
            Sql.Connection.Open();
            AgentPanel.Controls.Clear();
            AddSearchSqlStr = $"and (agent.Title like '%{SearchBox.Text}%' or agent.Phone like " +
                $"'%{SearchBox.Text}%' or agent.Email like '%{SearchBox.Text}%') ";

            if (AgentTypeBox.SelectedIndex != 0 && AgentTypeBox.SelectedIndex != -1)
            {
                AddFilterSqlStr = $"where agenttype.Title = '{AgentTypeBox.SelectedItem}' ";
            }

            if (SelectNameOfSort.SelectedIndex != 0 && SelectNameOfSort.SelectedIndex != -1)
            {
                AddSortSqlStr = $"group by agent.ID order by {SelectNameOfSort.SelectedValue} {SortBox.SelectedValue} ";
            }
            else 
            {
                AddSortSqlStr = $"group by agent.ID order by agent.Title {SortBox.SelectedValue} ";
            }

            if (CurPage >=1 && CurPage <= MaxPages)
            {
                AddPagesSqlStr = $"limit {PageSize} offset {(PageSize * (CurPage-1))}";
                PageBox.Text = CurPage.ToString();
            } 

            SqlStr = "SELECT agent.ID, agenttype.Title, agent.Title, agent.Phone, agent.Priority, " +
                   "agent.Logo, (select sum(ProductCount) where SaleDate > now() - interval 5 year) as c, agent.Email, agent.Address, agent.INN, agent.KPP, agent.DirectorName FROM agent " +
                   "left join agenttype on agent.AgentTypeID = agenttype.ID " +
                   "left join productsale on agent.ID = productsale.AgentID " +
                   AddFilterSqlStr + AddSearchSqlStr + AddSortSqlStr + AddPagesSqlStr;

            Cmd = new MySqlCommand(SqlStr, Sql.Connection);
            Reader = Cmd.ExecuteReader();
            while (Reader.Read())
            {
                AgentControl AC = new AgentControl(Convert.ToInt32(Reader[0]), Reader[1].ToString(), Reader[2].ToString(), Reader[6].ToString(),
                        Reader[3].ToString(), Convert.ToInt32(Reader[4]), Reader[5].ToString(), Reader[7].ToString(), Reader[8].ToString(), Reader[9].ToString(), Reader[10].ToString(), Reader[11].ToString());
                AgentPanel.Controls.Add(AC);    
            }
            Reader.Close();

            Sql.Connection.Close();
        }
        
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ManufacturerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchBox_TextChanged(sender, e);
        }

        private void SortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchBox_TextChanged(sender, e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            Sql.Connection.Close();
            this.Dispose();
            this.Close();
            
        }

        private void SelectNameOfSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurPage = 1;
            SearchBox_TextChanged(sender, e);
        }

        private void BackPage_Click(object sender, EventArgs e)
        {
            if (CurPage > 1)
            {
                CurPage--;
                LoadData();
            }
        }

        private void ForwardPage_Click(object sender, EventArgs e)
        {
            if (CurPage >= 1 && CurPage < MaxPages)
            {
                CurPage++;
                LoadData();
            }           
        }

        private void AgentTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurPage = 1;
            SearchBox_TextChanged(sender, e);
        }

        private void ChangePriority_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < AgentPanel.Controls.Count; i++)
            {
                if (((CheckBox)AgentPanel.Controls[i].Controls[1]).Checked == true) // ищем контролы в которых чекбокс включён (индекс чекбокса = 1)
                {
                    AgentControl AC = (AgentControl)AgentPanel.Controls[i];
                    SelectedAgentIDsForChange.Add(AC.AgentID);                  
                }
            }
            AgentsPriority CAP = new AgentsPriority();
            CAP.Owner = this;
            CAP.ShowDialog();
            SelectedAgentIDsForChange.Clear();
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddAgent AD = new AddAgent();
            AD.Owner = this;
            AD.ShowDialog();
            LoadData();
        }
    }
}
