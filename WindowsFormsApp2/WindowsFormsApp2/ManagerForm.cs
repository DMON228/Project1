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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agents f1 = new Agents();
            f1.ShowDialog();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Autorization newauto = new Autorization();
            newauto.Show();
        }
    }
}
