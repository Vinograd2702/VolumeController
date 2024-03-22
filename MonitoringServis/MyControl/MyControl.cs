using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitoringServis.MyControl
{
    public class MyControl : Control
    {
        // Регулятор

        public double currentVlalue; // Текущее значение

        double YCenterPos;

        double XCenterPos;

        int YCurrentMousPosition;

        int XCurrentMousPosition;

        
        

        public MyControl()
        {
            currentVlalue = 0;

            XCenterPos = Size.Width / 2;
            YCenterPos = Size.Height / 2;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);



            if (e.Button == MouseButtons.Left)
            {
                if (-XCenterPos + e.X == 0) // если положение по оси X == 0
                {
                    if (YCenterPos - e.Y >= 0) // нахождение в верхнем положении, угол 90 град
                    {
                        currentVlalue = 90;
                    }
                    else if (YCenterPos - e.Y < 0)  // если находимся внизу, угол 270
                    {
                        currentVlalue = 270;
                    }
                }
                else if (-XCenterPos + e.X > 0) // если находимся в левой части координат
                {
                    if (YCenterPos - e.Y >= 0) // нахождение в левом верхнем положении, угол (0 - 90] град
                    {
                        currentVlalue = Math.Atan((YCenterPos - e.Y) / (-XCenterPos + e.X)) / Math.PI * 180;
                    }
                    else if (YCenterPos - e.Y < 0)  // если находимся в левом нижнем положении, угол (270-360) град
                    {
                        currentVlalue = 360 + Math.Atan((YCenterPos - e.Y) / (-XCenterPos + e.X)) / Math.PI * 180;
                    }
                }
                else
                {
                    if (YCenterPos - e.Y >= 0) // нахождение в правом верхнем положении, угол (90 - 180] град
                    {
                        currentVlalue = 180 + Math.Atan((YCenterPos - e.Y) / (-XCenterPos + e.X)) / Math.PI * 180;
                    }
                    else if (YCenterPos - e.Y < 0)  // если находимся в правом нижнем положении, угол (180-270) град
                    {
                        currentVlalue = 180 + Math.Atan((YCenterPos - e.Y) / (-XCenterPos + e.X)) / Math.PI * 180;
                    }
                }

                this.Invalidate();
            }

            
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {

            base.OnMouseDown(e);

            //начальное уголовое положение курсора
            var cornerStart = 0;
            //начальное конечное положение курсора
            var cornerEnd = 0;
            
            if (-XCenterPos + e.X == 0) // если положение по оси X == 0
            {
                if(YCenterPos - e.Y >= 0) // нахождение в верхнем положении, угол 90 град
                {
                    currentVlalue = 90;
                }
                else if(YCenterPos - e.Y < 0)  // если находимся внизу, угол 270
                {
                    currentVlalue = 270;
                }
            }
            else if (-XCenterPos + e.X > 0) // если находимся в левой части координат
            {
                if (YCenterPos - e.Y >= 0) // нахождение в левом верхнем положении, угол (0 - 90] град
                {
                    currentVlalue = Math.Atan((YCenterPos - e.Y) / (-XCenterPos + e.X)) / Math.PI * 180;
                }
                else if (YCenterPos - e.Y < 0)  // если находимся в левом нижнем положении, угол (270-360) град
                {
                    currentVlalue = 360 + Math.Atan((YCenterPos - e.Y) / (-XCenterPos + e.X)) / Math.PI * 180;
                }
            }
            else
            {
                if (YCenterPos - e.Y >= 0) // нахождение в правом верхнем положении, угол (90 - 180] град
                {
                    currentVlalue = 180 + Math.Atan((YCenterPos - e.Y) / (-XCenterPos + e.X)) / Math.PI * 180;
                }
                else if (YCenterPos - e.Y < 0)  // если находимся в правом нижнем положении, угол (180-270) град
                {
                    currentVlalue = 180 + Math.Atan((YCenterPos - e.Y) / (-XCenterPos + e.X)) / Math.PI * 180;
                }
            }

            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            
            base.OnPaint(e);
            XCenterPos = Size.Width / 2;
            YCenterPos = Size.Height / 2;
            Graphics g = e.Graphics;
            g.FillEllipse(Brushes.Green, 0, 0, Size.Width, Size.Height);
            g.FillEllipse(Brushes.Gray, Size.Width / 4, Size.Height / 4, Size.Width /2, Size.Height /2);
            Pen pen = new Pen(Color.Red, 10);
            double fi = currentVlalue * Math.PI / 180;

            g.DrawLine(pen, (int)(XCenterPos + Size.Width * 0.2 * Math.Cos(fi)), (int)(YCenterPos - Size.Width *0.2 * Math.Sin(fi)), 
                (int)(XCenterPos + Size.Width*0.45 * Math.Cos(fi)), (int)(YCenterPos - Size.Width*0.45 * Math.Sin(fi)));
            Thread.Sleep(60);
        }
    }
}
