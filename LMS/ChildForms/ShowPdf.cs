using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PdfiumViewer;
using System.Runtime.InteropServices;
namespace LMS.ChildForms
{
    public partial class ShowPdf : Form
    {
        PdfViewer pdf;
        string filepath;
        public ShowPdf(string path)
        {
            InitializeComponent();
            pdf = new();
            filepath = path;
            this.Controls.Add(pdf);
        }
        ////[DllImport("pdfium.dll")]
        private void ShowPdf_Load(object sender, EventArgs e)
        {
            byte[] bytes = File.ReadAllBytes(filepath);
            var stream = new MemoryStream(bytes);
            PdfDocument pdfdocument = PdfDocument.Load(stream);
            pdf.Document = pdfdocument;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
