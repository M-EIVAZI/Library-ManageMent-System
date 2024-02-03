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

namespace LMS.AdminChildForms
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;

            LMSDB db = new();
             var popularBooksQuery = db.Transactions
            .GroupBy(t => t.Bookid)
            .Select(g => new
            {
                BookID = g.Key,
                BorrowCount = g.Count()
            })
            .OrderByDescending(x => x.BorrowCount)
            .Take(10)
            .Join(db.Books,
                transaction => transaction.BookID,
                book => book.Bookid,
                (transaction, book) => new
                {
                    book.Bookid,
                    book.Title,
                    transaction.BorrowCount
                });

            dataGridView1.DataSource = popularBooksQuery.ToList();

        }
    }
}
