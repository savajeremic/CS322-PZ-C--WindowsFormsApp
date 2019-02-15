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
    public partial class Cart : Form
    {
        MySqlConnection mycon;
        string con = "datasource=localhost;port=3306;username=root;password='';database=cs322";
        DataTable dt = new DataTable();

        public Cart()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserPanel userPanelForm = new UserPanel();
            userPanelForm.Show();
            userPanelForm.FormClosed += (s, args) => this.Close();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            try
            {
                mycon = new MySqlConnection(con);
                mycon.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT game.name, game.company, game.description, game.price, game.genre FROM game " +
                    "JOIN cart_items ON cart_items.game_id = game.id WHERE user_id=@user_id AND flag=1;", mycon);

                cmd.Parameters.AddWithValue("@user_id", Shared.user_id);
                cmd.ExecuteScalar();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                BindingSource bind = new BindingSource();
                bind.DataSource = dt;

                dgvCart.DataSource = bind;
                adapter.Update(dt);
                dgvCart.Columns[0].Visible = false;
                dgvCart.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            mycon = new MySqlConnection(con);
            mycon.Open();
            string query= "UPDATE cart_items SET flag = 2 WHERE flag = 1 AND user_id = @user_id;";

            MySqlCommand cmd = new MySqlCommand(query, mycon);
            cmd.Parameters.AddWithValue("@user_id", Shared.user_id);
            cmd.ExecuteScalar();

            MessageBox.Show("User! You have successfully bough all the games from the cart!");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            mycon = new MySqlConnection(con);
            mycon.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT game.name, game.company, game.description, game.price, game.genre FROM game " +
                "JOIN cart_items ON cart_items.game_id = game.id WHERE user_id=@user_id AND flag=1;", mycon);

            cmd.Parameters.AddWithValue("@user_id", Shared.user_id);
            cmd.ExecuteScalar();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            BindingSource bind = new BindingSource();
            bind.DataSource = dt;

            dgvCart.DataSource = bind;
            adapter.Update(dt);
            dgvCart.Columns[0].Visible = false;
            dgvCart.AutoResizeColumns();
        }

        private void Cart_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
