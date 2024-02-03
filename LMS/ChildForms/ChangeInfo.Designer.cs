namespace LMS.ChildForms
{
    partial class ChangeInfo
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
            label1 = new Label();
            customTextBox2 = new CustomTextBox();
            customTextBox3 = new CustomTextBox();
            customTextBox4 = new CustomTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = SystemColors.ActiveCaption;
            customTextBox1.Bordercolor = Color.FromArgb(128, 64, 64);
            customTextBox1.Borderfocuscolor = Color.HotPink;
            customTextBox1.Bordersize = 2;
            customTextBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            customTextBox1.ForeColor = SystemColors.Window;
            customTextBox1.Location = new Point(638, 65);
            customTextBox1.MultiLine = false;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(7);
            customTextBox1.PasswordChar = false;
            customTextBox1.Placeholdercolor = Color.Gainsboro;
            customTextBox1.Placeholdertext = "نام و نام خوانوادگی ";
            customTextBox1.Readonly = false;
            customTextBox1.RightToLeft = RightToLeft.Yes;
            customTextBox1.Size = new Size(312, 38);
            customTextBox1.TabIndex = 0;
            customTextBox1.Texts = "";
            customTextBox1.Underlinedstyle = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(517, 9);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(433, 30);
            label1.TabIndex = 1;
            label1.Text = "اطالاعاتی که میخواهید ویرایش کنید را وارد کنید";
            // 
            // customTextBox2
            // 
            customTextBox2.BackColor = SystemColors.ActiveCaption;
            customTextBox2.Bordercolor = Color.FromArgb(128, 64, 64);
            customTextBox2.Borderfocuscolor = Color.HotPink;
            customTextBox2.Bordersize = 2;
            customTextBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            customTextBox2.ForeColor = SystemColors.Window;
            customTextBox2.Location = new Point(638, 137);
            customTextBox2.MultiLine = false;
            customTextBox2.Name = "customTextBox2";
            customTextBox2.Padding = new Padding(7);
            customTextBox2.PasswordChar = false;
            customTextBox2.Placeholdercolor = Color.Gainsboro;
            customTextBox2.Placeholdertext = "رمز حساب";
            customTextBox2.Readonly = false;
            customTextBox2.RightToLeft = RightToLeft.Yes;
            customTextBox2.Size = new Size(312, 38);
            customTextBox2.TabIndex = 2;
            customTextBox2.Texts = "";
            customTextBox2.Underlinedstyle = true;
            // 
            // customTextBox3
            // 
            customTextBox3.BackColor = SystemColors.ActiveCaption;
            customTextBox3.Bordercolor = Color.FromArgb(128, 64, 64);
            customTextBox3.Borderfocuscolor = Color.HotPink;
            customTextBox3.Bordersize = 2;
            customTextBox3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            customTextBox3.ForeColor = SystemColors.Window;
            customTextBox3.Location = new Point(232, 146);
            customTextBox3.MultiLine = false;
            customTextBox3.Name = "customTextBox3";
            customTextBox3.Padding = new Padding(7);
            customTextBox3.PasswordChar = false;
            customTextBox3.Placeholdercolor = Color.Gainsboro;
            customTextBox3.Placeholdertext = "شماره تلفن";
            customTextBox3.Readonly = false;
            customTextBox3.RightToLeft = RightToLeft.Yes;
            customTextBox3.Size = new Size(312, 38);
            customTextBox3.TabIndex = 3;
            customTextBox3.Texts = "";
            customTextBox3.Underlinedstyle = true;
            // 
            // customTextBox4
            // 
            customTextBox4.BackColor = SystemColors.ActiveCaption;
            customTextBox4.Bordercolor = Color.FromArgb(128, 64, 64);
            customTextBox4.Borderfocuscolor = Color.HotPink;
            customTextBox4.Bordersize = 2;
            customTextBox4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            customTextBox4.ForeColor = SystemColors.Window;
            customTextBox4.Location = new Point(232, 65);
            customTextBox4.MultiLine = false;
            customTextBox4.Name = "customTextBox4";
            customTextBox4.Padding = new Padding(7);
            customTextBox4.PasswordChar = false;
            customTextBox4.Placeholdercolor = Color.Gainsboro;
            customTextBox4.Placeholdertext = "ایمیل";
            customTextBox4.Readonly = false;
            customTextBox4.RightToLeft = RightToLeft.Yes;
            customTextBox4.Size = new Size(312, 38);
            customTextBox4.TabIndex = 4;
            customTextBox4.Texts = "";
            customTextBox4.Underlinedstyle = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuBar;
            button1.Font = new Font("B Nazanin", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(490, 338);
            button1.Name = "button1";
            button1.Size = new Size(103, 54);
            button1.TabIndex = 12;
            button1.Text = "ویرایش";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ChangeInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(962, 501);
            Controls.Add(button1);
            Controls.Add(customTextBox4);
            Controls.Add(customTextBox3);
            Controls.Add(customTextBox2);
            Controls.Add(label1);
            Controls.Add(customTextBox1);
            Name = "ChangeInfo";
            Text = "ChangeInfo";
            Load += ChangeInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomTextBox customTextBox1;
        private Label label1;
        private CustomTextBox customTextBox2;
        private CustomTextBox customTextBox3;
        private CustomTextBox customTextBox4;
        private Button button1;
    }
}