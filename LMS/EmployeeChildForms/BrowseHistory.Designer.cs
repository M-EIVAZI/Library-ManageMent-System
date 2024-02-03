namespace LMS.EmployeeChildForms
{
    partial class BrowseHistory
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
            customTextBox1 = new CustomTextBox();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            transactionidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            memberidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            borrowDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            returnDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userVeiwDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).BeginInit();
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
            customTextBox1.Location = new Point(12, 3);
            customTextBox1.MultiLine = false;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(7);
            customTextBox1.PasswordChar = false;
            customTextBox1.Placeholdercolor = Color.DarkGray;
            customTextBox1.Placeholdertext = "عبارت جستجو را وارد کنید";
            customTextBox1.Readonly = false;
            customTextBox1.RightToLeft = RightToLeft.Yes;
            customTextBox1.Size = new Size(718, 36);
            customTextBox1.TabIndex = 0;
            customTextBox1.Texts = "";
            customTextBox1.Underlinedstyle = false;
            customTextBox1._TextChanged += customTextBox1__TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "شماره امانت", "شماره عضو", "شماره کتاب" });
            comboBox1.Location = new Point(761, 11);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.Yes;
            comboBox1.Size = new Size(171, 28);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "مبنای جستجو";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(customTextBox1);
            panel1.Controls.Add(comboBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(944, 71);
            panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { transactionidDataGridViewTextBoxColumn, memberidDataGridViewTextBoxColumn, bookidDataGridViewTextBoxColumn, borrowDateDataGridViewTextBoxColumn, returnDateDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, userVeiwDataGridViewTextBoxColumn });
            dataGridView1.DataSource = transactionBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(944, 383);
            dataGridView1.TabIndex = 4;
            // 
            // transactionidDataGridViewTextBoxColumn
            // 
            transactionidDataGridViewTextBoxColumn.DataPropertyName = "Transactionid";
            transactionidDataGridViewTextBoxColumn.HeaderText = "شماره امانت";
            transactionidDataGridViewTextBoxColumn.MinimumWidth = 6;
            transactionidDataGridViewTextBoxColumn.Name = "transactionidDataGridViewTextBoxColumn";
            // 
            // memberidDataGridViewTextBoxColumn
            // 
            memberidDataGridViewTextBoxColumn.DataPropertyName = "Memberid";
            memberidDataGridViewTextBoxColumn.HeaderText = "شماره عضو";
            memberidDataGridViewTextBoxColumn.MinimumWidth = 6;
            memberidDataGridViewTextBoxColumn.Name = "memberidDataGridViewTextBoxColumn";
            // 
            // bookidDataGridViewTextBoxColumn
            // 
            bookidDataGridViewTextBoxColumn.DataPropertyName = "Bookid";
            bookidDataGridViewTextBoxColumn.HeaderText = "شماره کتاب";
            bookidDataGridViewTextBoxColumn.MinimumWidth = 6;
            bookidDataGridViewTextBoxColumn.Name = "bookidDataGridViewTextBoxColumn";
            // 
            // borrowDateDataGridViewTextBoxColumn
            // 
            borrowDateDataGridViewTextBoxColumn.DataPropertyName = "BorrowDate";
            borrowDateDataGridViewTextBoxColumn.HeaderText = "تاریخ امانت";
            borrowDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            borrowDateDataGridViewTextBoxColumn.Name = "borrowDateDataGridViewTextBoxColumn";
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            returnDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnDate";
            returnDateDataGridViewTextBoxColumn.HeaderText = "تاریخ بازگشت";
            returnDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "وضعیت";
            statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // userVeiwDataGridViewTextBoxColumn
            // 
            userVeiwDataGridViewTextBoxColumn.DataPropertyName = "UserVeiw";
            userVeiwDataGridViewTextBoxColumn.HeaderText = "نظر";
            userVeiwDataGridViewTextBoxColumn.MinimumWidth = 6;
            userVeiwDataGridViewTextBoxColumn.Name = "userVeiwDataGridViewTextBoxColumn";
            // 
            // transactionBindingSource
            // 
            transactionBindingSource.DataSource = typeof(Models.Transaction);
            // 
            // BrowseHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(944, 454);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "BrowseHistory";
            Text = "BrowseHistory";
            Load += BrowseHistory_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomTextBox customTextBox1;
        private ComboBox comboBox1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private BindingSource transactionBindingSource;
        private DataGridViewTextBoxColumn transactionidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn memberidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn borrowDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userVeiwDataGridViewTextBoxColumn;
    }
}