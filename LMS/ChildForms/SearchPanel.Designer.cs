namespace LMS.ChildForms
{
    partial class SearchPanel
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
            comboBox1 = new ComboBox();
            customTextBox1 = new CustomTextBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            bookidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isbnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            publishedDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookBindingSource = new BindingSource(components);
            bookBindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(customTextBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 85);
            panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("B Nazanin", 11F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "شماره کتاب", "عنوان", "ISBN", "نام نویسنده", "موضوع" });
            comboBox1.Location = new Point(790, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.Yes;
            comboBox1.Size = new Size(160, 37);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "بر اساس";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = SystemColors.Window;
            customTextBox1.Bordercolor = Color.FromArgb(31, 30, 68);
            customTextBox1.Borderfocuscolor = Color.HotPink;
            customTextBox1.Bordersize = 2;
            customTextBox1.Enabled = false;
            customTextBox1.Font = new Font("Segoe UI", 9.5F);
            customTextBox1.ForeColor = Color.DimGray;
            customTextBox1.Location = new Point(51, 13);
            customTextBox1.MultiLine = false;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(7);
            customTextBox1.PasswordChar = false;
            customTextBox1.Placeholdercolor = Color.DarkGray;
            customTextBox1.Placeholdertext = "عبارت جستجو را وارد کنید";
            customTextBox1.Readonly = false;
            customTextBox1.RightToLeft = RightToLeft.Yes;
            customTextBox1.Size = new Size(718, 36);
            customTextBox1.TabIndex = 1;
            customTextBox1.Texts = "";
            customTextBox1.Underlinedstyle = false;
            customTextBox1._TextChanged += customTextBox1__TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(962, 416);
            panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { bookidDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, authorNameDataGridViewTextBoxColumn, isbnDataGridViewTextBoxColumn, genreDataGridViewTextBoxColumn, publishedDateDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bookBindingSource1;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(962, 416);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // bookidDataGridViewTextBoxColumn
            // 
            bookidDataGridViewTextBoxColumn.DataPropertyName = "Bookid";
            bookidDataGridViewTextBoxColumn.FillWeight = 60F;
            bookidDataGridViewTextBoxColumn.HeaderText = "شماره کتاب";
            bookidDataGridViewTextBoxColumn.MinimumWidth = 6;
            bookidDataGridViewTextBoxColumn.Name = "bookidDataGridViewTextBoxColumn";
            bookidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "عنوان";
            titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorNameDataGridViewTextBoxColumn
            // 
            authorNameDataGridViewTextBoxColumn.DataPropertyName = "AuthorName";
            authorNameDataGridViewTextBoxColumn.HeaderText = "نام نویسنده";
            authorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            authorNameDataGridViewTextBoxColumn.Name = "authorNameDataGridViewTextBoxColumn";
            authorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            isbnDataGridViewTextBoxColumn.DataPropertyName = "Isbn";
            isbnDataGridViewTextBoxColumn.HeaderText = "Isbn";
            isbnDataGridViewTextBoxColumn.MinimumWidth = 6;
            isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            isbnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            genreDataGridViewTextBoxColumn.HeaderText = "موضوع";
            genreDataGridViewTextBoxColumn.MinimumWidth = 6;
            genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            genreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publishedDateDataGridViewTextBoxColumn
            // 
            publishedDateDataGridViewTextBoxColumn.DataPropertyName = "PublishedDate";
            publishedDateDataGridViewTextBoxColumn.HeaderText = "تاریخ چاپ";
            publishedDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            publishedDateDataGridViewTextBoxColumn.Name = "publishedDateDataGridViewTextBoxColumn";
            publishedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Models.Book);
            // 
            // bookBindingSource1
            // 
            bookBindingSource1.DataSource = typeof(Models.Book);
            // 
            // SearchPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 501);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SearchPanel";
            Text = "SearchPanel";
            Load += SearchPanel_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private CustomTextBox customTextBox1;
        private ComboBox comboBox1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private BindingSource bookBindingSource;
        private DataGridViewTextBoxColumn bookidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn publishedDateDataGridViewTextBoxColumn;
        private BindingSource bookBindingSource1;
    }
}