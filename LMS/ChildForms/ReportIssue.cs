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

namespace LMS.ChildForms
{
    public partial class ReportIssue : Form
    { Member UserInfo;
        public ReportIssue(Member member)
        {
            InitializeComponent();
            UserInfo = member;
        }

        private void button1_Click(object sender, EventArgs e)
        {   if(customTextBox1.Texts=="")
            {
                MessageBox.Show("شماره  کتاب را وارد کنید");
                return;

            }
        if(customTextBox2.Texts=="")
            {
                MessageBox.Show("لطفا مشکل را در بخش توضیحات ذکر کنید");
                return;
            }
            LMSDB db = new();
            Reports report = new() { BookId = int.Parse(customTextBox1.Texts), Description = customTextBox2.Texts, MemberId = UserInfo.Memberid };
            db.Add(report);
            db.SaveChanges();
            MessageBox.Show("گزارش با موفقیت ثبت شد");
        }

    }
}
