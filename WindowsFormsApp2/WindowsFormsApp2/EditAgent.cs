using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class EditAgent : Form
    {
        public EditAgent(int GetAgentID, string GetAgentType, string GetAgentName, string GetAgentAddress, string GetAgentINN, 
            string GetAgentKPP, string GetDirector, string GetPhone, string GetAgentEmail, int GetPriority, string GetPathToImage)
        {
            InitializeComponent();
            AgentID = GetAgentID;
            AgentType = GetAgentType;
            TitleAgentBox.Text = GetAgentName;
            AgentAddressBox.Text = GetAgentAddress;
            AgentINNBox.Text = GetAgentINN;
            AgentKPPBox.Text = GetAgentKPP;
            AgentDirectorBox.Text = GetDirector;
            PhoneBox.Text = GetPhone;
            EmailBox.Text = GetAgentEmail;
            PriorityBox.Value = GetPriority;
            ImagePath = GetPathToImage;
            LogoBox.ImageLocation = Program.ImagePath + GetPathToImage;
        }

        int AgentID;
        string ImagePath;
        char PressedKey;
        string SqlStr;
        string AgentType;
        MySqlCommand Cmd;
        MySqlDataAdapter Adapter;
        DataTable AgentTypes = new DataTable();
        private void EditAgent_Load(object sender, EventArgs e)
        {
            SqlStr = "SELECT ID, Title FROM agenttype;";
            Adapter = new MySqlDataAdapter(SqlStr, Sql.Connection);
            Adapter.Fill(AgentTypes);

            AgentTypeBox.ValueMember = "ID";
            AgentTypeBox.DisplayMember = "Title";

            AgentTypeBox.DataSource = AgentTypes;


            AgentINNBox.MaxLength = 12;
            AgentKPPBox.MaxLength = 9;
            TitleAgentBox.MaxLength = 150;
            AgentDirectorBox.MaxLength = 150;
            PhoneBox.MaxLength = 30;
            EmailBox.MaxLength = 255;

            if (Program.Role == "User")
            {
                EmailBox.Enabled = false;
                AgentAddressBox.Enabled = false;
                AgentDirectorBox.Enabled = false;
                AgentINNBox.Enabled = false;
                AgentKPPBox.Enabled = false;
                AgentTypeBox.Enabled = false;
                PriorityBox.Enabled = false;
                TitleAgentBox.Enabled = false;
                PhoneBox.Enabled = false;
            }

            AgentTypeBox.Text = AgentType;
        }

        private void AddLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.ShowDialog();
            LogoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoBox.ImageLocation = OFD.FileName;
            ImagePath = LogoBox.ImageLocation.Substring(OFD.FileName.IndexOf(@"\agents\")).Replace("\\", "\\\\");
        }

        private void AgentKPPBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressedKey = e.KeyChar;
            if (!Char.IsDigit(PressedKey) && PressedKey != 8)
            {
                e.Handled = true;
            }
        }

        private void AgentINNBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressedKey = e.KeyChar;
            if (!Char.IsDigit(PressedKey) && PressedKey != 8)
            {
                e.Handled = true;
            }
        }

        private void PhoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressedKey = e.KeyChar;
            {
                if (!Char.IsDigit(PressedKey) && PressedKey != 8 && PressedKey != 40 && PressedKey != 41 && PressedKey != 43 && PressedKey != 32 && PressedKey != 45)
                    e.Handled = true;
            }
        }

        private void EditAgentBtn_Click(object sender, EventArgs e)
        {
            try
            {
            Sql.Connection.Open();
                SqlStr = "UPDATE agent SET " +
                    $"Title = '{TitleAgentBox.Text}', AgentTypeID = '{AgentTypeBox.SelectedValue}', Address = '{AgentAddressBox.Text}', " +
                    $"INN = '{AgentINNBox.Text}', KPP = '{AgentKPPBox.Text}', DirectorName = '{AgentDirectorBox.Text}', " +
                    $"Phone = '{PhoneBox.Text}', Email = '{EmailBox.Text}', Logo = '{ImagePath}', Priority = {PriorityBox.Value} WHERE (`ID` = '{AgentID}')";
                Cmd = new MySqlCommand(SqlStr, Sql.Connection);
                Cmd.ExecuteNonQuery();

            SqlStr = $"insert into agentpriorityhistory (`AgentID`, `ChangeDate`, `PriorityValue`) " +
                     $"VALUES ('{AgentID}', '{DateTime.Now.ToString("yyyy-MM-dd")}', '{PriorityBox.Value}');";
            Cmd = new MySqlCommand(SqlStr, Sql.Connection);
            Cmd.ExecuteNonQuery();
            MessageBox.Show("Данные изменены");
            Sql.Connection.Close();
            this.Close();
            }
            catch { MessageBox.Show("Данные не изменены"); }
        }
    }
}
