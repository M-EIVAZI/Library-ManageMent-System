//using LMS.Data;
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


    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void customTextBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create an instance of the new form
            NewUserForm newForm = new(new LoginForm());

            // Show the new form
            newForm.Show();

            // When the new form is closed, close the entire application
            newForm.FormClosed += (s, args) => Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                if (comboBox1.Text == "نوع کاربری")
                {
                    MessageBox.Show("نوع کاربری را مشخص کنید");
                    return;

                }
                if (customTextBox1.Texts == "" && customTextBox2.Texts == "")
                {
                    MessageBox.Show("لطفا هر دو رمز عبور و شماره کاربری را وارد کنید");
                    return;

                }
                using (LMSDB db = new())
                {
                    if (comboBox1.Text == "عضو کتابخانه")
                    {
                        if (int.TryParse(customTextBox2.Texts, out int memberId) && !string.IsNullOrEmpty(customTextBox1.Texts))
                        {
                            Member? members = db.Members
                            .FirstOrDefault(m => m.Memberid == memberId);
                            //.Where(p=>Hasher.VerifyPassword(customTextBox1.Texts,p.Password,p.Salt));
                            if (members != null)
                            {
                                if (!Hasher.VerifyPassword(customTextBox1.Texts, members.Password, members.Salt))
                                {
                                    MessageBox.Show(" رمز حساب کاربری یا شماره حساب کاربری اشتباه است");
                                    return;
                                }
                                var membernew = members;
                                //foreach (var member in members)
                                //    membernew = member;
                                MainMenu newform = new(membernew, new LoginForm());
                                newform.Show();
                                this.Hide();
                                newform.FormClosed += (s, args) => Application.Exit();
                            }
                        }
                    }
                    if (comboBox1.Text == "ادمین")
                    {
                        Admins? admin = db.Admins.FirstOrDefault();
                        if (admin != null)
                        {


                            if (Hasher.VerifyPassword(customTextBox1.Texts, admin.password, admin.salt) && customTextBox2.Texts == Convert.ToString(admin.AdminId))
                            {
                                AdminForm newform = new(new LoginForm(), admin);
                                newform.Show();
                                this.Hide();
                                newform.FormClosed += (s, args) => Application.Exit();

                            }
                            else
                                MessageBox.Show("کاربری با این رمز و شماره کاربری وجود ندارد");
                        }


                    }
                    if (comboBox1.Text == "کارمند کتابخانه")
                    {
                        if (int.TryParse(customTextBox2.Texts, out int empid) && !string.IsNullOrEmpty(customTextBox1.Texts))
                        {
                            Employee? employees = db.Employees
                            .FirstOrDefault(m => m.Employeeid == empid);
                            //.Where(p =>Hasher.VerifyPassword(customTextBox1.Texts,p.Password,p.Salt));
                            if(employees.Status=="False")
                            {
                                MessageBox.Show("حساب شما تایید نشده است");
                                return;
                            }
                            if (employees == null)
                            {
                                MessageBox.Show(" رمز حساب کاربری یا شماره حساب کاربری اشتباه است");
                                return;
                            }
                            if (!Hasher.VerifyPassword(customTextBox1.Texts, employees.Password, employees.Salt))
                            {
                                MessageBox.Show(" رمز حساب کاربری یا شماره حساب کاربری اشتباه است");
                                return;
                            }
                            //var membernew = new Employee()
                            EmployeeForm newform = new(new LoginForm(), employees);
                            newform.Show();
                            this.Hide();
                            newform.FormClosed += (s, args) => Application.Exit();

                        }

                    }
                }

                // Continue with the rest of your code using the 'members' IQueryable
            }
            catch(Exception)
            {
                MessageBox.Show("رمز حساب یا شماره کاربری اشتباه هست");
                return;
            }
        }

            
            






        private void customTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Suppress the character
                MessageBox.Show("شماره کاربری فقط شامل عدد است و وارد کردن حرف غیرمجاز است");
            }
        }

        private void customTextBox4__TextChanged(object sender, EventArgs e)
        {



        }
        private void Show_Message(object sender, EventArgs e)
        {


        }

        private void customTextBox1__TextChanged_1(object sender, EventArgs e)
        {

        }

        private void customTextBox2__TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgetPassword newform = new(new LoginForm());
            newform.Show();
            newform.FormClosed += (s, args) => Application.Exit();

        }
    }
}
