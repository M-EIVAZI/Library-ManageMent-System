using LMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.EmployeeChildForms
{
    public partial class ShowInformation : Form
    {
        readonly Employee employee;
        public ShowInformation(Employee emp)
        {
            InitializeComponent();
            employee = emp;
        }

        private void ShowInformation_Load(object sender, EventArgs e)
        {
            LMSDB db = new();
            Employee? emp=db.Employees.FirstOrDefault(e=>e.Employeeid==employee.Employeeid);
            if (emp != null)
            {
                label2.Text = emp.Name;
                label7.Text = emp.Employeeid.ToString();
                label8.Text = emp.Email;
                label9.Text=emp.Phone;

            }
        }
    }
}
