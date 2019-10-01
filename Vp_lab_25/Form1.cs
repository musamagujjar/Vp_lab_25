using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vp_lab_25
{
    public partial class Form1 : Form
    {
        DataTable dta = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label7.Text = dta.Rows[comboBox1.SelectedIndex]["ID"].ToString();
            label8.Text = dta.Rows[comboBox1.SelectedIndex]["Name"].ToString();
            label9.Text = dta.Rows[comboBox1.SelectedIndex]["Age"].ToString();
            label10.Text = dta.Rows[comboBox1.SelectedIndex]["Semester"].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dta.Columns.Add("ID", typeof(int));
            dta.Columns.Add("Name");
            dta.Columns.Add("Age");
            dta.Columns.Add("Semester");
            dta.Rows.Add(1, "Ahmed", "26", "4");
            dta.Rows.Add(2, "Ali", "24", "4");
            dta.Rows.Add(3, "Ahsan", "25", "4");
            dta.Rows.Add(4, "Ahzaz", "27", "4");
            comboBox1.DataSource = dta;
            comboBox1.DisplayMember = "Name";
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}
