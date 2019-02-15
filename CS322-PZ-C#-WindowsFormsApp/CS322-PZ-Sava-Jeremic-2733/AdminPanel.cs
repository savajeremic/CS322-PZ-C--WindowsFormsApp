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

namespace CS322_PZ_Sava_Jeremic_2733
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            
        }

        private void AdminPanel_closeForm(Object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminUserControl adminUserControlForm = new AdminUserControl();
            adminUserControlForm.FormClosed += (s, args) => this.Close();
            adminUserControlForm.Show();
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminGameControl adminGameControlForm = new AdminGameControl();
            adminGameControlForm.FormClosed += (s, args) => this.Close();
            adminGameControlForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login homePanel = new Login();
            homePanel.Show();
            homePanel.FormClosed += (s, args) => this.Close();
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
