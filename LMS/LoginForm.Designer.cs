namespace LMS
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel2 = new Panel();
            label2 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            customTextBox2 = new CustomTextBox();
            customTextBox1 = new CustomTextBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Menu;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(customTextBox2);
            panel2.Controls.Add(customTextBox1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(910, 441);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("B Nazanin", 12F, FontStyle.Underline);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(626, 388);
            label2.Name = "label2";
            label2.Size = new Size(132, 29);
            label2.TabIndex = 12;
            label2.Text = "کاربر جدید هستید؟";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuBar;
            button1.Font = new Font("B Nazanin", 14F, FontStyle.Bold);
            button1.Location = new Point(764, 363);
            button1.Name = "button1";
            button1.Size = new Size(103, 54);
            button1.TabIndex = 11;
            button1.Text = "ورود";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.MenuBar;
            comboBox1.Font = new Font("B Nazanin", 10F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ادمین", "عضو کتابخانه", "کارمند کتابخانه" });
            comboBox1.Location = new Point(710, 293);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.Yes;
            comboBox1.Size = new Size(157, 35);
            comboBox1.TabIndex = 10;
            comboBox1.Text = "نوع کاربری";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // customTextBox2
            // 
            customTextBox2.BackColor = SystemColors.MenuBar;
            customTextBox2.Bordercolor = Color.FromArgb(31, 30, 68);
            customTextBox2.Borderfocuscolor = Color.SteelBlue;
            customTextBox2.Bordersize = 4;
            customTextBox2.Font = new Font("B Nazanin", 12F, FontStyle.Bold);
            customTextBox2.ForeColor = Color.Black;
            customTextBox2.Location = new Point(555, 202);
            customTextBox2.MultiLine = false;
            customTextBox2.Name = "customTextBox2";
            customTextBox2.Padding = new Padding(7);
            customTextBox2.PasswordChar = false;
            customTextBox2.Placeholdercolor = Color.DarkGray;
            customTextBox2.Placeholdertext = "شماره کاربری";
            customTextBox2.Readonly = false;
            customTextBox2.RightToLeft = RightToLeft.Yes;
            customTextBox2.Size = new Size(312, 47);
            customTextBox2.TabIndex = 9;
            customTextBox2.Texts = "";
            customTextBox2.Underlinedstyle = true;
            customTextBox2._TextChanged += customTextBox2__TextChanged_1;
            customTextBox2.KeyPress += customTextBox2_KeyPress;
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = SystemColors.MenuBar;
            customTextBox1.Bordercolor = Color.FromArgb(31, 30, 68);
            customTextBox1.Borderfocuscolor = Color.SteelBlue;
            customTextBox1.Bordersize = 4;
            customTextBox1.Font = new Font("B Nazanin", 12F, FontStyle.Bold);
            customTextBox1.ForeColor = Color.Black;
            customTextBox1.Location = new Point(555, 118);
            customTextBox1.MultiLine = false;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(7);
            customTextBox1.PasswordChar = false;
            customTextBox1.Placeholdercolor = Color.DarkGray;
            customTextBox1.Placeholdertext = "رمز حساب ";
            customTextBox1.Readonly = false;
            customTextBox1.RightToLeft = RightToLeft.Yes;
            customTextBox1.Size = new Size(312, 47);
            customTextBox1.TabIndex = 5;
            customTextBox1.Texts = "";
            customTextBox1.Underlinedstyle = true;
            customTextBox1._TextChanged += customTextBox1__TextChanged_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(31, 30, 68);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(910, 62);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(822, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(873, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Titr", 14F, FontStyle.Bold);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(410, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 42);
            label1.TabIndex = 0;
            label1.Text = "صفحه ورود";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("B Nazanin", 12F, FontStyle.Underline);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(410, 136);
            label3.Name = "label3";
            label3.Size = new Size(136, 29);
            label3.TabIndex = 13;
            label3.Text = "فراموشی رمز حساب";
            label3.Click += label3_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(910, 441);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private CustomTextBox customTextBox1;
        private CustomTextBox customTextBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ComboBox comboBox1;
        private Button button1;
        private Label label2;
        private Label label3;
    }
}