using LMS.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.System;

namespace LMS.ChildForms
{
    public partial class InformationPanel : Form
    {
        Member member;
        public InformationPanel(Member user)
        {   
            InitializeComponent();
            member = user;
        }

        private void Information_Load(object sender, EventArgs e)
        {
          

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InformationPanel_Load(object sender, EventArgs e)
        {
            LMSDB db = new LMSDB();
            Member? mem = db.Members.FirstOrDefault(m => m.Memberid == member.Memberid);
            if (member != null)
            {
                label2.Text = mem.Name;
                label7.Text = Convert.ToString(mem.Memberid);
                label8.Text = mem.Email;
                label9.Text = mem.Phone;
                label10.Text = Convert.ToString(mem.Fine);
            }
        }
    }
}
