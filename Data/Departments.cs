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


        