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

namespace LMS
{
    public partial class NewUserForm : Form
    {
        private Form previousform;
        public NewUserForm()
        {
            InitializeComponent();
        }
        public NewUserForm(Form previous)
        {
            previousform = previous;
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu newform = new();

            this.Close();
            newform.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {   //Check details
            try
            {
                if (customTextBox1.Texts == "" && customTextBox2.Texts == "" && customTextBox3.Texts == "" && customTextBox4.Texts == "")
                {
                    MessageBox.Show("لطفا همه اطلاعات خواسته شده را کامل وارد کنید");
                    return;

                }
                else if (comboBox1.Text == "نوع کاربری")
                {
                    MessageBox.Show("نوع کاربری را مشخص کنید");
                    return;
                }
                if (comboBox1.Text == "عضو کتابخانه")
                {   var pass =Hasher.HashPassword(customTextBox1.Text);
                    Member newuser = new() { Name = customTextBox4.Texts, Password = pass.HashedPassword,Salt=pass.Salt, Email = customTextBox3.Texts, Phone = customTextBox2.Texts, Fine = 0 };
                    var context = new LMSDB();
                    context.Add<Member>(newuser);
                    context.SaveChanges();
                    MainMenu newform = new(new LoginForm());
                    newform.Show();
                    this.Hide();
                    newform.FormClosed += (s, args) => Application.Exit();
                }
                if (comboBox1.Text == "کارمند کتابخانه")
                {   var password =Hasher.HashPassword(customTextBox1.Texts);
                    Employee newemployee = new() { Name = customTextBox4.Texts, Password = password.HashedPassword,Salt=password.Salt, Email = customTextBox3.Texts, Phone = customTextBox2.Texts, Status = "False" };
                    var context = new LMSDB();
                    context.Add<Employee>(newemployee);
                    context.SaveChanges();
                    LoginForm lg = new();
                    MessageBox.Show("حساب شما تشکیل شد منتظر تایید حساب توسط ادمین باشید");
                    lg.Show();
                    Employee emp = context.Employees.FirstOrDefault(e =>e.Name==customTextBox4.Texts);
                    MessageBox.Show($"شماره کاربری شما{emp.Employeeid} ");
                    this.Hide();
                    lg.FormClosed += (s, args) => Application.Exit();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            previousform.Show();
            this.Hide();
            previousform.FormClosed += (s, args) => Application.Exit();
        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
