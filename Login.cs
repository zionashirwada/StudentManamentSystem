using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Skills_International
{
    public partial class Login : Form
    {
        // Connection to the SQL Server database

        SqlConnection connection = new SqlConnection("Data Source=laptop-i5qu1id4\\sqlexpress;Initial Catalog=Student;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butClear_Click(object sender, EventArgs e)
        {
            txtUName.Clear();
            txtPassword.Clear();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {

            if (txtUName.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Username and Password", "Blank Login credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM login WHERE username=@uName AND password=@uPass", connection);
                cmd.Parameters.AddWithValue("@uName", txtUName.Text);
                cmd.Parameters.AddWithValue("@uPass", txtPassword.Text);

                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpt.Fill(ds);

                int count = ds.Tables[0].Rows.Count;

                if (count == 1)
                {
                    MessageBox.Show("You have successfully logged in.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    Registration fb = new Registration();
                    this.Hide();
                    fb.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Login credentials, please check Username and Password and try again", "Invalid Login credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void butExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
       

    }
}
