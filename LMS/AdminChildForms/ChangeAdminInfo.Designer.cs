namespace LMS.ChildForms
{
    partial class ChangeAdminInfo
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
            customTextBox4 = new CustomTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = SystemColors.Window;
            customTextBox1.Bordercolor = SystemColors.HotTrack;
            customTextBox1.Borderfocuscolor = Color.HotPink;
            customTextBox1.Bordersize = 2;
            customTextBox1.Font = new Font("Segoe UI", 9.5F);
            customTextBox1.ForeColor = Color.DimGray;
            customTextBox1.Location = new Point(571, 63);
            customTextBox1.MultiLine = false;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(7);
            customTextBox1.PasswordChar = false;
            customTextBox1.Placeholdercolor = Color.DarkGray;
            customTextBox1.Placeholdertext = "نام و نام خوانوادگی";
            customTextBox1.Readonly = false;
            customTextBox1.RightToLeft = RightToLeft.Yes;
            customTextBox1.Size = new Size(312, 36);
            customTextBox1.TabIndex = 0;
            customTextBox1.Texts = "";
            customTextBox1.Underlinedstyle = true;
            // 
            // customTextBox2
            // 
            customTextBox2.BackColor = SystemColors.Window;
            customTextBox2.Bordercolor = SystemColors.HotTrack;
            customTextBox2.Borderfocuscolor = Color.HotPink;
            customTextBox2.Bordersize = 2;
            customTextBox2.Font = new Font("Segoe UI", 9.5F);
            customTextBox2.ForeColor = Color.DimGray;
            customTextBox2.Location = new Point(571, 139);
            customTextBox2.MultiLine = false;
            customTextBox2.Name = "customTextBox2";
            customTextBox2.Padding = new Padding(7);
            customTextBox2.PasswordChar = false;
            customTextBox2.Placeholdercolor = Color.DarkGray;
            customTextBox2.Placeholdertext = "رمز حساب";
            customTextBox2.Readonly = false;
            customTextBox2.RightToLeft = RightToLeft.Yes;
            customTextBox2.Size = new Size(312, 36);
            customTextBox2.TabIndex = 1;
            customTextBox2.Texts = "";
            customTextBox2.Underlinedstyle = true;
            // 
            // customTextBox4
            // 
            customTextBox4.BackColor = SystemColors.Window;
            customTextBox4.Bordercolor = SystemColors.HotTrack;
            customTextBox4.Borderfocuscolor = Color.HotPink;
            customTextBox4.Bordersize = 2;
            customTextBox4.Font = new Font("Segoe UI", 9.5F);
            customTextBox4.ForeColor = Color.DimGray;
            customTextBox4.Location = new Point(172, 63);
            customTextBox4.MultiLine = false;
            customTextBox4.Name = "customTextBox4";
            customTextBox4.Padding = new Padding(7);
            customTextBox4.PasswordChar = false;
            customTextBox4.Placeholdercolor = Color.DarkGray;
            customTextBox4.Placeholdertext = "ایمیل";
            customTextBox4.Readonly = false;
            customTextBox4.RightToLeft = RightToLeft.Yes;
            customTextBox4.Size = new Size(312, 36);
            customTextBox4.TabIndex = 3;
            customTextBox4.Texts = "";
            customTextBox4.Underlinedstyle = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuBar;
            button1.Font = new Font("B Nazanin", 14F, FontStyle.Bold);
            button1.Location = new Point(467, 221);
            button1.Name = "button1";
            button1.Size = new Size(103, 54);
            button1.TabIndex = 12;
            button1.Text = "ثبت";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ChangeAdminInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(944, 454);
            Controls.Add(button1);
            Controls.Add(customTextBox4);
            Controls.Add(customTextBox2);
            Controls.Add(customTextBox1);
            Name = "ChangeAdminInfo";
            Text = "ChangeAdminInfo";
            Load += ChangeAdminInfo_Load;
            ResumeLayout(false);
        }

        #endregion

        private CustomTextBox customTextBox1;
        private CustomTextBox customTextBox2;
        private CustomTextBox customTextBox4;
        private Button button1;
    }
}