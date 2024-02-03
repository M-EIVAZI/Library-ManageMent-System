namespace LMS.ChildForms
{
    partial class UserViews
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
            dataGridView1 = new DataGridView();
            memberidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userVeiwDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionBindingSource = new BindingSource(components);
            panel1 = new Panel();
            customTextBox1 = new CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { memberidDataGridViewTextBoxColumn, bookidDataGridViewTextBoxColumn, userVeiwDataGridViewTextBoxColumn });
            dataGridView1.DataSource = transactionBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 385);
            dataGridView1.TabIndex = 0;
            // 
            // memberidDataGridViewTextBoxColumn
            // 
            memberidDataGridViewTextBoxColumn.DataPropertyName = "Memberid";
            memberidDataGridViewTextBoxColumn.FillWeight = 20F;
            memberidDataGridViewTextBoxColumn.HeaderText = "Memberid";
            memberidDataGridViewTextBoxColumn.MaxInputLength = 100;
            memberidDataGridViewTextBoxColumn.MinimumWidth = 6;
            memberidDataGridViewTextBoxColumn.Name = "memberidDataGridViewTextBoxColumn";
            memberidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookidDataGridViewTextBoxColumn
            // 
            bookidDataGridViewTextBoxColumn.DataPropertyName = "Bookid";
            bookidDataGridViewTextBoxColumn.FillWeight = 20F;
            bookidDataGridViewTextBoxColumn.HeaderText = "Bookid";
            bookidDataGridViewTextBoxColumn.MinimumWidth = 6;
            bookidDataGridViewTextBoxColumn.Name = "bookidDataGridViewTextBoxColumn";
            bookidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userVeiwDataGridViewTextBoxColumn
            // 
            userVeiwDataGridViewTextBoxColumn.DataPropertyName = "UserVeiw";
            userVeiwDataGridViewTextBoxColumn.FillWeight = 69.7860947F;
            userVeiwDataGridViewTextBoxColumn.HeaderText = "UserVeiw";
            userVeiwDataGridViewTextBoxColumn.MinimumWidth = 6;
            userVeiwDataGridViewTextBoxColumn.Name = "userVeiwDataGridViewTextBoxColumn";
            userVeiwDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionBindingSource
            // 
            transactionBindingSource.DataSource = typeof(Models.Transaction);
            // 
            // panel1
            // 
            panel1.Controls.Add(customTextBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 65);
            panel1.TabIndex = 1;
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = SystemColors.Window;
            customTextBox1.Bordercolor = Color.FromArgb(31, 30, 68);
            customTextBox1.Borderfocuscolor = Color.HotPink;
            customTextBox1.Bordersize = 2;
            customTextBox1.Font = new Font("Segoe UI", 9.5F);
            customTextBox1.ForeColor = Color.DimGray;
            customTextBox1.Location = new Point(0, 3);
            customTextBox1.MultiLine = false;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(7);
            customTextBox1.PasswordChar = false;
            customTextBox1.Placeholdercolor = Color.DarkGray;
            customTextBox1.Placeholdertext = "شماره کتاب را وارد کنید";
            customTextBox1.Readonly = false;
            customTextBox1.RightToLeft = RightToLeft.Yes;
            customTextBox1.Size = new Size(718, 36);
            customTextBox1.TabIndex = 2;
            customTextBox1.Texts = "";
            customTextBox1.Underlinedstyle = false;
            customTextBox1._TextChanged += customTextBox1__TextChanged;
            // 
            // UserViews
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "UserViews";
            Text = "UserViews";
            Load += UserViews_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource transactionBindingSource;
        private Panel panel1;
        private CustomTextBox customTextBox1;
        private DataGridViewTextBoxColumn memberidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userVeiwDataGridViewTextBoxColumn;
    }
}