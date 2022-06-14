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
    public partial class AgentControl : UserControl
    {
        public AgentControl(int GetAgentID, string GetAgentType, string GetAgentName, string GetSales, string GetPhone, int GetPriority, string GetPathToImage, string GetEmail, 
            string GetAddress, string GetINN, string GetKPP, string GetDirectorName)
        {
            InitializeComponent();
            AgentID = GetAgentID;
            AgentNameLabel.Text = GetAgentType + " | " + GetAgentName;          
            PhoneLabel.Text = GetPhone;
            PriorityLabel.Text = "Приоритет: " + GetPriority.ToString();
            Email = GetEmail;
            Address = GetAddress;
            INN = GetINN;
            KPP = GetKPP;
            DirectorName = GetDirectorName;
            if (GetPathToImage != "-") 
            {
                DBPathToImage = GetPathToImage;
                ImageBox.ImageLocation = Environment.CurrentDirectory + "\\agents\\"+GetPathToImage; 
            }
            else
            {
                ImageBox.ImageLocation = Environment.CurrentDirectory + "\\picture.png";
            }

            if (GetSales != "")
            {
                SalesLabel.Text = GetSales + " продаж за последние 5 лет";
                if (Convert.ToInt32(GetSales) > 10000)
                {
                    Discount = 5;
                }
                else if (Convert.ToInt32(GetSales) > 50000)
                {
                    Discount = 10;
                }
                else if (Convert.ToInt32(GetSales) > 150000)
                {
                    Discount = 20;
                }
                else if (Convert.ToInt32(GetSales) > 500000)
                {
                    Discount = 25;
                    this.BackColor = Color.LightGreen;
                }
            }
            else { SalesLabel.Text = "0 продаж за последние 5 лет"; }
            DiscountLabel.Text = "Скидка агенту: " + Discount;

        }
        string SqlStr;
        MySqlCommand Cmd;
        public int AgentID;
        public string DBPathToImage;
        int Discount = 0;
        string Email;
        string DirectorName;
        string INN;
        string KPP;
        string Address;
        private void UserControl1_Load(object sender, EventArgs e)
        {
            if (Program.Role == "Manager" || Program.Role == "User")
            {
                EditBTN.Visible = true;
            }
            if (Program.Role == "Manager")
            {
                ForChangePriority.Visible = true;
            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Sql.Connection.Open();

                SqlStr = $"delete from agent where Id = {AgentID}";
                Cmd = new MySqlCommand(SqlStr, Sql.Connection);
                Cmd.ExecuteNonQuery();

                Sql.Connection.Close();

                MessageBox.Show($"Данные агента {AgentNameLabel.Text} удалены");

                (FindForm() as Agents).LoadData();
            }
            catch
            {
                MessageBox.Show($"Данные агента {AgentNameLabel.Text} не получилось удалить");
            }
        }
        private void EditBTN_Click(object sender, EventArgs e)
        {
            EditAgent EA = new EditAgent(AgentID, AgentNameLabel.Text.Split('|')[0].Trim(), AgentNameLabel.Text.Split('|')[1].Trim(), 
                Address, INN, KPP,DirectorName, PhoneLabel.Text, Email,
                Convert.ToInt32(PriorityLabel.Text.Split(':')[1].Trim()), DBPathToImage);
            EA.ShowDialog();
            (FindForm() as Agents).LoadData();
        }

        private void DiscountLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
