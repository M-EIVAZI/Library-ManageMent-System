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
    public partial class ChangeAdminInfo : Form
    {
        public ChangeAdminInfo()
        {
            InitializeComponent();
        }

        private void ChangeAdminInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LMSDB db = new();
            Admins ?admin = db.Admins.FirstOrDefault();
            if (admin != null)
            {
                if (customTextBox1.Texts != "")
                    admin.Name = customTextBox1.Texts;
                if (customTextBox2.Texts != "")
                {
                    var tmp = Hasher.HashPassword(customTextBox2.Texts);
                    admin.password = tmp.HashedPassword;
                    admin.salt=tmp.Salt;
                }
                if (customTextBox4.Texts != "")
                {
                    admin.Email = customTextBox4.Texts;

                }
                db.SaveChangesAsync();
            }
            MessageBox.Show("اطاعات با موفقیت ثبت شد");
        }
    }
}
