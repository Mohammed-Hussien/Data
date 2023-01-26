using Data;
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
   public partial class Departments : Form
{
    Functions Con;
    public Departments()
    {
        InitializeComponent();
        Con = new Functions();
        ListerDepartments();
        ShowDepartments();
    }
    private void ShowDepartments()
    {
        string Query = "Select * from DepartmentTb1";
        DepList.DataSource = Con.GetData(Query);
    }
    private void AddBtn_Click(object sender, EventArgs e)
    {
        try
        {
            if (DepNameTb.Text == "")
            {
                MessageBox.Show("missing data!!!");
            }
            else
            {
                string Dep = DepNameTb.Text;
                string Query = "insert into DepartmentTb1 values('{0}')";
                Query = string.Format(Query, DepNameTb.Text);
                Con.SetData(Query);
                ShowDepartments();
                MessageBox.Show("Department Added!!!");
                DepNameTb.Text = "";
            }
        }
        catch (Exception Ex)
        {
            MessageBox.Show(Ex.Message);
        }
    }
    int key = 0;
    private void DepList_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        DepNameTb.Text = DepList.SelectedRows[0].Cells[0].Value.ToString();
        if (DepNameTb.Text == "")
        {
            key = 0;



        