using FontAwesome.Sharp;
using LMS.ChildForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.AdminChildForms;
using System.Windows.Forms;
using LMS.Models;
using LMS.EmployeeChildForms;

namespace LMS
{
    public partial class EmployeeForm : Form
    {
        private IconButton currentbtn;
        private Panel rightborderbtn;
        private Form previousform;
        //this is based on weeks
        private Form CurrentChildForm;
        private Employee employee;
        public EmployeeForm()
        {
            InitializeComponent();
            rightborderbtn = new();
            rightborderbtn.Size = new Size(7, 60);
            adminpanelmenu.Controls.Add(rightborderbtn);
        }
        public EmployeeForm(Form previous, Employee admininfo)
        {
            InitializeComponent();
            previousform = previous;
            rightborderbtn = new();
            rightborderbtn.Size = new Size(7, 60);
            adminpanelmenu.Controls.Add(rightborderbtn);
            employee = admininfo;
        }
        private struct RGBColors
        {// #TODO light color
            public static Color color1 = Color.FromArgb(185, 250, 210);
            public static Color color2 = Color.FromArgb(255, 255, 175);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(180, 160, 255);
            public static Color color5 = Color.FromArgb(150, 230, 255);
            public static Color color6 = Color.FromArgb(150, 120, 100);
            public static Color color7 = Color.FromArgb(250, 180, 100);
            public static Color color8 = Color.FromArgb(171, 201, 23);
        }
        //method to highlight selected btn
        private void ActivateButton(object senderbtn, Color color)
        {
            if (senderbtn != null)
            {
                DisableButton();
                currentbtn = (IconButton)senderbtn;
                currentbtn.BackColor = Color.FromArgb(31, 30, 68);
                currentbtn.ForeColor = color;
                currentbtn.TextAlign = ContentAlignment.MiddleLeft;
                currentbtn.IconColor = color;
                currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbtn.ImageAlign = ContentAlignment.TopLeft;
                //right border button
                rightborderbtn.BackColor = color;
                rightborderbtn.Location = new Point(currentbtn.Width - 8, currentbtn.Location.Y);
                rightborderbtn.Visible = true;
                rightborderbtn.BringToFront();
            }


        }
        public void OpenChildForm(Form childform)
        {
            if (CurrentChildForm != null)
                CurrentChildForm.Close();
            CurrentChildForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            ShowPnl.Controls.Add(childform);
            ShowPnl.Tag = childform;
            childform.BringToFront();
            childform.Show();


        }
        //method to disable highlighing a method
        private void DisableButton()
        {
            if (currentbtn != null)
            {
                currentbtn.BackColor = Color.FromArgb(31, 30, 68);
                currentbtn.ForeColor = Color.Gainsboro;
                currentbtn.TextAlign = ContentAlignment.MiddleRight;
                currentbtn.IconColor = Color.Gainsboro;
                currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbtn.ImageAlign = ContentAlignment.MiddleRight;
                currentbtn.Padding = new Padding(90, 0, 20, 0);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new ShowInformation(employee));


        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new LibraryDefaults());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new ViewAllTransactions());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new CheckEmployees());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new ChangeEmployeeInfo(employee));
        }
        private void btnhome_Click(object sender, EventArgs e)
        {
            DisableButton();
            CurrentChildForm.Close();
            rightborderbtn.Visible = false;

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            previousform.Show();
            this.Hide();
            previousform.FormClosed += (s, args) => Application.Exit();
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new BrowseHistory());
        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            OpenChildForm(new RemoveMembers());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new CheckReport());
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            OpenChildForm(new VerifyBooks());
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            ActivateButton(sender ,RGBColors.color1);
            OpenChildForm(new Addbook());
        }
    }
}
