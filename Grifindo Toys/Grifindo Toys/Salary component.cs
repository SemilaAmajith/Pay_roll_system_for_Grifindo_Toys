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
    public partial class Salary_component : Form
    {
        public Salary_component()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard D1 = new Dashboard();
            D1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string Startdate = dateTimePicker1.Value.ToString();
            string Enddate= dateTimePicker2.Value.ToString();
            string Absunt_Count= txt_absunt.Text;
            string holiday_Count = txt_holiday.Text;
            string OverTime = txt_Ot.Text;
            

            SqlConnection con = new SqlConnection("Data Source=SEMILAAMAJITH;Initial Catalog=GrifindoToys;Integrated Security=True");

            SqlCommand cmd = null;
            cmd = new SqlCommand("insert into SalaryComponent(StarDate,EndDate,NoOfAbsuntdays,NoOfHolidays,overtime   ) values('"+Startdate+"','"+Enddate+"','" + Absunt_Count + "','" + holiday_Count + "','" + OverTime + "')", con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close(); 
                MessageBox.Show("Successfully Added");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }

        }

        private void Salary_component_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        { 
            string id = txt_id.Text;
            SqlConnection con = new SqlConnection("Data Source=SEMILAAMAJITH;Initial Catalog=GrifindoToys;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("Select * from SalaryComponent where SalaryID ='" + id + "'", con);

            try
            {
                con.Open();
                SqlDataReader myR = cmd.ExecuteReader(); //get the search result to myR variable

                if (myR.HasRows)
                {
                    while (myR.Read())
                    {
                        //Create table SalaryComponent(SalaryID int identity(201, 1) primary key, StartDate Varchar(255), EndDate varchar(255), NoOfAbsuntdays int, 
                            //NoOfHolidays int, overtime float, NoPay float, Grosspay float, Basepay float)

                        dateTimePicker1.Text = myR["StarDate"].ToString(); //recheck
                        dateTimePicker2.Text = myR["EndDate"].ToString();//recheck
                        txt_absunt.Text = myR["NoOfAbsuntdays"].ToString();
                        txt_holiday.Text = myR["NoOfHolidays"].ToString();
                        txt_Ot.Text = myR["overtime"].ToString();
                      
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

        private void button1_Click(object sender, EventArgs e)
        {
            //No-pay-value = (Total_Salary/salary_cycle_date_range) *No_of_absent_days

            double totsal, nopay;
            int salarydaterange = 30;
            double noofabsentdays;

            totsal=Convert.ToDouble(txt_monsal.Text);
            noofabsentdays = Convert.ToDouble(txt_absunt.Text);

            nopay = (totsal / salarydaterange) * noofabsentdays;

            txt_Nopayvalue.Text = nopay.ToString();


            //Base_Pay_Value = Monthly_Salary + Allowance + (Over_Time_Rate * No_Of_Overtime_Hours)
            double Base_Pay_Value, Monthly_Salary, Allowance, Over_Time_Rate, No_Of_Overtime_Hours;

            Monthly_Salary = Convert.ToDouble(txt_monsal.Text);
            Allowance = Convert.ToDouble(txt_allo.Text);
            Over_Time_Rate = Convert.ToDouble(txt_Ot.Text);
            No_Of_Overtime_Hours = Convert.ToDouble(txt_overth.Text);

            Base_Pay_Value = Monthly_Salary + Allowance + (Over_Time_Rate * No_Of_Overtime_Hours);
            txt_basepay.Text = Base_Pay_Value.ToString();

            //Gross_Pay_Value = Base_Pay_Value - (No_Pay_Value + Bass_Pay_Value * Government_tax_rate)

            // I recomended government tax rate 12%

            double Gross_Pay_Value, Government_tax_rate =0.12;
            Gross_Pay_Value = Base_Pay_Value - (nopay + Base_Pay_Value * Government_tax_rate);

            txt_grosspay.Text = Gross_Pay_Value.ToString(); 

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_absunt.Clear();
            txt_allo.Clear();
            txt_basepay.Clear();
            txt_grosspay.Clear();
            txt_holiday.Clear();
            txt_id.Clear();
            txt_iid.Clear();
            txt_monsal.Clear();
            txt_Nopayvalue.Clear();
            txt_Ot.Clear();
            txt_overth.Clear();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string Startdate = dateTimePicker1.Value.ToString();
            string Enddate = dateTimePicker2.Value.ToString();
            string Absunt_Count = txt_absunt.Text;
            string holiday_Count = txt_holiday.Text;
            string OverTime = txt_Ot.Text;

            SqlConnection con = new SqlConnection("Data Source=SEMILAAMAJITH;Initial Catalog=GrifindoToys;Integrated Security=True");

            //SqlCommand cmd = null;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from SalaryComponent where SalaryID    = '" + id + "' ", con);
                cmd.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Successfully Deleted");

            }
            catch (Exception ee)

            {
                MessageBox.Show(ee.Message); con.Close();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            //Update Button

            string id = txt_id.Text;
            string Startdate = dateTimePicker1.Value.ToString();
            string Enddate = dateTimePicker2.Value.ToString();
            string Absunt_Count = txt_absunt.Text;
            string holiday_Count = txt_holiday.Text;
            string OverTime = txt_Ot.Text;

            SqlConnection con = new SqlConnection("Data Source=SEMILAAMAJITH;Initial Catalog=GrifindoToys;Integrated Security=True");

            //StartDate,EndDate,NoOfAbsuntdays,NoOfHolidays,overtime   ) values('"+Startdate+"','"+Enddate+"','" + Absunt_Count + "','" + holiday_Count + "','" + OverTime + "'

            SqlCommand cmd = null;
            cmd = new SqlCommand("update SalaryComponent set  StarDate='" + Startdate + "',EndDate='" + Enddate + "',NoOfAbsuntdays='" + Absunt_Count + "',NoOfHolidays='" + holiday_Count + "',overtime='" + OverTime + "' where SalaryID='" + id + "'", con);

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

        private void btn_Insertcal_Click(object sender, EventArgs e)
        {
            string nopayvalue = txt_Nopayvalue.Text;
            string basepayvalue = txt_basepay.Text;
            string grosspayvalue = txt_grosspay.Text;


            SqlConnection con = new SqlConnection("Data Source=SEMILAAMAJITH;Initial Catalog=GrifindoToys;Integrated Security=True");

            SqlCommand cmd = null;
            cmd = new SqlCommand("insert into Calculate(NPayvalue, GPayvalue, BPayvalue ) values('" + nopayvalue + "','" + basepayvalue + "','" + grosspayvalue + "')", con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Added");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string id = txt_iid.Text;
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

        private void txt_overth_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
