namespace LMS
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            adminpanelmenu = new Panel();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnhome = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            usertypelabel = new Label();
            usertypeicon = new FontAwesome.Sharp.IconPictureBox();
            ShowPnl = new Panel();
            employeeBindingSource = new BindingSource(components);
            adminpanelmenu.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnhome).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usertypeicon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // adminpanelmenu
            // 
            adminpanelmenu.BackColor = Color.FromArgb(31, 30, 68);
            adminpanelmenu.Controls.Add(iconButton6);
            adminpanelmenu.Controls.Add(iconButton5);
            adminpanelmenu.Controls.Add(iconButton3);
            adminpanelmenu.Controls.Add(iconButton2);
            adminpanelmenu.Controls.Add(iconButton1);
            adminpanelmenu.Controls.Add(panel3);
            adminpanelmenu.Dock = DockStyle.Right;
            adminpanelmenu.Location = new Point(962, 0);
            adminpanelmenu.Name = "adminpanelmenu";
            adminpanelmenu.Size = new Size(250, 576);
            adminpanelmenu.TabIndex = 0;
            adminpanelmenu.Paint += panel1_Paint;
            // 
            // iconButton6
            // 
            iconButton6.Dock = DockStyle.Top;
            iconButton6.FlatAppearance.BorderSize = 0;
            iconButton6.FlatStyle = FlatStyle.Flat;
            iconButton6.ForeColor = Color.Gainsboro;
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            iconButton6.IconColor = Color.White;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.ImageAlign = ContentAlignment.MiddleRight;
            iconButton6.Location = new Point(0, 399);
            iconButton6.Name = "iconButton6";
            iconButton6.Padding = new Padding(90, 0, 20, 0);
            iconButton6.RightToLeft = RightToLeft.No;
            iconButton6.Size = new Size(250, 60);
            iconButton6.TabIndex = 9;
            iconButton6.Text = "گزارش ها";
            iconButton6.TextAlign = ContentAlignment.MiddleRight;
            iconButton6.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButton6.UseMnemonic = false;
            iconButton6.Click += iconButton6_Click;
            // 
            // iconButton5
            // 
            iconButton5.Dock = DockStyle.Top;
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.ForeColor = Color.Gainsboro;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            iconButton5.IconColor = Color.White;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.ImageAlign = ContentAlignment.MiddleRight;
            iconButton5.Location = new Point(0, 339);
            iconButton5.Name = "iconButton5";
            iconButton5.Padding = new Padding(90, 0, 20, 0);
            iconButton5.RightToLeft = RightToLeft.No;
            iconButton5.Size = new Size(250, 60);
            iconButton5.TabIndex = 8;
            iconButton5.Text = "تغییر حساب";
            iconButton5.TextAlign = ContentAlignment.MiddleRight;
            iconButton5.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButton5.UseMnemonic = false;
            iconButton5.Click += iconButton5_Click;
            // 
            // iconButton3
            // 
            iconButton3.Dock = DockStyle.Top;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            iconButton3.ForeColor = Color.Gainsboro;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.ImageAlign = ContentAlignment.MiddleRight;
            iconButton3.Location = new Point(0, 279);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(90, 0, 20, 0);
            iconButton3.RightToLeft = RightToLeft.No;
            iconButton3.Size = new Size(250, 60);
            iconButton3.TabIndex = 7;
            iconButton3.Text = "تایید هویت";
            iconButton3.TextAlign = ContentAlignment.MiddleRight;
            iconButton3.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButton3.UseMnemonic = false;
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton4_Click;
            // 
            // iconButton2
            // 
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            iconButton2.ForeColor = Color.Gainsboro;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.D;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.ImageAlign = ContentAlignment.MiddleRight;
            iconButton2.Location = new Point(0, 219);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(90, 0, 20, 0);
            iconButton2.RightToLeft = RightToLeft.No;
            iconButton2.Size = new Size(250, 60);
            iconButton2.TabIndex = 4;
            iconButton2.Text = "پیش فرض ها";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButton2.UseMnemonic = false;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            iconButton1.ForeColor = Color.Gainsboro;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.MiddleRight;
            iconButton1.Location = new Point(0, 159);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(90, 0, 20, 0);
            iconButton1.RightToLeft = RightToLeft.No;
            iconButton1.Size = new Size(250, 60);
            iconButton1.TabIndex = 3;
            iconButton1.Text = "اطلاعات";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButton1.UseMnemonic = false;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(31, 30, 68);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(btnhome);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 159);
            panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(162, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
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
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnhome
            // 
            btnhome.Image = Properties.Resources.a_logo_icon_for_Library_management_system_applic_prev_ui;
            btnhome.Location = new Point(3, 49);
            btnhome.Name = "btnhome";
            btnhome.Size = new Size(244, 107);
            btnhome.SizeMode = PictureBoxSizeMode.Zoom;
            btnhome.TabIndex = 2;
            btnhome.TabStop = false;
            btnhome.Click += btnhome_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 30, 68);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(usertypelabel);
            panel2.Controls.Add(usertypeicon);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(962, 75);
            panel2.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(57, 49);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // usertypelabel
            // 
            usertypelabel.AutoSize = true;
            usertypelabel.Font = new Font("B Nazanin", 10F, FontStyle.Bold);
            usertypelabel.ForeColor = Color.Gainsboro;
            usertypelabel.Location = new Point(112, 9);
            usertypelabel.Name = "usertypelabel";
            usertypelabel.Size = new Size(45, 27);
            usertypelabel.TabIndex = 4;
            usertypelabel.Text = "ادمین";
            // 
            // usertypeicon
            // 
            usertypeicon.BackColor = Color.FromArgb(31, 30, 68);
            usertypeicon.ForeColor = Color.Gainsboro;
            usertypeicon.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            usertypeicon.IconColor = Color.Gainsboro;
            usertypeicon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            usertypeicon.IconSize = 40;
            usertypeicon.Location = new Point(66, 3);
            usertypeicon.Name = "usertypeicon";
            usertypeicon.Size = new Size(40, 40);
            usertypeicon.TabIndex = 3;
            usertypeicon.TabStop = false;
            // 
            // ShowPnl
            // 
            ShowPnl.BackColor = SystemColors.ActiveCaption;
            ShowPnl.Dock = DockStyle.Fill;
            ShowPnl.Location = new Point(0, 75);
            ShowPnl.Name = "ShowPnl";
            ShowPnl.Size = new Size(962, 501);
            ShowPnl.TabIndex = 2;
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Models.Employee);
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 576);
            Controls.Add(ShowPnl);
            Controls.Add(panel2);
            Controls.Add(adminpanelmenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            adminpanelmenu.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnhome).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)usertypeicon).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel adminpanelmenu;
        private Panel panel2;
        private Panel panel3;
        private PictureBox btnhome;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconPictureBox usertypeicon;
        private Label usertypelabel;
        private FontAwesome.Sharp.IconButton iconButton5;
        private PictureBox pictureBox3;
        private Panel ShowPnl;
        private FontAwesome.Sharp.IconButton iconButton6;
        private BindingSource employeeBindingSource;
    }
}