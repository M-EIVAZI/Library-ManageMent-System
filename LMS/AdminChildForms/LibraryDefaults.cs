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
    public partial class LibraryDefaults : Form
    {
        int MAX_LOAN_TIME;
        int MAX_LOAN_NUMBER;
        int Fine_Default;
        public LibraryDefaults()
        {
            InitializeComponent();
        }

        private void LibraryDefaults_Load(object sender, EventArgs e)
        {
            LMSDB db = new();
            Configurations? config = db.Configurations.FirstOrDefault();
            if (config == null)
            {
                MessageBox.Show("Error");
                return;
            }
            else
            {
                MAX_LOAN_NUMBER = config.MaxLoanNumber;
                MAX_LOAN_TIME=config.MaxLoanTime;
                Fine_Default = config.FineDefault;

                    
            }
            label5.Text = MAX_LOAN_TIME.ToString();
            label3.Text= MAX_LOAN_NUMBER.ToString();
            label6.Text = Fine_Default.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LMSDB db = new();
            if(customTextBox1.Texts=="" &&  customTextBox2.Texts=="" && customTextBox3.Texts=="")
            {
                MessageBox.Show("حداقل یکی از فیلدها نباید خالی باشد.");
                return;
            }
            if (customTextBox1.Texts != "")
            {           
                Configurations con=db.Configurations.FirstOrDefault();
                if (con != null)
                {
                    db.Configurations.Remove(con);
                    db.SaveChanges();

                }
                MAX_LOAN_TIME = int.Parse(customTextBox1.Texts);
                Configurations? config = new() { MaxLoanTime = MAX_LOAN_TIME, MaxLoanNumber = MAX_LOAN_NUMBER, FineDefault = Fine_Default};
                config.MaxLoanTime = MAX_LOAN_TIME;
                db.Add(config);
                db.SaveChangesAsync();

                label5.Text = MAX_LOAN_TIME.ToString();
                return;

            }
            if(customTextBox2.Texts!="")
            {   MAX_LOAN_NUMBER = int.Parse(customTextBox2.Texts);
                Configurations? config = db.Configurations.FirstOrDefault();
                config.MaxLoanNumber =MAX_LOAN_NUMBER;
                if (config != null)
                {
                    db.Entry(config).State = EntityState.Modified;
                    db.SaveChangesAsync();
                }
                label3.Text = MAX_LOAN_NUMBER.ToString();
                return;

            }
            if(customTextBox3.Texts!="")
            {   Fine_Default=int.Parse(customTextBox3.Texts);
                Configurations? config = db.Configurations.FirstOrDefault();
                config.FineDefault =Fine_Default;
                if (config != null)
                {
                    db.Entry(config).State = EntityState.Modified;
                    db.SaveChangesAsync();
                }
                label6.Text= Fine_Default.ToString();
                return;
            }


        }
    }
}
