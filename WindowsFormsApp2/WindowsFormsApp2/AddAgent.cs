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
    public partial class AddAgent : Form
    {
        public AddAgent()
        {
            InitializeComponent();
        }

        string SqlStr;
        char PressedKey;
        string ImagePath;
        MySqlCommand Cmd;
        MySqlDataAdapter Adapter;
        DataTable AgentTypes = new DataTable();

        private void AddAgent_Load(object sender, EventArgs e)
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

        }

        private void AddAgentBtn_Click(object sender, EventArgs e)
        {
            try 
            { 
                Sql.Connection.Open();
                SqlStr = $@"insert into agent(Title,AgentTypeID,Address,INN,KPP,DirectorName,Phone,Email,Logo,Priority) " +
                $@"values ('{TitleAgentBox.Text}', '{AgentTypeBox.SelectedValue}','{AgentAddressBox.Text}','{AgentINNBox.Text}'," +
                $@"'{AgentKPPBox.Text}','{AgentDirectorBox.Text}','{PhoneBox.Text}','{EmailBox.Text}','{ImagePath}','{(int)PriorityBox.Value}');";
                Cmd = new MySqlCommand(SqlStr, Sql.Connection);
                Cmd.ExecuteNonQuery();

                MessageBox.Show("Агент добавлен");
                Sql.Connection.Close();
                this.Close();
             }
            catch { MessageBox.Show("Агент не добавлен"); }

}

        private void AgentKPPBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void AgentINNBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressedKey = e.KeyChar;
            if (!Char.IsDigit(PressedKey) && PressedKey != 8)
            {
                e.Handled = true;
            }
        }

        private void AddLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.ShowDialog();
            LogoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoBox.ImageLocation = OFD.FileName;
            ImagePath = LogoBox.ImageLocation.Substring(OFD.FileName.IndexOf(@"\agents\")).Replace("\\", "\\\\");
        }
    }
}
