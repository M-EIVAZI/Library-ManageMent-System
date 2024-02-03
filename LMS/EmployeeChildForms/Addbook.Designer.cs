namespace LMS.EmployeeChildForms
{
    partial class Addbook
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
            customTextBox1 = new CustomTextBox();
            button1 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            customTextBox6 = new CustomTextBox();
            customTextBox5 = new CustomTextBox();
            customTextBox4 = new CustomTextBox();
            customTextBox3 = new CustomTextBox();
            button2 = new Button();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = SystemColors.Window;
            customTextBox1.Bordercolor = Color.FromArgb(128, 64, 64);
            customTextBox1.Borderfocuscolor = Color.HotPink;
            customTextBox1.Bordersize = 2;
            customTextBox1.Font = new Font("Segoe UI", 9.5F);
            customTextBox1.ForeColor = Color.DimGray;
            customTextBox1.Location = new Point(476, 33);
            customTextBox1.MultiLine = false;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(7);
            customTextBox1.PasswordChar = false;
            customTextBox1.Placeholdercolor = Color.DarkGray;
            customTextBox1.Placeholdertext = "نام نویسنده کتاب را وارد کنید";
            customTextBox1.Readonly = false;
            customTextBox1.RightToLeft = RightToLeft.Yes;
            customTextBox1.Size = new Size(312, 36);
            customTextBox1.TabIndex = 0;
            customTextBox1.Texts = "";
            customTextBox1.Underlinedstyle = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuBar;
            button1.Font = new Font("B Nazanin", 14F, FontStyle.Bold);
            button1.Location = new Point(654, 153);
            button1.Name = "button1";
            button1.Size = new Size(134, 67);
            button1.TabIndex = 12;
            button1.Text = "ثبت نویسنده";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(customTextBox6);
            panel1.Controls.Add(customTextBox5);
            panel1.Controls.Add(customTextBox4);
            panel1.Controls.Add(customTextBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(439, 450);
            panel1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 271);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 18;
            label2.Text = "تاریخ چاپ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(189, 271);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 17;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = SystemColors.ActiveCaption;
            iconButton2.BackgroundImageLayout = ImageLayout.None;
            iconButton2.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 9F);
            iconButton2.ForeColor = Color.Black;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowRightToFile;
            iconButton2.IconColor = Color.Gray;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.ImageAlign = ContentAlignment.MiddleRight;
            iconButton2.Location = new Point(296, 315);
            iconButton2.Name = "iconButton2";
            iconButton2.RightToLeft = RightToLeft.No;
            iconButton2.Size = new Size(128, 46);
            iconButton2.TabIndex = 16;
            iconButton2.Text = "آپلود فایل";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // customTextBox6
            // 
            customTextBox6.BackColor = SystemColors.Window;
            customTextBox6.Bordercolor = Color.FromArgb(128, 64, 64);
            customTextBox6.Borderfocuscolor = Color.HotPink;
            customTextBox6.Bordersize = 2;
            customTextBox6.Font = new Font("Segoe UI", 9.5F);
            customTextBox6.ForeColor = Color.DimGray;
            customTextBox6.Location = new Point(127, 208);
            customTextBox6.MultiLine = false;
            customTextBox6.Name = "customTextBox6";
            customTextBox6.Padding = new Padding(7);
            customTextBox6.PasswordChar = false;
            customTextBox6.Placeholdercolor = Color.DarkGray;
            customTextBox6.Placeholdertext = "فرمت کتاب را وارد کنید";
            customTextBox6.Readonly = false;
            customTextBox6.RightToLeft = RightToLeft.Yes;
            customTextBox6.Size = new Size(312, 36);
            customTextBox6.TabIndex = 4;
            customTextBox6.Texts = "";
            customTextBox6.Underlinedstyle = true;
            // 
            // customTextBox5
            // 
            customTextBox5.BackColor = SystemColors.Window;
            customTextBox5.Bordercolor = Color.FromArgb(128, 64, 64);
            customTextBox5.Borderfocuscolor = Color.HotPink;
            customTextBox5.Bordersize = 2;
            customTextBox5.Font = new Font("Segoe UI", 9.5F);
            customTextBox5.ForeColor = Color.DimGray;
            customTextBox5.Location = new Point(124, 142);
            customTextBox5.MultiLine = false;
            customTextBox5.Name = "customTextBox5";
            customTextBox5.Padding = new Padding(7);
            customTextBox5.PasswordChar = false;
            customTextBox5.Placeholdercolor = Color.DarkGray;
            customTextBox5.Placeholdertext = "isbn کتاب را وارد کنید";
            customTextBox5.Readonly = false;
            customTextBox5.RightToLeft = RightToLeft.Yes;
            customTextBox5.Size = new Size(312, 36);
            customTextBox5.TabIndex = 3;
            customTextBox5.Texts = "";
            customTextBox5.Underlinedstyle = true;
            // 
            // customTextBox4
            // 
            customTextBox4.BackColor = SystemColors.Window;
            customTextBox4.Bordercolor = Color.FromArgb(128, 64, 64);
            customTextBox4.Borderfocuscolor = Color.HotPink;
            customTextBox4.Bordersize = 2;
            customTextBox4.Font = new Font("Segoe UI", 9.5F);
            customTextBox4.ForeColor = Color.DimGray;
            customTextBox4.Location = new Point(124, 89);
            customTextBox4.MultiLine = false;
            customTextBox4.Name = "customTextBox4";
            customTextBox4.Padding = new Padding(7);
            customTextBox4.PasswordChar = false;
            customTextBox4.Placeholdercolor = Color.DarkGray;
            customTextBox4.Placeholdertext = " موضوع کتاب را وارد کنید";
            customTextBox4.Readonly = false;
            customTextBox4.RightToLeft = RightToLeft.Yes;
            customTextBox4.Size = new Size(312, 36);
            customTextBox4.TabIndex = 2;
            customTextBox4.Texts = "";
            customTextBox4.Underlinedstyle = true;
            // 
            // customTextBox3
            // 
            customTextBox3.BackColor = SystemColors.Window;
            customTextBox3.Bordercolor = Color.FromArgb(128, 64, 64);
            customTextBox3.Borderfocuscolor = Color.HotPink;
            customTextBox3.Bordersize = 2;
            customTextBox3.Font = new Font("Segoe UI", 9.5F);
            customTextBox3.ForeColor = Color.DimGray;
            customTextBox3.Location = new Point(124, 33);
            customTextBox3.MultiLine = false;
            customTextBox3.Name = "customTextBox3";
            customTextBox3.Padding = new Padding(7);
            customTextBox3.PasswordChar = false;
            customTextBox3.Placeholdercolor = Color.DarkGray;
            customTextBox3.Placeholdertext = "عنوان کتاب را وارد کنید";
            customTextBox3.Readonly = false;
            customTextBox3.RightToLeft = RightToLeft.Yes;
            customTextBox3.Size = new Size(312, 36);
            customTextBox3.TabIndex = 1;
            customTextBox3.Texts = "";
            customTextBox3.Underlinedstyle = true;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuBar;
            button2.Font = new Font("B Nazanin", 14F, FontStyle.Bold);
            button2.Location = new Point(514, 153);
            button2.Name = "button2";
            button2.Size = new Size(134, 67);
            button2.TabIndex = 14;
            button2.Text = "ثبت کتاب";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(538, 98);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 18;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(445, 75);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 19;
            label1.Text = "تاریخ تولد نویسنده";
            label1.Click += label1_Click;
            // 
            // Addbook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(customTextBox1);
            Name = "Addbook";
            Text = "Addbook";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomTextBox customTextBox1;
        private Button button1;
        private Panel panel1;
        private CustomTextBox customTextBox6;
        private CustomTextBox customTextBox5;
        private CustomTextBox customTextBox4;
        private CustomTextBox customTextBox3;
        private Button button2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private Label label1;
    }
}