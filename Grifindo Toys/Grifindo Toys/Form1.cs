using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Asses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            
            string username = txt_user.Text;
            string password = txt_pass.Text;

            if (txt_user.Text == "")
            {
                MessageBox.Show("Enter the Username", "Warning",
                    MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation);
            }


            else if (txt_pass.Text == "")
            {
                MessageBox.Show("Enter the Password", "Warning",
                    MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation);
            }

            else
            {

                try
                {
                    SqlConnection con = new SqlConnection("Data Source=SEMILAAMAJITH;Initial Catalog=GrifindoToys;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("select * from Logintb where username =@UserName and upassword=@Password", con);
                    cmd.Parameters.AddWithValue("@UserName", txt_user.Text);
                    cmd.Parameters.AddWithValue("@Password", txt_pass.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successful..!", "Successful");

                        this.Hide();
                        Dashboard dash = new Dashboard();
                        dash.Show();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Login Credentials, Please check Username and Password then Try Again.",
                          "Invalid login Details",
                            MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);


                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_pass_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
