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
    public partial class UserPanel : Form
    {
        MySqlConnection mycon;
        string con = "datasource=localhost;port=3306;username=root;password='';database=cs322";
        DataTable dt = new DataTable();

        public UserPanel()
        {
            InitializeComponent();
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            try
            {
                mycon = new MySqlConnection(con);
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM game;", mycon);

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                BindingSource bind = new BindingSource();
                bind.DataSource = dt;

                dgvGames.DataSource = bind;
                adapter.Update(dt);
                dgvGames.Columns[0].Visible = false;
                dgvGames.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvUserGames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvGames.Rows[e.RowIndex];

                game_id = int.Parse(row.Cells["id"].Value.ToString());
                tbGameToAdd.Text = row.Cells["name"].Value.ToString();
            }
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cart cartForm = new Cart();
            cartForm.Show();
            cartForm.FormClosed += (s, args) => this.Close();
        }

        private void btnUserGames_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserGames userGamesForm = new UserGames();
            userGamesForm.Show();
            userGamesForm.FormClosed += (s, args) => this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login homePanel = new Login();
            homePanel.Show();
            homePanel.FormClosed += (s, args) => this.Close();
        }

        public void searchGame(string gameToFind)
        {
            string searchQuery = "SELECT * FROM game WHERE name LIKE '%" + gameToFind + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvGames.DataSource = table;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            searchGame(tbSearch.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (game_id == 0)
                {
                    MessageBox.Show("Please select a game in order to buy it.");
                }
                else
                {
                    mycon = new MySqlConnection(con);
                    mycon.Open();
                    string query = "INSERT INTO cart_items(game_id, user_id) VALUES(@game_id,@user_id)";

                    MySqlCommand cmd = new MySqlCommand(query, mycon);
                    cmd.Parameters.AddWithValue("@game_id", game_id);
                    cmd.Parameters.AddWithValue("@user_id", Shared.user_id);
                    cmd.ExecuteScalar();

                    MessageBox.Show("User! You have successfully added a game to your cart!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //
        }

        private void UserPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tbGameToAdd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
