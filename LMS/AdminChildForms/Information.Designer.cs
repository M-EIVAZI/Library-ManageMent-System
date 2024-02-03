namespace LMS.AdminChildForms
{
    partial class Information
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("B Titr", 15F, FontStyle.Bold);
            label1.Location = new Point(739, 57);
            label1.Name = "label1";
            label1.Size = new Size(139, 65);
            label1.TabIndex = 25;
            label1.Text = ":نام ادمین";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("B Titr", 15F, FontStyle.Bold);
            label3.Location = new Point(739, 143);
            label3.Name = "label3";
            label3.Size = new Size(139, 65);
            label3.TabIndex = 27;
            label3.Text = ":ایمیل ادمین";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("B Titr", 15F, FontStyle.Bold);
            label4.Location = new Point(739, 234);
            label4.Name = "label4";
            label4.Size = new Size(165, 65);
            label4.TabIndex = 28;
            label4.Text = ":شماره کاربری";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.Font = new Font("B Titr", 12F, FontStyle.Italic);
            label5.Location = new Point(186, 69);
            label5.Name = "label5";
            label5.Size = new Size(547, 45);
            label5.TabIndex = 29;
            label5.TextAlign = ContentAlignment.MiddleRight;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.Font = new Font("B Titr", 12F, FontStyle.Italic);
            label6.Location = new Point(186, 154);
            label6.Name = "label6";
            label6.Size = new Size(547, 45);
            label6.TabIndex = 30;
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.Font = new Font("B Titr", 12F, FontStyle.Italic);
            label7.Location = new Point(186, 199);
            label7.Name = "label7";
            label7.Size = new Size(547, 45);
            label7.TabIndex = 31;
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.Font = new Font("B Titr", 12F, FontStyle.Italic);
            label8.Location = new Point(175, 246);
            label8.Name = "label8";
            label8.Size = new Size(547, 45);
            label8.TabIndex = 32;
            label8.TextAlign = ContentAlignment.MiddleRight;
            label8.Click += label8_Click;
            // 
            // Information
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(944, 454);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Information";
            Text = "Information";
            Load += Information_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}