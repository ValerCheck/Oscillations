using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Oscillations
{
    public partial class Voltage : Form
    {
        public float[] st = {5,5};          //оголошення одномірного масиву для задання стилю
        Pen pan = new Pen(Color.Black);
        private float x0=30;                   //положення початку координатної сітки по осі ОХ
        private float y0;                       //відповідно по осі ОУ
        private double value;
        public List<PointF> voltcapapts = new List<PointF>();   //список для зберігання точок графіку ємнісної напруги
        public List<PointF> voltindpts = new List<PointF>();    //аналогічно для точок графіку індуктивної напруги
        public float mult=50;                                   //коефіцієнт множення (для відображення графіку у величині, відповідній до екрану)
        private float minyc = (float) 0.0;               //координата (у) максимуму резонансної ємнісної напруги
        private float minxc = (float)0.0;                //координата (х) максимуму резонансної ємнісної напруги
        private float minyi = (float)0.0;                //відповідно координати резонансної кривої індуктивної напруги
        private float minxi = (float)0.0;
        private float lenar = 18;                       //довжина стрілок координатної системи
        public Voltage()
        {
            InitializeComponent();
            y0 = voltpan.Height - 30;
            Graphics gr = voltpan.CreateGraphics();

            //Далі зберігаємо точки координатної сітки в статичних списках 
            //////////////////////
            
            Base.Axises.Add(new Base.Axis(new PointF(x0-lenar/4,lenar),new PointF(x0,0)));
            Base.Axises.Add(new Base.Axis(new PointF(x0 + lenar/4, lenar), new PointF(x0, 0)));
            Base.Axises.Add(new Base.Axis(new PointF(voltpan.Width - lenar, y0 - lenar/4), new PointF(voltpan.Width, y0)));
            Base.Axises.Add(new Base.Axis(new PointF(x0 + lenar/4, lenar), new PointF(x0, 0)));
            Base.Axises.Add(new Base.Axis(new PointF(voltpan.Width - lenar, y0 + lenar/4), new PointF(voltpan.Width, y0)));
            Base.Axises.Add(new Base.Axis(new PointF(x0,0),new PointF(x0,voltpan.Height)));
            Base.Axises.Add(new Base.Axis(new PointF(0,y0),new PointF(voltpan.Width,y0)));
            /////////////////////
            
            value = coefZtab.Value/100.0;             //значенню коефіцієнта затухання присвоюємо значення слайдера (повзунка у вікні)
            coefVal.Text = (coefZtab.Value/100.0).ToString();
            coefZtab.Enabled = false;
            capCol.BackColor = Color.Blue;
            indCol.BackColor = Color.Red;
            pan.DashPattern = st;
            CapU.Checked = true;
        }

        public void GetMinY(List<PointF> pts ,out float miny,out float minx)  //функція для отримання точки максимуму резонансної кривої (пошук мінімального значення в списку точок)
        {
            miny = pts[0].Y;
            minx = pts[0].X;
            var y = 0.0;
            int length = pts.Count;
            for (int i = 0; i < length;i++ )
            {
                y = pts[i].Y;
                if (y < miny)
                {
                    miny = (float)y;
                    minx = pts[i].X;
                }
            }
        }

        public void CalcPoints(double num,double x,List<PointF> pts )  //метод для обчислення точок кривої
        {
            pts.Add(new PointF((float)(x * 200 + x0),
                       voltpan.Height -
                       (float)(num / (Math.Sqrt((1 - x * x) * (1 - x * x) + 4 * value * value * x * x))) * (mult) -
                       (voltpan.Height - y0)));
        }

        private void turnvoltb_Click(object sender, EventArgs e)
        {
            Graphics gr = voltpan.CreateGraphics();
            gr.DrawLine(new Pen(Color.Black), x0, 0, x0, voltpan.Height);
            gr.DrawLine(new Pen(Color.Black), 0, y0, voltpan.Width, y0);
            do
            {
                voltcapapts.Clear();
                voltindpts.Clear();
                for (double xx = 0; xx < 3.0; xx += 0.015)
                {
                    CalcPoints(1, xx, voltcapapts);
                }
                for (double xx = 0; xx < 3.0; xx += 0.015)
                {
                    CalcPoints(xx*xx, xx, voltindpts);
                }
                GetMinY(voltcapapts,out minyc,out minxc);
                GetMinY(voltindpts, out minyi, out minxi);
                if (minyc < 0||minyi<0)
                    mult -= 5;
                else break;
            } while (true);
            if (CapU.Checked)
            {
                gr.DrawLines(new Pen(Brushes.Blue, 2), voltcapapts.ToArray());
                //Base.Axises.Add(new Base.Axis(new PointF(minxc, minyc), new PointF(minxc, y0)){pen = pan});
                //gr.DrawLine(pan, Base.Axises[Base.Axises.Capacity - 1].p0, Base.Axises[Base.Axises.Capacity - 1].p1);
                gr.DrawLine(pan, new PointF(minxc, minyc), new PointF(minxc, y0));
                gr.DrawLine(pan, new PointF((float)minxc, (float)minyc), new PointF(x0 + 1, (float)minyc));

            }
            else if (IndU.Checked)
            {
                gr.DrawLines(new Pen(Color.Red, 2), voltindpts.ToArray());
                gr.DrawLine(pan, new PointF((float)minxi, (float)minyi), new PointF((float)minxi, y0));
                gr.DrawLine(pan, new PointF((float)minxi, (float)minyi), new PointF(x0 + 1, (float)minyi));

            }
            Base.VoltPts.Add(voltcapapts);
            Base.VoltPts.Add(voltindpts);
            turnvoltb.Enabled = false;
            coefZtab.Enabled = true;
        }

        private void voltpan_Paint(object sender, PaintEventArgs e)
        {
            //функція для власне побудови самого графіка

            var pen = new List<Pen>();
            pen.Add(new Pen(Color.Blue,2));
            pen.Add(new Pen(Color.Red,2));
            foreach (var points in Base.VoltPts) //в цьому циклі будується графік
            {
                e.Graphics.DrawLines(pen[0], points.ToArray());
            }
            foreach (var axis in Base.Axises)  //в цьому циклі - осі координат
            {
                e.Graphics.DrawLine(axis.pen,axis.p0,axis.p1 );
            }
        }

        private void coefZtab_ValueChanged(object sender, EventArgs e)
        {
            /*Ця функція викликається тоді, коли
             відбулася зміна коефіцієнту загасання,
             функціонал дуже схожий до функції IndU_CheckedChanged*/

            value = coefZtab.Value/100.0;
            coefVal.Text = value.ToString();
            Graphics gr = voltpan.CreateGraphics();
            gr.DrawLine(new Pen(Color.Black), x0, 0, x0, voltpan.Height);
            gr.DrawLine(new Pen(Color.Black), 0, y0, voltpan.Width, y0);
            if (CapU.Checked)
            {
                gr.DrawLine(new Pen(Color.White), new PointF((float)minxc, (float)minyc), new PointF((float)minxc, y0 - 1));
                gr.DrawLine(new Pen(Color.White), new PointF((float)minxc, (float)minyc), new PointF(x0 + 1, (float)minyc));
                gr.DrawLines(new Pen(Color.White, 2), voltcapapts.ToArray());
                voltcapapts.Clear();
                for (double xx = 0; xx < 3.0; xx += 0.015)
                {
                    CalcPoints(1, xx, voltcapapts);
                }
                gr.DrawLines(new Pen(Color.Blue, 2), voltcapapts.ToArray());
                GetMinY(voltcapapts, out minyc, out minxc);
                gr.DrawLine(pan, new PointF((float)minxc, (float)minyc), new PointF((float)minxc, y0 - 1));
                gr.DrawLine(pan, new PointF((float)minxc, (float)minyc), new PointF(x0 + 1, (float)minyc));

            }
            else if (IndU.Checked)
            {
                gr.DrawLine(new Pen(Color.White), new PointF((float)minxi, (float)minyi), new PointF((float)minxi, y0 - 1));
                gr.DrawLine(new Pen(Color.White), new PointF((float)minxi, (float)minyi), new PointF(x0 + 1, (float)minyi));

                gr.DrawLines(new Pen(Color.White, 2), voltindpts.ToArray());
                voltindpts.Clear();
                for (double xx = 0; xx < 3.0; xx += 0.015)
                {
                    CalcPoints(xx * xx, xx, voltindpts);
                }
                gr.DrawLines(new Pen(Color.Red, 2), voltindpts.ToArray());
                GetMinY(voltindpts, out minyi, out minxi);
                gr.DrawLine(pan, new PointF((float)minxi, (float)minyi), new PointF((float)minxi, y0));
                gr.DrawLine(pan, new PointF((float)minxi, (float)minyi), new PointF(x0 + 1, (float)minyi));

            }
        }
        private void Voltage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Base.Axises.Clear();
            Base.VoltPts.Clear();
        }

        private void IndU_CheckedChanged(object sender, EventArgs e)
        {
            //Даний код викликається тоді, коли відбулася зміна
            //відображення значень, а саме було обрано значення індуктивної напруги
            
            if (!turnvoltb.Enabled)
            {
                /*фактично відбувається очищення графіка
                та обчислення точок для обраного значення
                і побудова нового відповідного графіка*/

                Graphics gr = voltpan.CreateGraphics();
                GetMinY(voltcapapts, out minyc, out minxc);

                //Тут відбувається очищення
            
                gr.DrawLine(new Pen(Color.White), new PointF((float)minxc, (float)minyc), new PointF((float)minxc, y0 - 1));
                gr.DrawLines(new Pen(Color.White, 2), voltcapapts.ToArray());
                gr.DrawLine(new Pen(Color.White), new PointF((float)minxc, (float)minyc), new PointF(x0 + 1, (float)minyc));
                foreach (var axis in Base.Axises)
                {
                    gr.DrawLine(new Pen(Color.Black), axis.p0, axis.p1);
                }
                
                //тут очищення закінчується
                
                voltindpts.Clear();
                
                //обчислення значень
                
                for (double xx = 0; xx < 3.0; xx += 0.015)
                {
                    CalcPoints(xx * xx, xx, voltindpts);
                }
                
                //завершення обчислення та побудова нового графіка
                
                gr.DrawLines(new Pen(Color.Red, 2), voltindpts.ToArray());
                GetMinY(voltindpts, out minyi, out minxi);
                gr.DrawLine(pan, new PointF((float)minxi, (float)minyi), new PointF((float)minxi, y0 - 1));
                gr.DrawLine(pan, new PointF((float)minxi, (float)minyi), new PointF(x0 + 1, (float)minyi));
                
                //завершення побудови
            }
        }

        private void CapU_CheckedChanged(object sender, EventArgs e)
        {
            //АНАЛОГІЧНА функція до попередної
            //лише зі значеням ємнісної напруги
            
            if (!turnvoltb.Enabled)
            {
                Graphics gr = voltpan.CreateGraphics();
                GetMinY(voltindpts, out minyi, out minxi);
                gr.DrawLine(new Pen(Color.White), new PointF(minxi, minyi), new PointF(x0 + 1, minyi));
                gr.DrawLine(new Pen(Color.White), new PointF((float)minxi, (float)minyi), new PointF((float)minxi, y0 - 1));
                gr.DrawLines(new Pen(Color.White, 2), voltindpts.ToArray());
                foreach (var axis in Base.Axises)
                {
                    gr.DrawLine(new Pen(Color.Black), axis.p0, axis.p1);
                }
                voltcapapts.Clear();
                for (double xx = 0; xx < 3.0; xx += 0.015)
                {
                    CalcPoints(1, xx, voltcapapts);
                }
                gr.DrawLines(new Pen(Color.Blue, 2), voltcapapts.ToArray());
                GetMinY(voltcapapts, out minyc, out minxc);
                gr.DrawLine(pan, new PointF((float)minxc, (float)minyc), new PointF((float)minxc, y0 - 1));
                gr.DrawLine(pan, new PointF((float)minxc, (float)minyc), new PointF(x0 + 1, (float)minyc));
            }
        }
    }
}
