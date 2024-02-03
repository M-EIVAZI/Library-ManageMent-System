//using AxAcroPDFLib;

namespace LMS.ChildForms
{
    partial class CurrentLoanBooks
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            transactionBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            transactionidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            transactionBindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(829, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(133, 501);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuBar;
            button2.Font = new Font("B Nazanin", 14F, FontStyle.Bold);
            button2.Location = new Point(21, 75);
            button2.Name = "button2";
            button2.Size = new Size(100, 88);
            button2.TabIndex = 13;
            button2.Text = "عودت کتاب";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuBar;
            button1.Font = new Font("B Nazanin", 14F, FontStyle.Bold);
            button1.Location = new Point(21, 12);
            button1.Name = "button1";
            button1.Size = new Size(100, 46);
            button1.TabIndex = 12;
            button1.Text = "باز کردن";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // transactionBindingSource
            // 
            transactionBindingSource.DataSource = typeof(Models.Transaction);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { transactionidDataGridViewTextBoxColumn, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridView1.DataSource = transactionBindingSource1;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(829, 501);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // transactionidDataGridViewTextBoxColumn
            // 
            transactionidDataGridViewTextBoxColumn.DataPropertyName = "Transactionid";
            transactionidDataGridViewTextBoxColumn.HeaderText = "Transactionid";
            transactionidDataGridViewTextBoxColumn.MinimumWidth = 6;
            transactionidDataGridViewTextBoxColumn.Name = "transactionidDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Bookid";
            dataGridViewTextBoxColumn2.HeaderText = "Bookid";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "BorrowDate";
            dataGridViewTextBoxColumn3.HeaderText = "BorrowDate";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "ReturnDate";
            dataGridViewTextBoxColumn4.HeaderText = "ReturnDate";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // transactionBindingSource1
            // 
            transactionBindingSource1.DataSource = typeof(Models.Transaction);
            // 
            // CurrentLoanBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(962, 501);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "CurrentLoanBooks";
            Text = "CurrentLoanBooks";
            Load += CurrentLoanBooks_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridViewTextBoxColumn memberidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn borrowDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private BindingSource transactionBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn transactionidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private BindingSource transactionBindingSource1;
        private Button button1;
        private Button button2;
        //private AxAcroPDF axAcropdf1;
        //private AxAcroPDFLib.AxAcroPDF axAcropdf1;
    }
}