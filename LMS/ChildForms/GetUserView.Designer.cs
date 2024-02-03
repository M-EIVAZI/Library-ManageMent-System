namespace LMS.ChildForms
{
    partial class GetUserView
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
            label1 = new Label();
            customTextBox1 = new CustomTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(53, 9);
            label1.Name = "label1";
            label1.Size = new Size(300, 28);
            label1.TabIndex = 0;
            label1.Text = "نظر خود را راجب این کتاب وارد کنید";
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = SystemColors.Window;
            customTextBox1.Bordercolor = Color.FromArgb(128, 64, 64);
            customTextBox1.Borderfocuscolor = Color.HotPink;
            customTextBox1.Bordersize = 2;
            customTextBox1.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox1.ForeColor = Color.DimGray;
            customTextBox1.Location = new Point(12, 60);
            customTextBox1.MultiLine = true;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(7);
            customTextBox1.PasswordChar = false;
            customTextBox1.Placeholdercolor = Color.DarkGray;
            customTextBox1.Placeholdertext = "";
            customTextBox1.Readonly = false;
            customTextBox1.RightToLeft = RightToLeft.Yes;
            customTextBox1.Size = new Size(341, 119);
            customTextBox1.TabIndex = 1;
            customTextBox1.Texts = "";
            customTextBox1.Underlinedstyle = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuBar;
            button1.Font = new Font("B Nazanin", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(131, 236);
            button1.Name = "button1";
            button1.Size = new Size(103, 54);
            button1.TabIndex = 12;
            button1.Text = "ثبت نظر";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // GetUserView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 302);
            Controls.Add(button1);
            Controls.Add(customTextBox1);
            Controls.Add(label1);
            Name = "GetUserView";
            Text = "GetUserView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CustomTextBox customTextBox1;
        private Button button1;
    }
}