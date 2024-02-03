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
    public partial class Addbook : Form
    {
        string filepath="";
        DateOnly publishedate;
        DateOnly birthdate;
        public Addbook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (customTextBox1.Texts == "")
            {
                MessageBox.Show("نام نویسنده را وارد کنید1");
                return;

            }
            LMSDB db = new();
            Author? author = db.Authors.FirstOrDefault(a => a.AuthorName == customTextBox1.Texts);
            if (author == null)
            {
                Author newa = new()
                {
                    AuthorName = customTextBox1.Texts,
                    BirthDate = birthdate,
                };
                db.Authors.Add(newa);
                db.SaveChangesAsync();
                panel1.Show();

            }
            else
            {
                MessageBox.Show("نویسنده در پایگاه داده موجود است مشخصات کتاب را وارد کنید");
                return;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (customTextBox3.Texts == "")
            {
                MessageBox.Show("");
                return;
            }
            if (customTextBox4.Texts == "")
            {
                MessageBox.Show("");
                return;
            }
            if (customTextBox5.Texts == "")
            {
                MessageBox.Show("");
                return;
            }
            if (customTextBox6.Texts == "")
            {
                MessageBox.Show("");
                return;
            }
            if(customTextBox1.Texts=="")
            {
                MessageBox.Show("نام نویسنده را مشخص کنید");
            }
            if(filepath=="")
            {
                MessageBox.Show("فایل را باید مشخص کنید");
                return;

            }
            LMSDB db = new LMSDB();
            Book book = new Book()
            {
                Title = customTextBox3.Texts,
                Genre = customTextBox4.Texts,
                Isbn = customTextBox5.Texts,
                AuthorName = customTextBox1.Texts,
                Format = customTextBox6.Texts,
                FilePath = filepath,
                PublishedDate = publishedate,
                IsValid="true"
            };
            db.Add(book);
            db.SaveChangesAsync();
            MessageBox.Show("کتاب با موفقیت افزوده شد");

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog saveFileDialog1 = new();
            saveFileDialog1.InitialDirectory = $"{Environment.CurrentDirectory}";
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.CheckFileExists = true;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                filepath = saveFileDialog1.FileName;
            int size = saveFileDialog1.SafeFileName.Length;
            string tmp = filepath.Substring(0, filepath.Length - size);
            foreach (var sourcepathfile in Directory.GetFiles(tmp))
            {
                if (sourcepathfile == saveFileDialog1.FileName)
                {
                    string path = Environment.CurrentDirectory;
                    int a = 37;
                    File.Copy(filepath, path.Substring(0, path.Length - a) + "/EBooks/" + saveFileDialog1.SafeFileName, true);
                    filepath = saveFileDialog1.SafeFileName.Substring(0, saveFileDialog1.SafeFileName.Length - 4);

                    MessageBox.Show("فایل با موفقیت اپلود شد");
                }


            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            publishedate = DateOnly.FromDateTime(dateTimePicker1.Value);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            birthdate = DateOnly.FromDateTime(dateTimePicker1.Value);
        }
    }
}
