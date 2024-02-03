using LMS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.AdminChildForms
{
    public partial class CheckEmployees : Form
    {
        public CheckEmployees()
        {
            InitializeComponent();
        }

        private void CheckEmployees_Load(object sender, EventArgs e)
        {
            LMSDB db = new();
            IQueryable<Employee> employees = db.Employees.Where(e => EF.Functions.Like(e.Status, "False"));
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            if (!employees.Any())
            {
                MessageBox.Show("درخواستی برای تایید وجود ندارد");
                return;
            }
            else
            {
                foreach (var emp in employees)
                    dataGridView1.Rows.Add(emp.Employeeid, emp.Name, emp.Phone, emp.Email);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            { LMSDB db = new();
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                Employee ?employee = db.Employees.FirstOrDefault(e => e.Employeeid == Convert.ToInt32(selectedRow.Cells[0].Value));
                if (employee != null)
                {
                    employee.Status = "True";
                    DialogResult dr = MessageBox.Show( "آیا مطمئن هستید که میخواهید این کارمند را اضافه کنید", "تاییدیه", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        
                        db.SaveChangesAsync();
                        MessageBox.Show("در خواست با موفقیت تایید شد");
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
