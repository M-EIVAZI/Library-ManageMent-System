namespace LMS.ChildForms
{
    partial class ReportIssue
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
            transactionBindingSource = new BindingSource(components);
            label1 = new Label();
            customTextBox1 = new CustomTextBox();
            customTextBox2 = new CustomTextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // transactionBindingSource
            // 
            transactionBindingSource.DataSource = typeof(Models.Transaction);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Titr", 14F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(351, 9);
            label1.Name = "label1";
            label1.Size = new Size(350, 42);
            label1.TabIndex = 1;
            label1.Text = "مشخصات کتاب دارای نقص را وارد کنید";
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = SystemColors.MenuBar;
            customTextBox1.Bordercolor = Color.FromArgb(31, 30, 68);
            customTextBox1.Borderfocuscolor = Color.SteelBlue;
            customTextBox1.Bordersize = 4;
            customTextBox1.Font = new Font("B Nazanin", 12F, FontStyle.Bold);
            customTextBox1.ForeColor = Color.Black;
            customTextBox1.Location = new Point(638, 118);
            customTextBox1.MultiLine = false;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(7);
            customTextBox1.PasswordChar = false;
            customTextBox1.Placeholdercolor = Color.DarkGray;
            customTextBox1.Placeholdertext = "شماره کتاب";
            customTextBox1.Readonly = false;
            customTextBox1.RightToLeft = RightToLeft.Yes;
            customTextBox1.Size = new Size(312, 47);
            customTextBox1.TabIndex = 6;
            customTextBox1.Texts = "";
            customTextBox1.Underlinedstyle = true;
            // 
            // customTextBox2
            // 
            customTextBox2.BackColor = SystemColors.MenuBar;
            customTextBox2.Bordercolor = Color.FromArgb(31, 30, 68);
            customTextBox2.Borderfocuscolor = Color.SteelBlue;
            customTextBox2.Bordersize = 4;
            customTextBox2.Font = new Font("B Nazanin", 12F, FontStyle.Bold);
            customTextBox2.ForeColor = Color.Black;
            customTextBox2.Location = new Point(521, 184);
            customTextBox2.MultiLine = true;
            customTextBox2.Name = "customTextBox2";
            customTextBox2.Padding = new Padding(7);
            customTextBox2.PasswordChar = false;
            customTextBox2.Placeholdercolor = Color.DarkGray;
            customTextBox2.Placeholdertext = "توضیحات";
            customTextBox2.Readonly = false;
            customTextBox2.RightToLeft = RightToLeft.Yes;
            customTextBox2.Size = new Size(429, 204);
            customTextBox2.TabIndex = 7;
            customTextBox2.Texts = "";
            customTextBox2.Underlinedstyle = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuBar;
            button1.Font = new Font("B Nazanin", 14F, FontStyle.Bold);
            button1.Location = new Point(799, 443);
            button1.Name = "button1";
            button1.Size = new Size(151, 54);
            button1.TabIndex = 12;
            button1.Text = "ثبت گزارش";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ReportIssue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(962, 528);
            Controls.Add(button1);
            Controls.Add(customTextBox2);
            Controls.Add(customTextBox1);
            Controls.Add(label1);
            Name = "ReportIssue";
            Text = "ReportIssue";
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource transactionBindingSource;
        private Label label1;
        private CustomTextBox customTextBox1;
        private CustomTextBox customTextBox2;
        private Button button1;
    }
}