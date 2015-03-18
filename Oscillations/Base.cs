using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Oscillations
{
    class Base
    {
        public struct Axis
        {
            public PointF p0;
            public PointF p1;
            public Pen pen;
            public Axis(PointF p2,PointF p3)
            {
                this.p0 = p2;
                this.p1 = p3;
                pen = new Pen(Color.Black);
            }
            public Axis(PointF p2, PointF p3,Pen _pen)
            {
                this.p0 = p2;
                this.p1 = p3;
                pen = _pen;
            }
        }
        public static List<List<PointF>> VoltPts = new List<List<PointF>>();
        public static List<List<PointF>> CharPts = new List<List<PointF>>(); 
        public static List<Axis> Axises = new List<Axis>(); 
    }
}
