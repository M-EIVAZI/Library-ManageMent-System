namespace LMS.ChildForms
{
    partial class LoanBook
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
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // transactionBindingSource
            // 
            transactionBindingSource.DataSource = typeof(Models.Transaction);
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.Font = new Font("B Titr", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(168, 345);
            label10.Name = "label10";
            label10.Size = new Size(547, 45);
            label10.TabIndex = 43;
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.Font = new Font("B Titr", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(168, 268);
            label9.Name = "label9";
            label9.Size = new Size(547, 45);
            label9.TabIndex = 42;
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.Font = new Font("B Titr", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(183, 208);
            label8.Name = "label8";
            label8.Size = new Size(547, 45);
            label8.TabIndex = 41;
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.Font = new Font("B Titr", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(183, 134);
            label7.Name = "label7";
            label7.Size = new Size(547, 45);
            label7.TabIndex = 40;
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Font = new Font("B Titr", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(717, 325);
            label4.Name = "label4";
            label4.Size = new Size(139, 65);
            label4.TabIndex = 39;
            label4.Text = ":ISBN";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("B Titr", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(721, 256);
            label3.Name = "label3";
            label3.Size = new Size(139, 65);
            label3.TabIndex = 38;
            label3.Text = ":تاریخ چاپ";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Font = new Font("B Titr", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(721, 188);
            label6.Name = "label6";
            label6.Size = new Size(139, 65);
            label6.TabIndex = 37;
            label6.Text = ":نام نویسنده";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("B Titr", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(721, 122);
            label5.Name = "label5";
            label5.Size = new Size(183, 65);
            label5.TabIndex = 36;
            label5.Text = ":شماره کتاب";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("B Titr", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(183, 64);
            label2.Name = "label2";
            label2.Size = new Size(547, 45);
            label2.TabIndex = 35;
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("B Titr", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(721, 52);
            label1.Name = "label1";
            label1.Size = new Size(139, 65);
            label1.TabIndex = 34;
            label1.Text = ":نام کتاب";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuBar;
            button1.Font = new Font("B Nazanin", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(442, 405);
            button1.Name = "button1";
            button1.Size = new Size(143, 63);
            button1.TabIndex = 44;
            button1.Text = "ثبت امانت";
            button1.UseVisualStyleBackColor = false;
            // 
            // LoanBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(962, 501);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoanBook";
            Text = "LoanBook";
            Load += LoanBook_Load;
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource transactionBindingSource;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}