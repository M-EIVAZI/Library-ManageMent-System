namespace LMS
{
    partial class ForgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPassword));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            customTextBox2 = new CustomTextBox();
            button1 = new Button();
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            panel3 = new Panel();
            button2 = new Button();
            customTextBox1 = new CustomTextBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 30, 68);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(892, 72);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Titr", 14F, FontStyle.Bold);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(380, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 42);
            label1.TabIndex = 14;
            label1.Text = "فراموشی رمز عبور";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(804, 3);
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
            pictureBox1.Location = new Point(855, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // customTextBox2
            // 
            customTextBox2.BackColor = SystemColors.MenuBar;
            customTextBox2.Bordercolor = Color.FromArgb(31, 30, 68);
            customTextBox2.Borderfocuscolor = Color.SteelBlue;
            customTextBox2.Bordersize = 4;
            customTextBox2.Font = new Font("B Nazanin", 12F, FontStyle.Bold);
            customTextBox2.ForeColor = Color.Black;
            customTextBox2.Location = new Point(104, 23);
            customTextBox2.MultiLine = false;
            customTextBox2.Name = "customTextBox2";
            customTextBox2.Padding = new Padding(7);
            customTextBox2.PasswordChar = false;
            customTextBox2.Placeholdercolor = Color.DarkGray;
            customTextBox2.Placeholdertext = "شماره کاربری";
            customTextBox2.Readonly = false;
            customTextBox2.RightToLeft = RightToLeft.Yes;
            customTextBox2.Size = new Size(312, 47);
            customTextBox2.TabIndex = 10;
            customTextBox2.Texts = "";
            customTextBox2.Underlinedstyle = true;
            customTextBox2._TextChanged += customTextBox2__TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuBar;
            button1.Font = new Font("B Nazanin", 14F, FontStyle.Bold);
            button1.Location = new Point(174, 179);
            button1.Name = "button1";
            button1.Size = new Size(242, 54);
            button1.TabIndex = 12;
            button1.Text = "تایید شماره کاربری";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(customTextBox2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(450, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(442, 322);
            panel2.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "عضو کتابخانه", "کارمند کتابخانه" });
            comboBox1.Location = new Point(265, 123);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.Yes;
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 13;
            comboBox1.Text = "نوع کاربر ";
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(customTextBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 72);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 322);
            panel3.TabIndex = 14;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuBar;
            button2.Font = new Font("B Nazanin", 14F, FontStyle.Bold);
            button2.Location = new Point(258, 109);
            button2.Name = "button2";
            button2.Size = new Size(160, 54);
            button2.TabIndex = 13;
            button2.Text = "تغییر رمز حساب";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = SystemColors.MenuBar;
            customTextBox1.Bordercolor = Color.FromArgb(31, 30, 68);
            customTextBox1.Borderfocuscolor = Color.SteelBlue;
            customTextBox1.Bordersize = 4;
            customTextBox1.Font = new Font("B Nazanin", 12F, FontStyle.Bold);
            customTextBox1.ForeColor = Color.Black;
            customTextBox1.Location = new Point(106, 23);
            customTextBox1.MultiLine = false;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(7);
            customTextBox1.PasswordChar = false;
            customTextBox1.Placeholdercolor = Color.DarkGray;
            customTextBox1.Placeholdertext = "رمز جدید را وارد کنید";
            customTextBox1.Readonly = false;
            customTextBox1.RightToLeft = RightToLeft.Yes;
            customTextBox1.Size = new Size(312, 47);
            customTextBox1.TabIndex = 11;
            customTextBox1.Texts = "";
            customTextBox1.Underlinedstyle = true;
            customTextBox1._TextChanged += customTextBox1__TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(57, 49);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // ForgetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 394);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgetPassword";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private CustomTextBox customTextBox2;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Button button2;
        private CustomTextBox customTextBox1;
        private ComboBox comboBox1;
        private PictureBox pictureBox3;
    }
}