using LMS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;


namespace LMS.ChildForms
{
    public partial class CurrentLoanBooks : Form
    {
        int SelectedBookid;
        Book book;
        Member userinfo;
        //private PdfViewer pdfViewer1;
        //[DllImport("AxAcrobat.dll")]
        //public static extern void AxAcroPDF_CreateDocument();
        public CurrentLoanBooks(Member userinfo)
        {
            InitializeComponent();
            this.userinfo = userinfo;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CurrentLoanBooks_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            //panel2.Visible = false;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            LMSDB db = new();
            int memberId = userinfo.Memberid;

            IQueryable<Transaction> trans = db.Transactions
                .Where(t => t.Memberid == memberId && EF.Functions.Like(t.Status, "False"))
                .Include(t => t.Member);  // Include related Member entity if needed

            if (!trans.Any())
                return;
            else
            {
                foreach (var t in trans)
                    dataGridView1.Rows.Add(t.Memberid, t.Bookid, t.BorrowDate, t.ReturnDate);



            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                SelectedBookid = Convert.ToInt16(selectedRow.Cells[1].Value);
            }
            LMSDB db = new();

            Book? books = db.Books.FirstOrDefault(t => t.Bookid == SelectedBookid);
            if (books != null)
                book = books;
            else
                throw new Exception("Book is not available in database");

        }

        private void button1_Click(object sender, EventArgs e)
        {   if (this.book != null)
            {
                string path = Environment.CurrentDirectory;
                int a = 37;

                string filepath = path.Substring(0,path.Length-a)+ "/EBooks/"+book.FilePath+"."+book.Format;
                ShowPdf form = new(filepath.Replace("/", "\\"));
                form.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.book == null)
            {
                MessageBox.Show("لطفا کتاب مورد نظر را انخاب کنید");
                return;
            }
            else
            {
                LMSDB db = new();
                Configurations? config = db.Configurations.FirstOrDefault();
                Transaction? trans = db.Transactions.FirstOrDefault(b => b.Bookid == this.book.Bookid);
                trans.Status = "True";
                db.Entry(trans).State = EntityState.Modified;
                db.SaveChangesAsync();
                if (trans.ReturnDate < DateOnly.FromDateTime(DateTime.Now))
                {
                    Member? member = db.Members.FirstOrDefault(m => m.Memberid == userinfo.Memberid);
                    if (member != null)
                    {
                        member.Fine += 1;
                        db.Entry(member).State = EntityState.Modified;
                        db.SaveChangesAsync();
                    }
                }
                MessageBox.Show("کتاب با موفقیت تحویل داده شد");
                CurrentLoanBooks_Load(sender, e);
            }
        }
    }
}
