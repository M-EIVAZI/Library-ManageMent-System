using LMS.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace LMS.ChildForms
{
    public partial class GiveBook : Form
    {
        string filepath;
        DateOnly publishedate;
        public GiveBook()
        {
            InitializeComponent();
        }

        private bool IsFull()
        {
            int count = 0;
            if (customTextBox1.Texts == "")
                count++;
            if (customTextBox2.Texts == "")
                count++;
            if (customTextBox4.Texts == "")
                count++;
            if (customTextBox5.Texts == "")
                count++;
            if (customTextBox6.Texts == "")
                count++;
            if (count > 0)
                return false;
            else
                return true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsFull())
            {
                MessageBox.Show("همه فیلد را لطفا کامل کنید");
                return;
            }
            if (publishedate > DateOnly.FromDateTime(DateTime.Now))
            {
                MessageBox.Show("تاریخ چاپ این کتاب در آینده است");
                return;
            }

            LMSDB db = new();
            Author ?author = db.Authors.FirstOrDefault(a => a.AuthorName == customTextBox2.Texts);

            if (author != null) { 
            Book book = new()
            {
                Title = customTextBox1.Texts,
                AuthorName = customTextBox2.Texts,
                Genre = customTextBox4.Texts,
                Isbn = customTextBox5.Texts,
                Format = customTextBox6.Texts,
                FilePath = filepath,
                PublishedDate = publishedate,
                IsValid = "false",
            };
            
            db.Add<Book>(book);
            db.SaveChanges();
            MessageBox.Show("با تشکر از شما ،کتاب درصورت تایید به مجموعه اضافه خواهد شد");
                }
            else
            {
                Author a = new Author() { AuthorName = customTextBox2.Texts };
                db.Add(a);

                db.SaveChanges();
                Book book = new()
                {
                    Title = customTextBox1.Texts,
                    AuthorName = customTextBox2.Texts,
                    Genre = customTextBox4.Texts,
                    Isbn = customTextBox5.Texts,
                    Format = customTextBox6.Texts,
                    FilePath = filepath,
                    PublishedDate = publishedate,
                    IsValid = "false",
                };

                db.Add<Book>(book);
                db.SaveChanges();
                MessageBox.Show("با تشکر از شما ،کتاب درصورت تایید به مجموعه اضافه خواهد شد");
            }
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
            foreach(var sourcepathfile in Directory.GetFiles(tmp))
            {   if(sourcepathfile==saveFileDialog1.FileName)
                {
                    string path = Environment.CurrentDirectory;
                    int a = 37;
                    File.Copy(filepath, path.Substring(0, path.Length - a) + "/EBooks/"+saveFileDialog1.SafeFileName, true);
                    filepath = saveFileDialog1.SafeFileName.Substring(0,saveFileDialog1.SafeFileName.Length-4);

                    MessageBox.Show("فایل با موفقیت اپلود شد");
                }
            

            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            publishedate = DateOnly.FromDateTime(dateTimePicker1.Value);
        }
    }
}
