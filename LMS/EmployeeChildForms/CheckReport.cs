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
namespace LMS.EmployeeChildForms
{
    public partial class CheckReport : Form
    {
        public CheckReport()
        {
            InitializeComponent();
        }

        private void CheckReport_Load(object sender, EventArgs e)
        {
            LMSDB db = new();
            IQueryable<Reports> reports = db.Reports;
            if (reports.Any())
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                foreach(var report in reports)
                {
                    dataGridView1.Rows.Add(report.ReportId, report.Description, report.BookId, report.MemberId);
                }

            }
        }
    }
}
