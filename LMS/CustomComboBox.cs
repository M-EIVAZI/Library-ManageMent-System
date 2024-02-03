using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace LMS
{
    [DefaultEvent("OnSelectedIndexChanged")]
    public class CustomComboBox:UserControl
    {   //Attributes
        private Color backcolor = Color.WhiteSmoke;
        private Color iconcolor = Color.MediumBlue;
        private Color listbackcolor = Color.FromArgb(230, 228, 245);
        private Color listtextcolor = Color.DimGray;
        private Color bordercolor = Color.MediumBlue;
        private int bordersize=1;
        //items
        private ComboBox cmblist;
        private Label lbltext;
        private Button btnicon;

        public Color Backcolor
        {
            get => backcolor;
            set
            {
                backcolor = value;
                lbltext.BackColor= backcolor;
                btnicon.BackColor= backcolor;
            }
        }
        public Color Iconcolor { get => iconcolor; set => iconcolor = value; }
        public Color Listbackcolor { get => listbackcolor; set => listbackcolor = value; }
        public Color Listtextcolor { get => listtextcolor; set => listtextcolor = value; }
        public Color Bordercolor { get => bordercolor; set => bordercolor = value; }
        public int Bordersize
        {
            get => bordersize;
            set
            {
                bordersize = value;
                this.Padding=new Padding(bordersize);
                AdjustComboBoxDimensions();
            }
        }
        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                lbltext.ForeColor = value;
            }
        }
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                lbltext.Font = value;
                cmblist.Font = value;
            }
        }
        public string Texts
        {   get => lbltext.Text;
            set => lbltext.Text = value;
        }
        public ComboBoxStyle DropDownStyle
        {   get => cmblist.DropDownStyle;
            set
            {   if(cmblist.DropDownStyle!=ComboBoxStyle.Simple)
                    cmblist.DropDownStyle = value;
                
            }

        }
        //default event
        public event EventHandler OnSelectedIndexChanged;


        public CustomComboBox()
        {
            cmblist = new();
            lbltext = new();
            btnicon = new();
            this.SuspendLayout();
            //combobox dropdown list
            cmblist.BackColor = listbackcolor;
            cmblist.Font = new Font(this.Font.Name, 10F);
            cmblist.ForeColor = listtextcolor;
            cmblist.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            cmblist.TextChanged += new EventHandler(ComboBox_TextChanged);
            //button
            btnicon.Dock = DockStyle.Right;
            btnicon.FlatStyle = FlatStyle.Flat;
            btnicon.FlatAppearance.BorderSize = 0;
            btnicon.BackColor=backcolor;
            btnicon.Size = new Size(30, 30);
            btnicon.Cursor= Cursors.Hand;
            btnicon.Click += new EventHandler(Icon_Click);//open dropdownlist
            btnicon.Paint += new PaintEventHandler(Icon_Paint);
            //label
            lbltext.Dock= DockStyle.Fill;
            lbltext.AutoSize = false;
            lbltext.BackColor = backcolor;
            lbltext.TextAlign=ContentAlignment.MiddleLeft;
            lbltext.Padding = new Padding(0,0,0,0);
            lbltext.Font = new Font(this.Font.Name, 10F);
            lbltext.Click += new EventHandler(Surface_Click);//slect combo box
            //user control
            this.Controls.Add(lbltext);
            this.Controls.Add(btnicon);
            this.Controls.Add(cmblist);
            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(bordersize);
            base.BackColor = bordercolor;
            this.ResumeLayout();
            AdjustComboBoxDimensions();

        }

        private void AdjustComboBoxDimensions()
        {
            cmblist.Width = lbltext.Width;
            cmblist.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cmblist.Width,
                Y = lbltext.Bottom - cmblist.Height,
            };
        }

        private void Surface_Click(object? sender, EventArgs e)
        {
            cmblist.Select();
            if (cmblist.DropDownStyle == ComboBoxStyle.DropDownList)
                cmblist.DroppedDown = true;
        }

        private void Icon_Paint(object? sender, PaintEventArgs e)
        {
            int iconwidth = 14;
            int iconheight = 6;
            var recticon=new Rectangle((btnicon.Width-iconwidth)/2,(btnicon.Height-iconheight)/2, iconwidth, iconheight);
            Graphics graph = e.Graphics;
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconcolor, 2))
            {   graph.SmoothingMode=SmoothingMode.AntiAlias;
                path.AddLine(recticon.X, recticon.Y, recticon.X + (iconwidth / 2), recticon.Bottom);
                path.AddLine(recticon.X + (iconwidth / 2), recticon.Bottom, recticon.Right, recticon.Y);
                graph.DrawPath(pen, path);

            }
            
        }

        private void Icon_Click(object? sender, EventArgs e)
        {
            cmblist.Select();
            cmblist.DroppedDown = true;

        }

        private void ComboBox_TextChanged(object? sender, EventArgs e)
        {
            lbltext.Text = cmblist.Text;
        }

        private void ComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if(OnSelectedIndexChanged!= null)
            {
                OnSelectedIndexChanged.Invoke(sender, e);
            }
            lbltext.Text=cmblist.Text;
        }
    }
}
