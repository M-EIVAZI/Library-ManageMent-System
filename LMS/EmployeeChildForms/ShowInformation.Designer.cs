namespace LMS.EmployeeChildForms
{
    partial class ShowInformation
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
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.Font = new Font("B Titr", 12F, FontStyle.Italic);
            label9.Location = new Point(198, 278);
            label9.Name = "label9";
            label9.Size = new Size(547, 45);
            label9.TabIndex = 42;
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.Font = new Font("B Titr", 12F, FontStyle.Italic);
            label8.Location = new Point(187, 201);
            label8.Name = "label8";
            label8.Size = new Size(547, 45);
            label8.TabIndex = 41;
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.Font = new Font("B Titr", 12F, FontStyle.Italic);
            label7.Location = new Point(198, 125);
            label7.Name = "label7";
            label7.Size = new Size(547, 45);
            label7.TabIndex = 40;
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("B Titr", 15F, FontStyle.Bold);
            label3.Location = new Point(751, 264);
            label3.Name = "label3";
            label3.Size = new Size(139, 65);
            label3.TabIndex = 38;
            label3.Text = ":شماره تلفن";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Font = new Font("B Titr", 15F, FontStyle.Bold);
            label6.Location = new Point(751, 189);
            label6.Name = "label6";
            label6.Size = new Size(139, 65);
            label6.TabIndex = 37;
            label6.Text = ":ایمیل";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("B Titr", 15F, FontStyle.Bold);
            label5.Location = new Point(751, 113);
            label5.Name = "label5";
            label5.Size = new Size(183, 65);
            label5.TabIndex = 36;
            label5.Text = ":شماره کارمند";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("B Titr", 12F, FontStyle.Italic);
            label2.Location = new Point(198, 47);
            label2.Name = "label2";
            label2.Size = new Size(547, 45);
            label2.TabIndex = 35;
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("B Titr", 15F, FontStyle.Bold);
            label1.Location = new Point(751, 33);
            label1.Name = "label1";
            label1.Size = new Size(139, 65);
            label1.TabIndex = 34;
            label1.Text = ":نام کارمند";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ShowInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(944, 454);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ShowInformation";
            Text = "ShowInformation";
            Load += ShowInformation_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label9;
        private Label label8;
        private Label label7;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label1;
    }
}