using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programming_Asses
{
    public partial class Employee_component : Form
    {
        public Employee_component()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard D1 = new Dashboard(); 
            D1.Show();

        }

        private void Empoyee_component_Load(object sender, EventArgs e)
        {

        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            string id = txt_empid.Text;
            string name = txt_empname.Text;
            string DOB= dateTimePicker1.Text;
            string age= txt_age.Text;
            string Address = txt_address.Text;
            string phoneno = txt_phno.Text;
            string monthlysal = txt_monsal.Text;
            string Ot = txt_overth.Text;
            string Allowance = txt_allo.Text;

            SqlConnection con = new SqlConnection("Data Source=SEMILAAMAJITH;Initial Catalog=GrifindoToys;Integrated Security=True");

            SqlCommand cmd = null;
            cmd = new SqlCommand("insert into Employeecomponent ( Empname, DOB,Age,EmpAddress,Phonenumber,monthlysalary,overtime,Allowance) values('" + name + "','" + DOB + "','" + age + "','" + Address + "','" + phoneno + "','" + monthlysal + "','" + Ot + "','" + Allowance + "')", con);

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
            string id = txt_empid.Text;
            SqlConnection con = new SqlConnection("Data Source=SEMILAAMAJITH;Initial Catalog=GrifindoToys;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("Select * from Employeecomponent where EmployeeID ='" + id + "'", con);

            try
            {
                con.Open();
                SqlDataReader myR = cmd.ExecuteReader(); //get the search result to myR variable

                if (myR.HasRows)
                {
                    while (myR.Read())
                    {

                        txt_empname.Text = myR["Empname"].ToString(); //recheck

                        dateTimePicker1.Text = myR["DOB"].ToString();//recheck
                        txt_age.Text = myR["Age"].ToString();
                        txt_address.Text = myR["EmpAddress"].ToString();
                        txt_phno.Text = myR["Phonenumber"].ToString();
                        txt_monsal.Text = myR["monthlysalary"].ToString();
                        txt_overth.Text = myR["overtime"].ToString();
                        txt_allo.Text = myR["Allowance"].ToString();

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

        private void dateTimePicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //Update Button

            string id = txt_empid.Text;
            string name = txt_empname.Text;
            string DOB = dateTimePicker1.Text;
            string age = txt_age.Text;
            string Address = txt_address.Text;
            string phoneno = txt_phno.Text;
            string monthlysal = txt_monsal.Text;
            string Ot = txt_overth.Text;
            string Allowance = txt_allo.Text;

            SqlConnection con = new SqlConnection("Data Source=SEMILAAMAJITH;Initial Catalog=GrifindoToys;Integrated Security=True");

            //Empname, DOB,Age,EmpAddress,Phonenumber,monthlysalary,overtime,Allowance) values('" + name + "','" + DOB + "','" + age + "','" + Address + "','" + phoneno + "','" + monthlysal + "','" + Ot + "','" + Allowance + "')",

            SqlCommand cmd = null;
            cmd = new SqlCommand("update Employeecomponent set  Empname='" + name + "',DOB='" + DOB + "',Age='" + age + "',EmpAddress='" + Address + "',Phonenumber='" + phoneno + "',monthlysalary='" + monthlysal + "',overtime='" + Ot + "',Allowance='" + Allowance + "' where EmployeeID='" + id + "'", con);

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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string id = txt_empid.Text;
            string name = txt_empname.Text;
            string DOB = dateTimePicker1.Text;
            string age = txt_age.Text;
            string Address = txt_address.Text;
            string phoneno = txt_phno.Text;
            string monthlysal = txt_monsal.Text;
            string Ot = txt_overth.Text;
            string Allowance = txt_allo.Text;

            SqlConnection con = new SqlConnection("Data Source=SEMILAAMAJITH;Initial Catalog=GrifindoToys;Integrated Security=True");

            //SqlCommand cmd = null;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from Employeecomponent where EmployeeID    = '" + id + "' ", con);
                cmd.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Successfully Deleted");

            }
            catch (Exception ee)

            {
                MessageBox.Show(ee.Message); con.Close();
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_empid.Clear();
            txt_empname.Clear();
           
            txt_age.Clear();
            txt_address.Clear();
            txt_phno.Clear();
            txt_monsal.Clear();
            txt_overth.Clear();
            txt_allo.Clear();
        }
    }
}

