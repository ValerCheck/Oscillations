using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Oscillations
{
    public partial class Charge : Form
    {
        private float x0=30;
        private float y0;
        private double qmvalue;
        public List<PointF> charpts = new List<PointF>();
        public float mult = 5;
        public Charge()
        {
            InitializeComponent();
            y0 = (float) (charpan.Height/2.0);
            Graphics gr = charpan.CreateGraphics();
            Base.Axises.Add(new Base.Axis(new PointF(x0, 0), new PointF(x0, charpan.Height)));
            Base.Axises.Add(new Base.Axis(new PointF(0, y0), new PointF(charpan.Width, y0)));
            gr.DrawLine(new Pen(Color.Black), Base.Axises[0].p0,Base.Axises[0].p1);
            gr.DrawLine(new Pen(Color.Black), Base.Axises[1].p0,Base.Axises[1].p1);
            qmvalue = charbar.Value;
            chartb.Text = charbar.Value.ToString();
            
        }

        private void charpan_Paint(object sender, PaintEventArgs e)
        {
            var col = new List<Color>();
            col.Add(Color.Blue);
            col.Add(Color.DarkOrange);
            foreach (var points in Base.CharPts)
            {
                e.Graphics.DrawLines(new Pen(col[Base.VoltPts.IndexOf(points)]), points.ToArray());
            }
            foreach (var axis in Base.Axises)
            {
                e.Graphics.DrawLine(axis.pen, axis.p0, axis.p1);
            }

        }

        private void chargeb_Click(object sender, EventArgs e)
        {
            var z = 0.2;
            Graphics gr = charpan.CreateGraphics();
            for (double xx = 0; xx < 44; xx += 0.2)
            {
                charpts.Add(new PointF((float)(xx * 10 + x0),
                                       -
                                       (float)(Math.Cos(xx)*qmvalue/(Math.Pow(Math.E,z*xx))* (mult) -
                                       y0)));
            }
            Base.CharPts.Add(charpts);
            gr.DrawLines(new Pen(Color.OrangeRed,2),charpts.ToArray() );
            chargeb.Enabled = false;
        }

        private void Charge_FormClosed(object sender, FormClosedEventArgs e)
        {
            Base.Axises.Clear();
            Base.CharPts.Clear();
        }

        private void charbar_ValueChanged(object sender, EventArgs e)
        {
            if (!chargeb.Enabled)
            {
                var z = 0.1;
                qmvalue = charbar.Value;
                chartb.Text = qmvalue.ToString();
                Graphics gr = charpan.CreateGraphics();
                if (charpts.Capacity != 0)
                    gr.DrawLines(new Pen(Color.White, 2), charpts.ToArray());
                charpts.Clear();
                gr.DrawLine(new Pen(Color.Black), Base.Axises[0].p0, Base.Axises[0].p1);
                gr.DrawLine(new Pen(Color.Black), Base.Axises[1].p0, Base.Axises[1].p1);
                for (double xx = 0; xx < 46; xx += 0.2)
                {
                    charpts.Add(new PointF((float) (xx*10 + x0),
                                           -
                                           (float) (Math.Cos(xx)*qmvalue/(Math.Pow(Math.E, z*xx))*(mult) -
                                                    y0)));
                }
                gr.DrawLines(new Pen(Color.Red, 2), charpts.ToArray());
            }
        }
    }
}
