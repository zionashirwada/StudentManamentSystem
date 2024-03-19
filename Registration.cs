using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skills_International
{
    public partial class Registration : Form
    {

        public Registration()
        {
            InitializeComponent();
            this.Load += Registration_Load;

        }
        private void Registration_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=laptop-i5qu1id4\\sqlexpress;Initial Catalog=Student;Integrated Security=True"))
                {
                    con.Open();
                    string query_select = "SELECT regNo FROM detail";
                    SqlCommand cmd = new SqlCommand(query_select, con);
                    SqlDataReader row = cmd.ExecuteReader();

                    Comboreg.Items.Clear();

                    Comboreg.Items.Add("New Register");

                    while (row.Read())
                    {
                        Comboreg.Items.Add(row["regNo"].ToString());
                    }

                    con.Close();

                    btnClear.Enabled = false;
                    btnRegister.Enabled = false;
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\nStack Trace: {ex.StackTrace}", "Load Registration Numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                //int regNo = int.Parse(Comboreg.Text);
                string firstName = txtFName.Text;
                string lastName = txtSName.Text;
                string dob = dateOB.Value.ToString("yyyy/M/dd");
                string gender;
                if (Gmale.Checked)
                { gender = "Male"; }
                else
                { gender = "Female"; }
                string address = txtAddress.Text;
                string email = txteail.Text;
                int mobilePhone = int.Parse(txtmobile.Text);
                int homePhone = int.Parse(txthome.Text);
                string parent = txtParent.Text;
                string nic = txtNICbox.Text;
                int contactNo = int.Parse(txtcontactNo.Text);
                int newRegNo = 0;
                if (Comboreg.Text == "New Register")
                {

                    using (SqlConnection con = new SqlConnection("Data Source=laptop-i5qu1id4\\sqlexpress;Initial Catalog=Student;Integrated Security=True"))
                    {
                        con.Open();
                        string query_select = "SELECT MAX(regNo) FROM detail";
                        SqlCommand cmd = new SqlCommand(query_select, con);
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            // If there are existing registration numbers, increment the maximum by 1
                            newRegNo = Convert.ToInt32(result) + 1;

                        }
                        else
                        {
                            // If there are no existing registration numbers, start from 1
                            Comboreg.Text = "1";
                        }


                        con.Close();
                    }



                    string query = "INSERT INTO detail (regNo,firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parent, nic, contactNo) " +
                               $"VALUES ('{newRegNo}','{firstName}', '{lastName}', '{dob}', '{gender}', '{address}', '{email}', {mobilePhone}, {homePhone}, '{parent}', '{nic}', {contactNo})";

                    using (SqlConnection con = new SqlConnection("Data Source=laptop-i5qu1id4\\sqlexpress;Initial Catalog=Student;Integrated Security=True"))
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Record added successfully!", "Registration Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("You cannot Add RegNo Mannually!", "Registration Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Registration Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                string regNo = Comboreg.Text;

                if (regNo != "new Register")
                {
                    string firstName = txtFName.Text;
                    string lastName = txtSName.Text;
                    string dob = dateOB.Value.ToString("yyyy/M/dd"); // Assuming you want the date in the format "YYYY/M/DD"
                    string gender;
                    if (Gmale.Checked)
                    { gender = "Male"; }
                    else
                    { gender = "Female"; }
                    string address = txtAddress.Text;
                    string email = txteail.Text;
                    int mobilePhone = int.Parse(txtmobile.Text);
                    int homePhone = int.Parse(txthome.Text);
                    string parent = txtParent.Text;
                    string nic = txtNICbox.Text;
                    int contactNo = int.Parse(txtcontactNo.Text);

                    string query = $"UPDATE detail SET firstName='{firstName}', lastName='{lastName}', dateOfBirth='{dob}', gender='{gender}', " +
                                   $"address='{address}', email='{email}', mobilePhone={mobilePhone}, homePhone={homePhone}, parent='{parent}', " +
                                   $"nic='{nic}', contactNo={contactNo} WHERE regNo={regNo}";

                    using (SqlConnection con = new SqlConnection("Data Source=laptop-i5qu1id4\\sqlexpress;Initial Catalog=Student;Integrated Security=True"))
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Record Updated successfully!", "Updated Registration Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid registration number.", "Invalid Registration Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Updated Registration Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            try
            {
                // Clear TextBoxes
                Comboreg.Text = "";
                txtFName.Text = "";
                txtSName.Text = "";
                txtAddress.Text = "";
                txteail.Text = "";
                txtmobile.Text = "";
                txthome.Text = "";
                txtParent.Text = "";
                txtNICbox.Text = "";
                txtcontactNo.Text = "";

                // Reset DateTimePicker
                dateOB.Format = DateTimePickerFormat.Custom;
                dateOB.CustomFormat = "yyyy/MM/dd";
                dateOB.Value = DateTime.Today;

                // Uncheck radio buttons
                Gmale.Checked = false;
                GFMale.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Clear Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure, Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string regNo = Comboreg.Text;

                    if (!string.IsNullOrEmpty(regNo))
                    {
                        using (SqlConnection con = new SqlConnection("Data Source=laptop-i5qu1id4\\sqlexpress;Initial Catalog=Student;Integrated Security=True"))
                        {
                            con.Open();

                            string query = $"DELETE FROM detail WHERE regNo = {regNo}";

                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Record Deleted Successfully!", "Deleted Registration Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                        btnClear.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid registration number.", "Invalid Registration Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Close();
        }

        private void Exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        
      
        private void Comboreg_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string no = Comboreg.Text;

                if (no != "New Register")
                {
                    using (SqlConnection con = new SqlConnection("Data Source=laptop-i5qu1id4\\sqlexpress;Initial Catalog=Student;Integrated Security=True"))
                    {
                        con.Open();
                        string query_select = "SELECT * FROM detail WHERE regNo = " + no;
                        SqlCommand cmd = new SqlCommand(query_select, con);
                        SqlDataReader row = cmd.ExecuteReader();

                        if (row.Read())
                        {
                            txtFName.Text = row[1].ToString();
                            txtSName.Text = row[2].ToString();
                            dateOB.Format = DateTimePickerFormat.Custom;
                            dateOB.CustomFormat = "yyyy/MM/dd";
                            dateOB.Text = row[3].ToString();

                            if (row[4].ToString() == "Male")
                            {
                                Gmale.Checked = true;
                                GFMale.Checked = false;
                            }
                            else
                            {
                                Gmale.Checked = false;
                                GFMale.Checked = true;
                            }

                            txtAddress.Text = row[5].ToString();
                            txteail.Text = row[6].ToString();
                            txtmobile.Text = row[7].ToString();
                            txthome.Text = row[8].ToString();
                            txtParent.Text = row[9].ToString();
                            txtNICbox.Text = row[10].ToString();
                            txtcontactNo.Text = row[11].ToString();

                            btnRegister.Enabled = false;
                            btnUpdate.Enabled = true;
                            btnDelete.Enabled = true;
                        }

                        con.Close();
                    }
                }
                else
                {
                    txtFName.Text = "";
                    txtSName.Text = "";
                    dateOB.Format = DateTimePickerFormat.Custom;
                    dateOB.CustomFormat = "yyyy/MM/dd";
                    DateTime thisDay = DateTime.Today;
                    dateOB.Text = thisDay.ToString();

                    Gmale.Checked = true;
                    GFMale.Checked = false;

                    txtAddress.Text = "";
                    txteail.Text = "";
                    txtmobile.Text = "";
                    txthome.Text = "";
                    txtParent.Text = "";
                    txtNICbox.Text = "";
                    txtcontactNo.Text = "";

                    btnRegister.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Load Registration Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
