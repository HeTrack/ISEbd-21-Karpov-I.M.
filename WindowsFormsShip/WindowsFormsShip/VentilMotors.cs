using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShip
{
    class VentilMotors : IMotors
    {
        public float _startPosX;
        public float _startPosY;
        public VentilMotors(float x, float y)
        {
            _startPosX = x;
            _startPosY = y;
        }

        public void DrawMotors(Graphics g, CountMotors countMotors, Color color)
        {
            Pen pen = new Pen(Color.Black);
            Brush white = new SolidBrush(color);
            Brush black = new SolidBrush(Color.Black);
            switch ((int)countMotors + 1)
            {
                case 1:
                    g.FillRectangle(black, _startPosX - 6, _startPosY - 8, 6, 18);
                    g.FillRectangle(black, _startPosX - 10, _startPosY, 4, 2);
                    g.FillEllipse(white, _startPosX - 13, _startPosY - 4, 3, 3);
                    g.DrawEllipse(pen, _startPosX - 13, _startPosY - 4, 3, 3);
                    g.FillEllipse(white, _startPosX - 13, _startPosY, 3, 3);
                    g.DrawEllipse(pen, _startPosX - 13, _startPosY, 3, 3);
                    g.FillEllipse(white, _startPosX - 16, _startPosY - 2, 3, 3);
                    g.DrawEllipse(pen, _startPosX - 16, _startPosY - 2, 3, 3);
                    break;
                case 2:
                    g.FillRectangle(black, _startPosX - 6, _startPosY - 8, 6, 18);
                    g.FillRectangle(black, _startPosX - 10, _startPosY, 4, 2);
                    g.FillEllipse(white, _startPosX - 13, _startPosY - 4, 3, 3);
                    g.DrawEllipse(pen, _startPosX - 13, _startPosY - 4, 3, 3);
                    g.FillEllipse(white, _startPosX - 13, _startPosY, 3, 3);
                    g.DrawEllipse(pen, _startPosX - 13, _startPosY, 3, 3);
                    g.FillEllipse(white, _startPosX - 16, _startPosY - 2, 3, 3);
                    g.DrawEllipse(pen, _startPosX - 16, _startPosY - 2, 3, 3);
                    g.FillRectangle(black, _startPosX - 10, _startPosY + 8, 4, 2);
                    g.FillEllipse(white, _startPosX - 13, _startPosY + 8, 3, 3);
                    g.DrawEllipse(pen, _startPosX - 13, _startPosY + 8, 3, 3);
                    g.FillEllipse(white, _startPosX - 13, _startPosY + 4, 3, 3);
                    g.DrawEllipse(pen, _startPosX - 13, _startPosY + 4, 3, 3);
                    g.FillEllipse(white, _startPosX - 16, _startPosY + 6, 3, 3);
                    g.DrawEllipse(pen, _startPosX - 16, _startPosY + 6, 3, 3);
                    break;
                case 3:
                    g.FillRectangle(black, _startPosX - 6, _startPosY - 8, 6, 18);
                    g.FillRectangle(black, _startPosX - 10, _startPosY, 4, 2);
                    g.FillEllipse(white, _startPosX - 13, _startPosY - 4, 3, 3);
                    g.DrawEllipse(pen, _startPosX - 13, _startPosY - 4, 3, 3);
                    g.FillEllipse(white, _startPosX - 13, _startPosY, 3, 3);
                    g.DrawEllipse(pen, _startPosX - 13, _startPosY, 3, 3);
                    g.FillEllipse(white, _startPosX - 16, _startPosY - 2, 3, 3);
                    g.DrawEllipse(pen, _startPosX - 16, _startPosY - 2, 3, 3);
                    g.FillRectangle(black, _startPosX - 10, _startPosY + 8, 4, 2);
                    g.FillEllipse(white, _startPosX - 13, _startPosY + 8, 3, 3);
                    g.DrawEllipse(pen, _startPosX - 13, _startPosY + 8, 3, 3);
                    g.FillEllipse(white, _startPosX - 13, _startPosY + 4, 3, 3);
                    g.DrawEllipse(pen, _startPosX - 13, _startPosY + 4, 3, 3);
                    g.FillEllipse(white, _startPosX - 16, _startPosY + 6, 3, 3);
                    g.DrawEllipse(pen, _startPosX - 16, _startPosY + 6, 3, 3);
                    g.FillRectangle(black, _startPosX - 10, _startPosY - 8, 4, 2);
                    g.FillEllipse(white, _startPosX - 13, _startPosY - 12, 3, 3);
                    g.DrawEllipse(pen, _startPosX - 13, _startPosY - 12, 3, 3);
                    g.FillEllipse(white, _startPosX - 13, _startPosY - 8, 3, 3);
                    g.DrawEllipse(pen, _startPosX - 13, _startPosY - 8, 3, 3);
                    g.FillEllipse(white, _startPosX - 16, _startPosY - 10, 3, 3);
                    g.DrawEllipse(pen, _startPosX - 16, _startPosY - 10, 3, 3);
                    break;
            }
        }
    }
}