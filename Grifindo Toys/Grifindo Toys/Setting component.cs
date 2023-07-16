using Programming_Asses.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Asses
{
    public partial class Setting_component : Form
    {
        public Setting_component()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard D1 = new Dashboard();
            D1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string salary_Range = cmb_range.Text;
            string absent_Count = txt_abcount.Text;
            string holiday_Count = txt_holcount.Text;
            string Ot = txt_overtime.Text;

            SqlConnection con = new SqlConnection("Data Source=SEMILAAMAJITH;Initial Catalog=GrifindoToys;Integrated Security=True");

            SqlCommand cmd = null;
            cmd = new SqlCommand("insert into Setting_Com( Salaryrange, Absentcount,Holidaycount,overtime) values('" + salary_Range + "','" + absent_Count + "','" + holiday_Count + "','" + Ot + "')", con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close(); MessageBox.Show("Successfully Added");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }


        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            SqlConnection con = new SqlConnection("Data Source=SEMILAAMAJITH;Initial Catalog=GrifindoToys;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("Select * from Setting_Com where SettingID ='" + id + "'", con);

            try
            {
                con.Open();
                SqlDataReader myR = cmd.ExecuteReader(); //get the search result to myR variable

                if (myR.HasRows)
                {
                    while (myR.Read())
                    {
                       

                        cmb_range.Text = myR["Salaryrange"].ToString(); //recheck
                        txt_abcount.Text = myR["Absentcount"].ToString();//recheck
                        txt_holcount.Text = myR["Holidaycount"].ToString();
                        txt_overtime.Text = myR["overtime"].ToString();
                       
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, No record from this id..");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Update Button

            string id = txt_id.Text;
            string salary_Range = cmb_range.Text;
            string absent_Count = txt_abcount.Text;
            string holiday_Count = txt_holcount.Text;
            string Ot = txt_overtime.Text;

            SqlConnection con = new SqlConnection("Data Source=SEMILAAMAJITH;Initial Catalog=GrifindoToys;Integrated Security=True");

            SqlCommand cmd = null;
            cmd = new SqlCommand("update Setting_Com set  Salaryrange='" + salary_Range + "',Absentcount='" + absent_Count + "',Holidaycount='" + holiday_Count + "',overtime='" + Ot + "' where SettingID='" + id + "'", con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close(); MessageBox.Show("Successfully Updated");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex); con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string salary_Range = cmb_range.Text;
            string absent_Count = txt_abcount.Text;
            string holiday_Count = txt_holcount.Text;
            string Ot = txt_overtime.Text;

            SqlConnection con = new SqlConnection("Data Source=SEMILAAMAJITH;Initial Catalog=GrifindoToys;Integrated Security=True");

            //SqlCommand cmd = null;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from Setting_Com where SettingID    = '" + id + "' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
               
              
                MessageBox.Show("Successfully Deleted");
              
            }
            catch (Exception ee)

            {
                MessageBox.Show(ee.Message); con.Close(); }

            }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }

    }

