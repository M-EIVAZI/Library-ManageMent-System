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
    public partial class BrowseHistory : Form
    {
        public BrowseHistory()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            LMSDB db = new();
            IQueryable<Transaction> trans = db.Transactions;
            dataGridView1.Rows.Clear();
            if(trans != null )
            {   foreach (Transaction t in trans)
                    dataGridView1.Rows.Add(t.Transactionid, t.Transactionid, t.Bookid, t.BorrowDate, t.ReturnDate, t.Status, t.UserVeiw);

            }

        }

        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {
            LMSDB db = new();
            if (customTextBox1.Texts == "")
            {

                IQueryable<Transaction> trans = db.Transactions;
                dataGridView1.Rows.Clear();
                foreach (Transaction t in trans)
                    dataGridView1.Rows.Add(t.Transactionid, t.Transactionid, t.Bookid, t.BorrowDate, t.ReturnDate, t.Status, t.UserVeiw);
            }
            else
            {
                if (comboBox1.Text == "شماره امانت")
                {
                    IQueryable<Transaction> trans = db.Transactions.Where(e => e.Transactionid == int.Parse(customTextBox1.Texts));
                    if (!trans.Any())
                        return;
                    dataGridView1.Rows.Clear();
                    foreach (Transaction t in trans)
                        dataGridView1.Rows.Add(t.Transactionid, t.Transactionid, t.Bookid, t.BorrowDate, t.ReturnDate, t.Status, t.UserVeiw);
                }
                if (comboBox1.Text == "شماره عضو")
                {
                    IQueryable<Transaction> trans = db.Transactions.Where(e => e.Memberid == int.Parse(customTextBox1.Texts));
                    if (!trans.Any())
                        return;
                    dataGridView1.Rows.Clear();
                    foreach (Transaction t in trans)
                        dataGridView1.Rows.Add(t.Transactionid, t.Transactionid, t.Bookid, t.BorrowDate, t.ReturnDate, t.Status, t.UserVeiw);
                }
                if (comboBox1.Text == "شماره کتاب")
                {
                    IQueryable<Transaction> trans = db.Transactions.Where(e => e.Bookid == int.Parse(customTextBox1.Texts));
                    if (!trans.Any())
                        return;
                    dataGridView1.Rows.Clear();
                    foreach (Transaction t in trans)
                        dataGridView1.Rows.Add(t.Transactionid, t.Transactionid, t.Bookid, t.BorrowDate, t.ReturnDate, t.Status, t.UserVeiw);
                }
            }


        }

        

        private void BrowseHistory_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            customTextBox1.Enabled = comboBox1.SelectedIndex != -1;
            customTextBox1.Texts = "";
        }
    }
}
