using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.Models;
using Microsoft.EntityFrameworkCore;

namespace LMS.ChildForms
{
    public partial class ChangeInfo : Form
    {
        Member UserInfo;

        public ChangeInfo(Member info)
        {
            InitializeComponent();
            UserInfo = info;
        }

        private void ChangeInfo_Load(object sender, EventArgs e)
        {

        }
        private int CountEmpty()
        {
            int count = 0;
            if (customTextBox1.Texts == "")
                count++;
            if (customTextBox2.Texts == "")
                count++;
            if (customTextBox3.Texts == "")
                count++;
            if (customTextBox4.Texts == "")
                count++;
            return count;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (CountEmpty() == 5)
            {
                MessageBox.Show("باید حداقل یک فیلد برای تغییر وارد کنید");
                return;
            }
            if (CountEmpty() < 5)
            {
                LMSDB db = new();
                Member members = db.Members.FirstOrDefault(m => m.Memberid == UserInfo.Memberid);


                if (members != null)
                {
                    members.Name = (customTextBox1.Texts != "") ? customTextBox1.Texts : members.Name;
                    members.Password = (customTextBox2.Texts != "") ? customTextBox2.Texts : members.Password;
                    members.Phone = (customTextBox3.Texts != "") ? customTextBox3.Texts : members.Phone;
                    members.Email = (customTextBox4.Texts != "") ? customTextBox4.Texts : members.Email;
                    db.Entry(members).State = EntityState.Modified;
                    db.SaveChanges();


                }
                MessageBox.Show("اطلاعات با موفقیت تغیییر یافت");
            }

        }
    }
}
