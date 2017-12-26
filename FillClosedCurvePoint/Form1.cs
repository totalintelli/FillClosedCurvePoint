using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FillClosedCurvePoint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Create solid brush.
            SolidBrush redBrush = new SolidBrush(Color.Red);

            //Create array of points for curve.
            PointF[] points =
                { new PointF(panel1.Width / 2.0f, 0),
                  new PointF(panel1.Width, panel1.Height * 3 / 4.0f),
                  new PointF(panel1.Width / 2.0f, panel1.Height),
                  new PointF(0, panel1.Height * 3 / 4.0f)
                };

            // Fill curve on screen.
            e.Graphics.FillClosedCurve(redBrush, points);
        }
    }
}
