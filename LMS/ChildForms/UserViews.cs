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

namespace LMS.ChildForms
{
    public partial class UserViews : Form
    {
        Member Userinfo;
        public UserViews(Member member)
        {
            InitializeComponent();
            Userinfo=member;
        }

        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {
            LMSDB db = new();
            if (customTextBox1.Texts == "")
            {
                IQueryable<Transaction> transactions = db.Transactions.Where(t => t.UserVeiw != "");
                dataGridView1.Rows.Clear();
                foreach (var trans in transactions)
                    dataGridView1.Rows.Add(trans.Memberid, trans.Bookid, trans.UserVeiw);
            }
            if (int.TryParse(customTextBox1.Texts, out int bookId))
            {
                dataGridView1.Rows.Clear();
                IQueryable<Transaction> transactions = db.Transactions.Where(t => t.Bookid == bookId);

                if (!transactions.Any())
                    return;
                else
                {
                    // Populate the DataGridView with book details
                    foreach (var trans in transactions)
                    {
                        dataGridView1.Rows.Add(trans.Memberid, trans.Bookid, trans.UserVeiw);
                    }
                }
            }

        }

        private void UserViews_Load(object sender, EventArgs e)
        {
            LMSDB db = new();
            if (customTextBox1.Texts == "")
            {
                dataGridView1.DataSource = null;
                IQueryable<Transaction> transactions = db.Transactions.Where(t=>t.UserVeiw!="");
                dataGridView1.Rows.Clear();
                foreach (var trans in transactions)
                    dataGridView1.Rows.Add(trans.Memberid, trans.Bookid, trans.UserVeiw);
            }
        }
    }
}
