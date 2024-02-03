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

namespace LMS.ChildForms
{
    public partial class LoanBook : Form
    {
        private readonly Book SelectedBook;
        public LoanBook(Book celldetail)
        {
            InitializeComponent();
            SelectedBook = celldetail;

        }

        private void LoanBook_Load(object sender, EventArgs e)
        {
            
            label2.Text = SelectedBook.Title;
            label7.Text = SelectedBook.Bookid.ToString();
            label8.Text = SelectedBook.AuthorName;
            label9.Text = SelectedBook.PublishedDate.ToString();
            label10.Text = SelectedBook.Isbn;

        }
    }
}
