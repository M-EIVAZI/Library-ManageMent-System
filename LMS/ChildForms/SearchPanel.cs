using LMS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS;

namespace LMS.ChildForms
{
    public partial class SearchPanel : Form
    {   Member Userinfo;
        public SearchPanel(Member userinfo)
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            Userinfo = userinfo;
            LMSDB db = new();
            IQueryable<Book> books = db.Books.Where(b=>b.IsValid=="true");

            dataGridView1.Rows.Clear();

            foreach (var book in books)
            {
                dataGridView1.Rows.Add(book.Bookid, book.Title, book.AuthorName, book.Isbn, book.Genre, book.PublishedDate);
            }
        }

        private void SearchPanel_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {
            LMSDB db = new();
            if (customTextBox1.Texts == "")
            {

                IQueryable<Book> books = db.Books;

                dataGridView1.Rows.Clear();

                foreach (var book in books)
                {
                    dataGridView1.Rows.Add(book.Bookid, book.Title, book.AuthorName, book.Isbn, book.Genre, book.PublishedDate);
                }

            }

            if (comboBox1.Text == "عنوان")
            {
                dataGridView1.Rows.Clear();
                IQueryable<Book> books = db.Books.Where(b => EF.Functions.Like(b.Title.ToLower(), $"%{customTextBox1.Texts.ToLower()}%"));
                if (!books.Any())
                    return;
                else
                {
                    foreach (var book in books)
                        dataGridView1.Rows.Add(book.Bookid, book.Title, book.AuthorName, book.Isbn, book.Genre, book.PublishedDate);

                }

            }
            if (comboBox1.Text == "شماره کتاب")
            {
                if (int.TryParse(customTextBox1.Texts, out int bookId))
                {
                    dataGridView1.Rows.Clear();

                    // Use the parsed bookId in your LINQ query
                    IQueryable<Book> books = db.Books.Where(b => b.Bookid == bookId);
                    if (!books.Any())
                        return;
                    else
                    {
                        // Populate the DataGridView with book details
                        foreach (var book in books)
                        {
                            dataGridView1.Rows.Add(book.Bookid, book.Title, book.AuthorName, book.Isbn, book.Genre, book.PublishedDate);
                        }
                    }
                }
                else
                {

                    return;
                }

            }
            if (comboBox1.Text == "نام نویسنده")
            {
                dataGridView1.Rows.Clear();
                IQueryable<Book> books = db.Books.Where(b => EF.Functions.Like(b.AuthorName.ToLower(), $"%{customTextBox1.Texts.ToLower()}%"));
                if (!books.Any())
                    return;
                else
                {
                    foreach (var book in books)
                        dataGridView1.Rows.Add(book.Bookid, book.Title, book.AuthorName, book.Isbn, book.Genre, book.PublishedDate);

                }

            }
            if (comboBox1.Text == "موضوع")
            {
                dataGridView1.Rows.Clear();
                IQueryable<Book> books = db.Books.Where(b => EF.Functions.Like(b.Genre.ToLower(), $"%{customTextBox1.Texts.ToLower()}%"));
                if (!books.Any())
                    return;
                else
                {
                    foreach (var book in books)
                        dataGridView1.Rows.Add(book.Bookid, book.Title, book.AuthorName, book.Isbn, book.Genre, book.PublishedDate);

                }

            }
            if (comboBox1.Text == "ISBN")
            {
                dataGridView1.Rows.Clear();
                IQueryable<Book> books = db.Books.Where(b => EF.Functions.Like(b.Isbn, $"{customTextBox1.Texts}%"));
                if (!books.Any())
                    return;
                else
                {
                    foreach (var book in books)
                        dataGridView1.Rows.Add(book.Bookid, book.Title, book.AuthorName, book.Isbn, book.Genre, book.PublishedDate);

                }

            }
            //if (comboBox1.Text == "تاریخ چاپ")
            //{
            //    var dateComponents = customTextBox1.Texts.Split('/');
            //    if (dateComponents.Length == 3 && int.TryParse(dateComponents[0], out int day)
            //        && int.TryParse(dateComponents[1], out int month) && int.TryParse(dateComponents[2], out int year))
            //    {
            //        try
            //        {
            //            if (dateComponents[2].Length < 4)
            //                return;
            //            // Attempt to create a DateOnly object
            //            DateOnly parsedDate = new(year, month, day);

            //            dataGridView1.Rows.Clear();

            //            IQueryable<Book> books = db.Books.Where(b => b.PublishedDate == parsedDate);

            //            if (!books.Any())
            //                return;
            //            else
            //            {
            //                foreach (var book in books)
            //                    dataGridView1.Rows.Add(book.Bookid, book.Title, book.AuthorName, book.Isbn, book.Genre, book.PublishedDate);
            //            }
            //        }
            //        catch (FormatException ex)
            //        {
            //            // Handle the format exception (e.g., display an error message)
            //            MessageBox.Show("Invalid date format provided.");
            //        }
            //    }

            //}

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            customTextBox1.Enabled = comboBox1.SelectedIndex != -1;
            customTextBox1.Texts = "";
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var db = new LMSDB();
            Configurations ?config = db.Configurations.FirstOrDefault();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                Book selectedbook = new()
                {
                    Bookid = Convert.ToInt32(selectedRow.Cells[0].Value),
                    Title = Convert.ToString(selectedRow.Cells[1].Value),
                    AuthorName = Convert.ToString(selectedRow.Cells[2].Value),
                    Isbn = Convert.ToString(selectedRow.Cells[3].Value),
                    Genre = Convert.ToString(selectedRow.Cells[4].Value),
                    PublishedDate = (DateOnly)selectedRow.Cells[5].Value
                };
                DateOnly currentdate = DateOnly.FromDateTime(DateTime.Now);
                DialogResult dr = MessageBox.Show( "آیا مطمئن هستید که میخواهید این کتاب را امانت بگیرید؟", "تاییدیه", MessageBoxButtons.YesNo);
                int memberId = Userinfo.Memberid;

                int numberOfBorrows = db.Transactions
                    .Where(t => t.Memberid == memberId && EF.Functions.Like(t.Status, "False"))
                    .Count();
                if(numberOfBorrows>=config.MaxLoanNumber)
                {
                    MessageBox.Show("تعداد امانت های شما به حداکثر رسیده است");
                    return;
                }

                if (dr == DialogResult.Yes)
                {   Transaction newtr = new()
                        {
                            Bookid = selectedbook.Bookid,
                            Memberid = Userinfo.Memberid,
                            BorrowDate = currentdate,
                            ReturnDate = currentdate.AddDays(config.MaxLoanTime*7),
                            Status = "False",
                            UserVeiw=""
                        };
                    db.Add<Transaction>(newtr);
                    db.SaveChanges();
                    MessageBox.Show("کتاب با موفقیت به پنل شما اضافه شد");
                }
                else
                {

                }


            }

        }

        
    }
}
