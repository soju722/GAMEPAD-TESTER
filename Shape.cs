using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp10
{
    public partial class Shape : UserControl
    {
        public Shape()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush sb = new SolidBrush(Color.Gray);
            Graphics g = this.CreateGraphics();
            Point[] points = { new Point(0, 10), new Point(0, 0), new Point(10, 0), };
            g.FillPolygon(sb, points);
        }
    }
}
