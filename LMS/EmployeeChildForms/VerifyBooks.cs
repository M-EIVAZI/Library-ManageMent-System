using LMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.EmployeeChildForms
{
    public partial class VerifyBooks : Form
    {
        public VerifyBooks()
        {
            InitializeComponent();
        }

        private void CheckReports_Load(object sender, EventArgs e)
        {
            LMSDB db = new();
            dataGridView1.DataSource = null;
            IQueryable<Book> books = db.Books.Where(b => b.IsValid == "false");
            if (books.Any())
            {
                dataGridView1.Rows.Clear();
                foreach (Book book in books)
                {
                    dataGridView1.Rows.Add(book.Bookid, book.Title, book.AuthorName, book.Isbn, book.Genre, book.PublishedDate);

                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LMSDB db = new();
            if (e.RowIndex >= 0)
            {
                DialogResult dr = MessageBox.Show("آیا مطمئن هستید که میخواهید این کتاب را اضافه کنید؟", "تاییدیه", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    if (selectedRow != null)
                    {
                        Book? book = db.Books.FirstOrDefault(b => b.Bookid == Convert.ToInt16(selectedRow.Cells[0].Value));
                        if (book != null)
                        {
                            book.IsValid = "true";
                            db.SaveChangesAsync();
                        }
                        else
                        {
                            MessageBox.Show("کتاب در پایگاه داده نیست");
                            return;

                        }

                    }

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
