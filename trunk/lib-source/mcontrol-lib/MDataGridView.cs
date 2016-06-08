using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace mcontrol
{
    public partial class MDataGridView : DataGridView
    {
        public MDataGridView()
        {
            InitializeComponent();
            SetDataGridViewDefaultStyle();
        }

        private void SetDataGridViewDefaultStyle()
        {
            ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9);
            this.BorderStyle = BorderStyle.None;
            this.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            this.RowHeadersVisible = false;
            this.MultiSelect = false;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
        }

        public MDataGridView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            SetDataGridViewDefaultStyle();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Draw(e.Graphics);
            
        }

        private void Draw(Graphics g)
        {
/*            Graphics g = this.CreateGraphics();*/
            Pen headerPen = new Pen(Color.FromArgb(100, 100, 100), 2f);
            //Pen headerPen = new Pen(Color.FromArgb(20, 71, 156), 2f);
            headerPen.Alignment = PenAlignment.Inset;

            Pen gridPen = new Pen(Color.LightBlue, 0.5f);
            gridPen.Alignment = PenAlignment.Center;

            foreach (DataGridViewColumn column in this.Columns)
            {
                Rectangle headerCellRectangle = this.GetCellDisplayRectangle(column.Index, -1, true);
                DrawRoundedRectangle(g, headerCellRectangle, 5, headerPen);
            }

            foreach (DataGridViewRow row in this.Rows)
            {
                foreach (DataGridViewColumn column in this.Columns)
                {
                    Rectangle CellRectangle = this.GetCellDisplayRectangle(column.Index, row.Index, true);
                    g.DrawRectangle(gridPen, CellRectangle);
                }


            }

            g.Dispose();
        }


        public void DrawRoundedRectangle(Graphics g, Rectangle r, int d, Pen p)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            gp.AddLine(r.X, r.Y + r.Height - d, r.X, r.Y + d / 2);

            g.DrawPath(p, gp);
        }

        protected override void OnScroll(ScrollEventArgs e)
        {
            base.OnScroll(e);
            Invalidate();            
        }
    }
}
