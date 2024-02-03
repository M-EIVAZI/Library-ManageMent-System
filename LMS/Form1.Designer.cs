namespace LMS
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            userpanelmenu = new Panel();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            iconButton7 = new FontAwesome.Sharp.IconButton();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnhome = new PictureBox();
            paneltitlebar = new Panel();
            pictureBox3 = new PictureBox();
            usertypelabel = new Label();
            usertypeicon = new FontAwesome.Sharp.IconPictureBox();
            bookBindingSource = new BindingSource(components);
            panel1 = new Panel();
            ShowPnl = new Panel();
            openFileDialog1 = new OpenFileDialog();
            userpanelmenu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnhome).BeginInit();
            paneltitlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usertypeicon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            SuspendLayout();
            // 
            // userpanelmenu
            // 
            userpanelmenu.BackColor = Color.FromArgb(31, 30, 68);
            userpanelmenu.Controls.Add(iconButton8);
            userpanelmenu.Controls.Add(iconButton7);
            userpanelmenu.Controls.Add(iconButton6);
            userpanelmenu.Controls.Add(iconButton2);
            userpanelmenu.Controls.Add(iconButton5);
            userpanelmenu.Controls.Add(iconButton4);
            userpanelmenu.Controls.Add(iconButton3);
            userpanelmenu.Controls.Add(iconButton1);
            userpanelmenu.Controls.Add(panel2);
            userpanelmenu.Dock = DockStyle.Right;
            userpanelmenu.Location = new Point(980, 0);
            userpanelmenu.Name = "userpanelmenu";
            userpanelmenu.Size = new Size(250, 650);
            userpanelmenu.TabIndex = 0;
            userpanelmenu.Paint += panel1_Paint;
            // 
            // iconButton8
            // 
            iconButton8.Dock = DockStyle.Bottom;
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.Font = new Font("Segoe UI", 7F);
            iconButton8.ForeColor = Color.Gainsboro;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.File;
            iconButton8.IconColor = Color.White;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.ImageAlign = ContentAlignment.MiddleRight;
            iconButton8.Location = new Point(0, 590);
            iconButton8.Name = "iconButton8";
            iconButton8.Padding = new Padding(90, 0, 20, 0);
            iconButton8.RightToLeft = RightToLeft.No;
            iconButton8.Size = new Size(250, 60);
            iconButton8.TabIndex = 10;
            iconButton8.Text = "گزارش نقصی";
            iconButton8.TextAlign = ContentAlignment.MiddleRight;
            iconButton8.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButton8.UseMnemonic = false;
            iconButton8.Click += iconButton8_Click;
            // 
            // iconButton7
            // 
            iconButton7.Dock = DockStyle.Top;
            iconButton7.FlatAppearance.BorderSize = 0;
            iconButton7.FlatStyle = FlatStyle.Flat;
            iconButton7.Font = new Font("Segoe UI", 7F);
            iconButton7.ForeColor = Color.Gainsboro;
            iconButton7.IconChar = FontAwesome.Sharp.IconChar.Users;
            iconButton7.IconColor = Color.White;
            iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton7.ImageAlign = ContentAlignment.MiddleRight;
            iconButton7.Location = new Point(0, 519);
            iconButton7.Name = "iconButton7";
            iconButton7.Padding = new Padding(90, 0, 20, 0);
            iconButton7.RightToLeft = RightToLeft.No;
            iconButton7.Size = new Size(250, 60);
            iconButton7.TabIndex = 9;
            iconButton7.Text = "نظرات کاربران";
            iconButton7.TextAlign = ContentAlignment.MiddleRight;
            iconButton7.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButton7.UseMnemonic = false;
            iconButton7.Click += iconButton7_Click;
            // 
            // iconButton6
            // 
            iconButton6.Dock = DockStyle.Top;
            iconButton6.FlatAppearance.BorderSize = 0;
            iconButton6.FlatStyle = FlatStyle.Flat;
            iconButton6.Font = new Font("Segoe UI", 9F);
            iconButton6.ForeColor = Color.Gainsboro;
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            iconButton6.IconColor = Color.White;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.ImageAlign = ContentAlignment.MiddleRight;
            iconButton6.Location = new Point(0, 459);
            iconButton6.Name = "iconButton6";
            iconButton6.Padding = new Padding(90, 0, 20, 0);
            iconButton6.RightToLeft = RightToLeft.No;
            iconButton6.Size = new Size(250, 60);
            iconButton6.TabIndex = 8;
            iconButton6.Text = "کتاب های امانت گرفته شده";
            iconButton6.TextAlign = ContentAlignment.MiddleRight;
            iconButton6.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButton6.UseMnemonic = false;
            iconButton6.Click += iconButton6_Click;
            // 
            // iconButton2
            // 
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.ForeColor = Color.Gainsboro;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.UserClock;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.ImageAlign = ContentAlignment.MiddleRight;
            iconButton2.Location = new Point(0, 399);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(90, 0, 20, 0);
            iconButton2.RightToLeft = RightToLeft.No;
            iconButton2.Size = new Size(250, 60);
            iconButton2.TabIndex = 7;
            iconButton2.Text = "تاریخچه";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButton2.UseMnemonic = false;
            iconButton2.Click += iconButton2_Click_1;
            // 
            // iconButton5
            // 
            iconButton5.Dock = DockStyle.Top;
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.ForeColor = Color.Gainsboro;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            iconButton5.IconColor = Color.White;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.ImageAlign = ContentAlignment.MiddleRight;
            iconButton5.Location = new Point(0, 339);
            iconButton5.Name = "iconButton5";
            iconButton5.Padding = new Padding(90, 0, 20, 0);
            iconButton5.RightToLeft = RightToLeft.No;
            iconButton5.Size = new Size(250, 60);
            iconButton5.TabIndex = 5;
            iconButton5.Text = "اهدا کتاب";
            iconButton5.TextAlign = ContentAlignment.MiddleRight;
            iconButton5.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButton5.UseMnemonic = false;
            iconButton5.Click += iconButton5_Click;
            // 
            // iconButton4
            // 
            iconButton4.Dock = DockStyle.Top;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.ForeColor = Color.Gainsboro;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.ImageAlign = ContentAlignment.MiddleRight;
            iconButton4.Location = new Point(0, 279);
            iconButton4.Name = "iconButton4";
            iconButton4.Padding = new Padding(90, 0, 20, 0);
            iconButton4.RightToLeft = RightToLeft.No;
            iconButton4.Size = new Size(250, 60);
            iconButton4.TabIndex = 4;
            iconButton4.Text = "تغییر حساب";
            iconButton4.TextAlign = ContentAlignment.MiddleRight;
            iconButton4.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButton4.UseMnemonic = false;
            iconButton4.Click += iconButton4_Click;
            // 
            // iconButton3
            // 
            iconButton3.Dock = DockStyle.Top;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.ForeColor = Color.Gainsboro;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.ImageAlign = ContentAlignment.MiddleRight;
            iconButton3.Location = new Point(0, 219);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(90, 0, 20, 0);
            iconButton3.RightToLeft = RightToLeft.No;
            iconButton3.Size = new Size(250, 60);
            iconButton3.TabIndex = 3;
            iconButton3.Text = "جستجو";
            iconButton3.TextAlign = ContentAlignment.MiddleRight;
            iconButton3.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButton3.UseMnemonic = false;
            iconButton3.Click += iconButton3_Click;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.Gainsboro;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Info;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.MiddleRight;
            iconButton1.Location = new Point(0, 159);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(90, 0, 20, 0);
            iconButton1.RightToLeft = RightToLeft.No;
            iconButton1.Size = new Size(250, 60);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "اطلاعات";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButton1.UseMnemonic = false;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnhome);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 159);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(162, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(213, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnhome
            // 
            btnhome.Image = Properties.Resources.a_logo_icon_for_Library_management_system_applic_prev_ui;
            btnhome.Location = new Point(6, 46);
            btnhome.Name = "btnhome";
            btnhome.Size = new Size(241, 107);
            btnhome.SizeMode = PictureBoxSizeMode.Zoom;
            btnhome.TabIndex = 1;
            btnhome.TabStop = false;
            btnhome.Click += btnhome_Click;
            // 
            // paneltitlebar
            // 
            paneltitlebar.BackColor = Color.FromArgb(31, 30, 68);
            paneltitlebar.Controls.Add(pictureBox3);
            paneltitlebar.Controls.Add(usertypelabel);
            paneltitlebar.Controls.Add(usertypeicon);
            paneltitlebar.Dock = DockStyle.Top;
            paneltitlebar.Location = new Point(0, 0);
            paneltitlebar.Name = "paneltitlebar";
            paneltitlebar.Size = new Size(980, 75);
            paneltitlebar.TabIndex = 1;
            paneltitlebar.Paint += panel1_Paint_1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(57, 49);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // usertypelabel
            // 
            usertypelabel.AutoSize = true;
            usertypelabel.Font = new Font("B Nazanin", 10F, FontStyle.Bold);
            usertypelabel.ForeColor = Color.Gainsboro;
            usertypelabel.Location = new Point(112, 3);
            usertypelabel.Name = "usertypelabel";
            usertypelabel.Size = new Size(40, 27);
            usertypelabel.TabIndex = 2;
            usertypelabel.Text = "کاربر";
            usertypelabel.Click += usertypelabel_Click;
            // 
            // usertypeicon
            // 
            usertypeicon.BackColor = Color.FromArgb(31, 30, 68);
            usertypeicon.ForeColor = Color.Gainsboro;
            usertypeicon.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            usertypeicon.IconColor = Color.Gainsboro;
            usertypeicon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            usertypeicon.IconSize = 40;
            usertypeicon.Location = new Point(66, 3);
            usertypeicon.Name = "usertypeicon";
            usertypeicon.Size = new Size(40, 40);
            usertypeicon.TabIndex = 2;
            usertypeicon.TabStop = false;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Models.Book);
            // 
            // panel1
            // 
            panel1.Location = new Point(581, 292);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 2;
            // 
            // ShowPnl
            // 
            ShowPnl.Dock = DockStyle.Fill;
            ShowPnl.Location = new Point(0, 75);
            ShowPnl.Name = "ShowPnl";
            ShowPnl.Size = new Size(980, 575);
            ShowPnl.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1230, 650);
            Controls.Add(ShowPnl);
            Controls.Add(panel1);
            Controls.Add(paneltitlebar);
            Controls.Add(userpanelmenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            userpanelmenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnhome).EndInit();
            paneltitlebar.ResumeLayout(false);
            paneltitlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)usertypeicon).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel userpanelmenu;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private PictureBox btnhome;
        private Panel paneltitlebar;
        private Label usertypelabel;
        private FontAwesome.Sharp.IconPictureBox usertypeicon;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private BindingSource bookBindingSource;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Panel panel1;
        private Panel ShowPnl;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton6;
        private OpenFileDialog openFileDialog1;
        private FontAwesome.Sharp.IconButton iconButton8;
    }
}