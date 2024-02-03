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
    public partial class GetUserView : Form
    {
        Transaction SelectedTransaction;
        public GetUserView(Transaction transaction)
        {
            InitializeComponent();
            SelectedTransaction = transaction;
        }

        private void button1_Click(object sender, EventArgs e)
        {   if (customTextBox1.Texts == "")
            {
                MessageBox.Show("فیلد نظر خالی است");
                return;
            }
            else
            {
                LMSDB db = new();
                SelectedTransaction.UserVeiw = customTextBox1.Texts;
                Transaction? t=db.Transactions.FirstOrDefault(t=>t.Transactionid==SelectedTransaction.Transactionid);
                if (t != null)
                {
                    t.UserVeiw = SelectedTransaction.UserVeiw;
                    db.Entry(t).State = EntityState.Modified;
                    db.SaveChangesAsync();
                    this.Close();
                }

            }

        }
    }
}
