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

namespace LMS.EmployeeChildForms
{
    public partial class RemoveMembers : Form
    {
        public RemoveMembers()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
        }

        private void RemoveMembers_Load(object sender, EventArgs e)
        {
            LMSDB db = new();
            Configurations config = db.Configurations.FirstOrDefault();
            if (config != null)
            {
                dataGridView1.Rows.Clear();
                IQueryable<Member> members = db.Members.Where(m => m.Fine > config.FineDefault);
                if (members.Any())
                {
                    foreach (Member member in members)
                    {
                        dataGridView1.Rows.Add(member.Memberid, member.Name, member.Email, member.Phone, member.Fine);
                    }

                }
                else
                {
                    MessageBox.Show("هیچ عضوی برای حذف وجود ندارد");
                    return;

                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LMSDB db = new();
            if (e.RowIndex >= 0)
            {
                DialogResult dr = MessageBox.Show("آیا مطمئن هستید که میخواهید این عضو را حذف کنید؟", "تاییدیه", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    if (selectedRow != null)
                    {
                        var selectedmember = db.Members.Find(selectedRow.Cells[0].Value);
                        db.Members.Remove(selectedmember);
                        db.SaveChangesAsync();
                        RemoveMembers_Load(sender, e);
                    }
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
