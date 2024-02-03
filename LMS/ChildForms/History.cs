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
using LMS.Models;
using Microsoft.EntityFrameworkCore;

namespace LMS.ChildForms
{
    public partial class History : Form
    {
        Member UserInfo;
        public History(Member userinfo)
        {
            InitializeComponent();
            UserInfo = userinfo;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            LMSDB db = new();
            //var query = from transaction in db.Transactions
            //            join member in db.Members
            //            on transaction.Memberid equals member.Memberid
            //            select transaction;
            IQueryable<Transaction> query = db.Transactions.Where(e => e.Memberid == UserInfo.Memberid);
            foreach (Transaction transaction in query)
            {
                dataGridView1.Rows.Add(transaction.Transactionid, transaction.Memberid, transaction.Bookid, transaction.BorrowDate, transaction.ReturnDate, transaction.Status, transaction.UserVeiw);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                Transaction stransaction = new()
                {
                    Transactionid = Convert.ToInt32(selectedRow.Cells[0].Value),
                    Memberid = Convert.ToInt32(selectedRow.Cells[1].Value),
                    Bookid = Convert.ToInt32(selectedRow.Cells[2].Value),
                    BorrowDate = (DateOnly)selectedRow.Cells[3].Value,
                    ReturnDate = (DateOnly)selectedRow.Cells[4].Value,
                    Status = Convert.ToString(selectedRow.Cells[5].Value)
                };
                GetUserView form = new(stransaction);
                form.ShowDialog();
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                LMSDB db = new();
                //var query = from transaction in db.Transactions
                //            join member in db.Members
                //            on transaction.Memberid equals member.Memberid
                //            select transaction;
                IQueryable<Transaction> query = db.Transactions.Where(e => e.Memberid == UserInfo.Memberid);
                foreach (var transaction in query)
                {
                    dataGridView1.Rows.Add(transaction.Transactionid, transaction.Memberid, transaction.Bookid, transaction.BorrowDate, transaction.ReturnDate, transaction.Status, transaction.UserVeiw);
                }
            }


        }

        private void History_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
