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

namespace LMS
{
    public partial class ForgetPassword : Form
    {
        private Form previousform;
        private Member memberinfo;
        private Employee employeeinfo;
        private bool ismember;
        public ForgetPassword(Form pre)
        {
            InitializeComponent();
            panel3.Hide();
            previousform = pre;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void customTextBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LMSDB db = new();
            if (customTextBox2.Texts == "")
            {
                MessageBox.Show("لطفا شماره کاربری را وارد کنید");
                return;

            }
            if (comboBox1.Text == "نوع کاربر")
            {
                MessageBox.Show("لطفا نوع کاربری را مشخص کنید");
                return;

            }
            if (comboBox1.Text == "عضو کتابخانه")
            {

                Member? member = db.Members.FirstOrDefault(m => m.Memberid == Convert.ToInt32(customTextBox2.Texts));
                if (member != null)
                {
                    memberinfo = member;
                    ismember = true;
                    panel3.Show();
                }
            }
            if (comboBox1.Text == "کارمند کتابخانه")
            {
                Employee? employee = db.Employees.FirstOrDefault(e => e.Employeeid == Convert.ToInt32(customTextBox2.Texts));
                if (employee != null)
                {
                    ismember = false;
                    employeeinfo = employee;
                    panel3.Show();
                }

            }

        }

        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (customTextBox1.Texts == "")
            {
                MessageBox.Show("رمز جدید را وارد کنید");
                return;

            }

            LMSDB db = new();
            if (ismember)
            {
                Member? member = db.Members.FirstOrDefault(m => m.Memberid == memberinfo.Memberid);
                if (member != null)
                {
                    var pass = Hasher.HashPassword(customTextBox1.Texts);
                    member.Password = pass.HashedPassword;
                    member.Salt = pass.Salt;
                    db.Entry(member).State = EntityState.Modified;
                    db.SaveChangesAsync();
                    LoginForm getback = new();
                    getback.ShowDialog();
                    this.Hide();
                    getback.FormClosed += (s, args) => Application.Exit();
                }
            }
            else
            {
                Employee? employee = db.Employees.FirstOrDefault(e => e.Employeeid == employeeinfo.Employeeid);
                if (employee != null)
                {
                    var pass = Hasher.HashPassword(customTextBox1.Texts);
                    employee.Password = pass.HashedPassword;
                    employee.Salt = pass.Salt;
                    db.Entry(employee).State = EntityState.Modified;
                    db.SaveChangesAsync();
                    LoginForm getback = new();
                    getback.ShowDialog();
                    this.Hide();
                    getback.FormClosed += (s, args) => Application.Exit();
                }

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoginForm perviousform = new();
            previousform.Show();
            this.Hide();
            previousform.FormClosed += (s, args) => Application.Exit();
        }
    }
}
