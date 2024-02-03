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

namespace LMS.EmployeeChildForms
{
    public partial class ChangeEmployeeInfo : Form
    {
        private Employee employee;
        public ChangeEmployeeInfo(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void ChangeEmployeeInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   if(customTextBox1.Texts=="" &&  customTextBox2.Texts=="" && customTextBox3.Texts=="" && customTextBox4.Texts=="")
            {
                MessageBox.Show("حداقل یک اطلاعات باید وارد کنید");
                return;

            }
            LMSDB db = new LMSDB();
            Employee? emp = db.Employees.FirstOrDefault(e => e.Employeeid == employee.Employeeid);
            if (emp == null)
            {
                MessageBox.Show("چنین کاربری وجود ندارد");
                return;
            }
            else
            {   if(customTextBox1.Texts!="")
                    emp.Name = customTextBox1.Texts;
                if(customTextBox2.Texts!="")
                    emp.Email = customTextBox2.Texts;
                if( customTextBox3.Texts!="")
                {
                    var pass = Hasher.HashPassword(customTextBox3.Texts);
                    emp.Password = pass.HashedPassword;
                    emp.Salt = pass.Salt;
                        
                }
                if(customTextBox4.Texts!="")
                    emp.Phone= customTextBox4.Texts;
                db.Entry(emp).State = EntityState.Modified;
                db.SaveChangesAsync();
                MessageBox.Show("اطاعات با موفقیت ثبت شد");

            }

        }
    }
}
