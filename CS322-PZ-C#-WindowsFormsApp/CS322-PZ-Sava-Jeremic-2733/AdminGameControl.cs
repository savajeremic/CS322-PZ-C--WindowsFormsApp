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
    public partial class AdminGameControl : Form
    {
        MySqlConnection mycon;
        string con = "datasource=localhost;port=3306;username=root;password='';database=cs322";
        DataTable dt = new DataTable();

        public AdminGameControl()
        {
            InitializeComponent();
        }

        private void AdminGameControl_Load(object sender, EventArgs e)
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
                dgvGames.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvGames.Rows[e.RowIndex];

                Shared.game_id = int.Parse(row.Cells["id"].Value.ToString());

                tbName.Text = row.Cells["name"].Value.ToString();
                tbCompany.Text = row.Cells["company"].Value.ToString();
                tbDescription.Text = row.Cells["description"].Value.ToString();
                tbPrice.Text = row.Cells["price"].Value.ToString();
                tbGenre.Text = row.Cells["genre"].Value.ToString();
            }
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                mycon = new MySqlConnection(con);
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM game", mycon);

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                BindingSource bind = new BindingSource();
                bind.DataSource = dt;

                dgvGames.DataSource = bind;
                adapter.Update(dt);
                dgvGames.AutoResizeColumn(0);

                tbName.Text = "";
                tbCompany.Text = "";
                tbDescription.Text = "";
                tbPrice.Text = "";
                tbGenre.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string company = tbCompany.Text;
            string description = tbDescription.Text;
            string price = tbPrice.Text;
            string genre = tbGenre.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(company) ||
                    string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(price) ||
                    string.IsNullOrWhiteSpace(genre))
                {
                    MessageBox.Show("All fields must be filled!");
                }
                else
                {
                    mycon = new MySqlConnection(con);
                    mycon.Open();
                    string query = "INSERT INTO game(name, company, description, price, genre) VALUES(@name, @company, @description, @price, @genre)";

                    MySqlCommand cmd = new MySqlCommand(query, mycon);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@company", company);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@genre", genre);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Admin, you have successfully added a new Game!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string company = tbCompany.Text;
            string description = tbDescription.Text;
            string price = tbPrice.Text;
            string genre = tbGenre.Text;

            try
            {
                mycon = new MySqlConnection(con);
                mycon.Open();
                string query = "UPDATE game SET name=@name, company=@company, description=@description, price=@price, genre=@genre WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(query, mycon);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@company", company);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@genre", genre);
                cmd.Parameters.AddWithValue("@id", Shared.game_id);
                cmd.ExecuteScalar();

                MessageBox.Show("Admin, you have successfully changed a game!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            try
            {
                mycon = new MySqlConnection(con);
                mycon.Open();
                string query = "DELETE FROM game WHERE name=@name";

                MySqlCommand cmd = new MySqlCommand(query, mycon);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteScalar();

                MessageBox.Show("Admin, you have successfully deleted a game!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel adminPanelForm = new AdminPanel();
            adminPanelForm.Show();
            adminPanelForm.FormClosed += (s, args) => this.Close();
        }

        private void AdminGameControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
