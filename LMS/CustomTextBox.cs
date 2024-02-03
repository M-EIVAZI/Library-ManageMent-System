using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Converters;

namespace LMS
{
    [DefaultEvent("_TextChanged")]
    public partial class CustomTextBox : UserControl
    {
        public CustomTextBox()
        {
            InitializeComponent();
        }
        public event EventHandler _TextChanged;
        private Color borderfocuscolor = Color.HotPink;
        private bool isfocused = false;


        private Color bordercolor = Color.FromArgb(128, 64, 64);
        private int bordersize = 2;
        private bool underlinedstyle = false;
        //for rounded texbox
        //private int borderradius = 0;
        private Color placeholdercolor = Color.DarkGray;
        private string placeholdertext = "";
        private bool isplaceholder = false;
        private bool ispasswordchar = false;
        [Category("MyButton Advance Category")]
        public Color Bordercolor
        {
            get => bordercolor;
            set
            {
                bordercolor = value;
                this.Invalidate();
            }
        }
        [Category("MyButton Advance Category")]
        public int Bordersize
        {
            get => bordersize;
            set
            {
                bordersize = value;
                this.Invalidate();
            }
        }
        [Category("MyButton Advance Category")]
        public bool Underlinedstyle
        {
            get => underlinedstyle;
            set
            {
                underlinedstyle = value;
                this.Invalidate();
            }
        }
        [Category("MyButton Advance Category")]
        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }

        }
        [Category("MyButton Advance Category")]
        public bool MultiLine
        {
            get => textBox1.Multiline;
            set => textBox1.Multiline = value;

        }
        [Category("MyButton Advance Category")]
        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;

            }
        }
        [Category("MyButton Advance Category")]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }
        [Category("MyButton Advance Category")]
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }
        [Category("MyButton Advance Category")]
        public string Texts
        {
            get
            {
                if (isplaceholder)
                    return "";
                else
                    return textBox1.Text;

            }
            set
            {
                textBox1.Text = value;
                SetPlaceHolder();
            }


        }
        [Category("MyButton Advance Category")]
        public bool Readonly
        {
            get => textBox1.ReadOnly;
            set => textBox1.ReadOnly = value;

        }
        [Category("MyButton Advance Category")]
        public Color Borderfocuscolor { get => borderfocuscolor; set => borderfocuscolor = value; }
        //[Category("MyButton Advance Category")]
        //public int Borderradius
        //{
        //    get => borderradius;
        //    set
        //    {
        //        if (value >= 0)
        //        {
        //            borderradius = value;
        //            this.Invalidate();
        //        }
        //    }
        //}
        [Category("MyButton Advance Category")]
        public string Placeholdertext
        {
            get => placeholdertext;
            set
            {
                placeholdertext = value;
                textBox1.Text = "";
                SetPlaceHolder();
            }
        }

        private void SetPlaceHolder()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && placeholdertext != "")
            {
                isplaceholder = true;
                textBox1.Text = placeholdertext;
                textBox1.ForeColor = placeholdercolor;
                if (ispasswordchar)
                    textBox1.UseSystemPasswordChar = false;


            }
        }
        private void RemovePlaceHolder()
        {
            if (isplaceholder && placeholdertext != "")
            {
                isplaceholder = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;
                if (ispasswordchar)
                    textBox1.UseSystemPasswordChar = true;


            }

        }
        [Category("MyButton Advance Category")]
        public Color Placeholdercolor
        {
            get => placeholdercolor;
            set
            {
                placeholdercolor = value;
                if (isplaceholder)
                    textBox1.ForeColor = value;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged(sender, e);

        }
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    Graphics graphics = e.Graphics;
        //    if (borderradius > 1)
        //    {
        //        var rectbordersmooth = this.ClientRectangle;
        //        var rectborder = Rectangle.Inflate(rectbordersmooth, -bordersize, -bordersize);
        //        int smoothsize = bordersize > 0 ? bordersize : 1;
        //        using (GraphicsPath pathbordersmooth = GetFigurePath(rectbordersmooth, bordersize))
        //        using (GraphicsPath pathborder = GetFigurePath(rectborder, borderradius - bordersize))
        //        using (Pen penbordersmooth = new(this.Parent.BackColor, smoothsize))
        //        using (Pen penborder = new(bordercolor, bordersize))
        //        {
        //            this.Region = new Region(pathbordersmooth);
        //            if (borderradius > 15)
        //                SetTexBoxRoundedRegion();
        //            graphics.SmoothingMode = SmoothingMode.AntiAlias;
        //            penborder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
        //            if (isfocused)
        //                penborder.Color = borderfocuscolor;
        //            if (underlinedstyle)
        //            {
        //                graphics.DrawPath(penborder, pathbordersmooth);
        //                graphics.SmoothingMode = SmoothingMode.None;
        //                graphics.DrawLine(penborder, 0, this.Height - 1, this.Width, this.Height - 1);
        //            }
        //            else
        //            {   //graphics.DrawRectangle(penborder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
        //                graphics.DrawPath(penbordersmooth, pathbordersmooth);
        //                graphics.DrawPath(penborder, pathborder);

        //            }
        //        }
        //    }
        //    else
        //    {
        //        using (Pen penborder = new(bordercolor, bordersize))
        //        {
        //            this.Region = new Region(this.ClientRectangle);
        //            penborder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
        //            if (isfocused)
        //                penborder.Color = borderfocuscolor;
        //            if (underlinedstyle)
        //                graphics.DrawLine(penborder, 0, this.Height - 1, this.Width, this.Height - 1);
        //            else
        //                graphics.DrawRectangle(penborder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);


        //        }

        //    }


        //}
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            using (Pen penborder = new(bordercolor, bordersize))
            {
                penborder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (isfocused)
                    penborder.Color = borderfocuscolor;
                if (underlinedstyle)
                    graph.DrawLine(penborder, 0, this.Height - 1, this.Width, this.Height - 1);
                else
                    graph.DrawRectangle(penborder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);

            }

        }
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new();
            float curvesize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curvesize, curvesize, 180, 90);
            path.AddArc(rect.Right - curvesize, rect.Y, curvesize, curvesize, 270, 90);
            path.AddArc(rect.Right - curvesize, rect.Bottom - curvesize, curvesize, curvesize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curvesize, curvesize, curvesize, 90, 90);
            path.CloseFigure();
            return path;

        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int textheight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, textheight);
                textBox1.Multiline = false;
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isfocused = true;
            this.Invalidate();
            RemovePlaceHolder();

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isfocused = false;
            this.Invalidate();
            SetPlaceHolder();

        }
    }
}
