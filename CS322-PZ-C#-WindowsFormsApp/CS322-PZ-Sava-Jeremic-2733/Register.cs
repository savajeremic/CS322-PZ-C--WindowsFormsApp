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
    public partial class Register : Form
    {
        MySqlConnection mycon;
        string con = "datasource=localhost;port=3306;username=root;password='';database=cs322";
        public Register()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string email = tbEmail.Text;
            string name = tbName.Text;
            string surname = tbSurname.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                    string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(name) ||
                    string.IsNullOrWhiteSpace(surname))
                {
                    MessageBox.Show("All fields must be filled to register!");
                }
                if (checkIfUserExists())
                {
                    MessageBox.Show("Username " + tbUsername.Text + " already exists!");
                }
                if(!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password) &&
                    !string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(name) &&
                    !string.IsNullOrWhiteSpace(surname) && !checkIfUserExists())
                {
                    mycon = new MySqlConnection(con);
                    mycon.Open();
                    string query = "INSERT INTO user(username,password,email,name,surname) " +
                        "VALUES(@username,@password,@email,@name,@surname)";

                    MySqlCommand cmd = new MySqlCommand(query, mycon);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@surname", surname);

                    cmd.ExecuteNonQuery();

                    this.Hide();
                    Login loginForm = new Login();
                    loginForm.FormClosed += (s, args) => this.Close();
                    loginForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool checkIfUserExists()
        {
            mycon = new MySqlConnection(con);
            MySqlCommand cmd = new MySqlCommand("Select count(*) from user where username=@username", mycon);
            cmd.Parameters.AddWithValue("@username", tbUsername.Text);
            mycon.Open();
            int TotalRows = 0;
            TotalRows = Convert.ToInt32(cmd.ExecuteScalar());
            MySqlDataReader dr = cmd.ExecuteReader();
            if (TotalRows > 0)
            {
                while (dr.Read())
                {
                    return true;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home homeForm = new Home();
            homeForm.Show();
            homeForm.FormClosed += (s, args) => this.Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
