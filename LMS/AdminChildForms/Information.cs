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

namespace LMS.AdminChildForms
{
    public partial class Information : Form
    {
        Admins admin;
        public Information()
        {
            InitializeComponent();
        }

        private void Information_Load(object sender, EventArgs e)
        {
            LMSDB db = new();
            Admins ?admin = db.Admins.FirstOrDefault();
            if (admin != null)
            {
                label5.Text = admin.Name;
                label7.Text = admin.Email;
                label8.Text = Convert.ToString(admin.AdminId);
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
