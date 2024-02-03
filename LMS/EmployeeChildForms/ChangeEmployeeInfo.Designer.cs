﻿namespace LMS.EmployeeChildForms
{
    partial class ChangeEmployeeInfo
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
            customTextBox2 = new CustomTextBox();
            customTextBox3 = new CustomTextBox();
            customTextBox4 = new CustomTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = SystemColors.Window;
            customTextBox1.Bordercolor = Color.FromArgb(0, 0, 192);
            customTextBox1.Borderfocuscolor = Color.HotPink;
            customTextBox1.Bordersize = 2;
            customTextBox1.Font = new Font("Segoe UI", 9.5F);
            customTextBox1.ForeColor = Color.DimGray;
            customTextBox1.Location = new Point(590, 65);
            customTextBox1.MultiLine = false;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(7);
            customTextBox1.PasswordChar = false;
            customTextBox1.Placeholdercolor = Color.DarkGray;
            customTextBox1.Placeholdertext = "نام و نام خانوادگی";
            customTextBox1.Readonly = false;
            customTextBox1.RightToLeft = RightToLeft.Yes;
            customTextBox1.Size = new Size(315, 36);
            customTextBox1.TabIndex = 0;
            customTextBox1.Texts = "";
            customTextBox1.Underlinedstyle = true;
            // 
            // customTextBox2
            // 
            customTextBox2.BackColor = SystemColors.Window;
            customTextBox2.Bordercolor = Color.FromArgb(0, 0, 192);
            customTextBox2.Borderfocuscolor = Color.HotPink;
            customTextBox2.Bordersize = 2;
            customTextBox2.Font = new Font("Segoe UI", 9.5F);
            customTextBox2.ForeColor = Color.DimGray;
            customTextBox2.Location = new Point(208, 65);
            customTextBox2.MultiLine = false;
            customTextBox2.Name = "customTextBox2";
            customTextBox2.Padding = new Padding(7);
            customTextBox2.PasswordChar = false;
            customTextBox2.Placeholdercolor = Color.DarkGray;
            customTextBox2.Placeholdertext = "ایمیل";
            customTextBox2.Readonly = false;
            customTextBox2.RightToLeft = RightToLeft.Yes;
            customTextBox2.Size = new Size(315, 36);
            customTextBox2.TabIndex = 1;
            customTextBox2.Texts = "";
            customTextBox2.Underlinedstyle = true;
            // 
            // customTextBox3
            // 
            customTextBox3.BackColor = SystemColors.Window;
            customTextBox3.Bordercolor = Color.FromArgb(0, 0, 192);
            customTextBox3.Borderfocuscolor = Color.HotPink;
            customTextBox3.Bordersize = 2;
            customTextBox3.Font = new Font("Segoe UI", 9.5F);
            customTextBox3.ForeColor = Color.DimGray;
            customTextBox3.Location = new Point(590, 154);
            customTextBox3.MultiLine = false;
            customTextBox3.Name = "customTextBox3";
            customTextBox3.Padding = new Padding(7);
            customTextBox3.PasswordChar = false;
            customTextBox3.Placeholdercolor = Color.DarkGray;
            customTextBox3.Placeholdertext = "رمز حساب";
            customTextBox3.Readonly = false;
            customTextBox3.RightToLeft = RightToLeft.Yes;
            customTextBox3.Size = new Size(315, 36);
            customTextBox3.TabIndex = 2;
            customTextBox3.Texts = "";
            customTextBox3.Underlinedstyle = true;
            // 
            // customTextBox4
            // 
            customTextBox4.BackColor = SystemColors.Window;
            customTextBox4.Bordercolor = Color.FromArgb(0, 0, 192);
            customTextBox4.Borderfocuscolor = Color.HotPink;
            customTextBox4.Bordersize = 2;
            customTextBox4.Font = new Font("Segoe UI", 9.5F);
            customTextBox4.ForeColor = Color.DimGray;
            customTextBox4.Location = new Point(208, 154);
            customTextBox4.MultiLine = false;
            customTextBox4.Name = "customTextBox4";
            customTextBox4.Padding = new Padding(7);
            customTextBox4.PasswordChar = false;
            customTextBox4.Placeholdercolor = Color.DarkGray;
            customTextBox4.Placeholdertext = "شماره تلفن";
            customTextBox4.Readonly = false;
            customTextBox4.RightToLeft = RightToLeft.Yes;
            customTextBox4.Size = new Size(315, 36);
            customTextBox4.TabIndex = 3;
            customTextBox4.Texts = "";
            customTextBox4.Underlinedstyle = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuBar;
            button1.Font = new Font("B Nazanin", 14F, FontStyle.Bold);
            button1.Location = new Point(511, 242);
            button1.Name = "button1";
            button1.Size = new Size(103, 54);
            button1.TabIndex = 16;
            button1.Text = "ویرایش";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ChangeEmployeeInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(944, 454);
            Controls.Add(button1);
            Controls.Add(customTextBox4);
            Controls.Add(customTextBox3);
            Controls.Add(customTextBox2);
            Controls.Add(customTextBox1);
            Name = "ChangeEmployeeInfo";
            Text = "ChangeEmployeeInfo";
            Load += ChangeEmployeeInfo_Load;
            ResumeLayout(false);
        }

        #endregion

        private CustomTextBox customTextBox1;
        private CustomTextBox customTextBox2;
        private CustomTextBox customTextBox3;
        private CustomTextBox customTextBox4;
        private Button button1;
    }
}