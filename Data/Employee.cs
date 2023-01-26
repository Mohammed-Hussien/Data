using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMgmt1
{
    public partial class Employees : Form
    {
        Functions Con;
        public Employees()
        {
            InitializeComponent();
            Con = new Functions();
            ShowEmp();
            GetDepartment();
        }
        private void ShowEmp()
        {
            try
            {
                string Query = "Select * from EmployeeTb1";
                EmployeeList.DataSource = Con.GetData(Query);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Employees_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void GetDepartment()
        {
            string Query = "Select * from DepartmentTb1";
            DepCb.DisplayMember = Con.GetData(Query).Columns["Depname"].ToString();
            DepCb.ValueMember = Con.GetData(Query).Columns["Depid"].ToString();
            DepCb.DataSource = Con.GetData(Query);
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySalTb.Text == "")
                {
                    MessageBox.Show("missing data!!!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = GenCb.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(DepCb.SelectedValue.ToString());
                    string DOB = DOBTb.Value.ToString();
                    string JDate = JDateTb.Value.ToString();
                    int Salary = Convert.ToInt32(DailySalTb.Text);
                    string Query = "insert into EmployeeTb1 values('{0}','{1}',{2},'{3}','{4}',{5})";
                    Query = string.Format(Query, Name, Gender, Dep, DOB, JDate, Salary);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Emoloyee Updated!!!");
