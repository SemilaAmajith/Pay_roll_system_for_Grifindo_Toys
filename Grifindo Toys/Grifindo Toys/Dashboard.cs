using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Asses
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Salary_component sac = new Salary_component();
            sac.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_component ec = new Employee_component();
            ec.Show();
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            this.Hide();
            Setting_component sc = new Setting_component();
            sc.Show();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {

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
