using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShip
{
    public class SimpleMotors : IMotors
    {
        public float _startPosX;
        public float _startPosY;
        public SimpleMotors(float x, float y)
        {
            _startPosX = x;
            _startPosY = y;
        }

        public void DrawMotors(Graphics g, CountMotors countMotors, Color color)
        {
            Pen pen = new Pen(Color.Black);
            Brush white = new SolidBrush(color);
            switch ((int)countMotors + 1)
            {
                case 1:
                    g.FillRectangle(white, _startPosX - 10, _startPosY - 5, 8, 10);
                    g.DrawRectangle(pen, _startPosX - 10, _startPosY - 5, 8, 10);
                    break;
                case 2:
                    g.FillRectangle(white, _startPosX - 8, _startPosY - 8, 8, 10);
                    g.DrawRectangle(pen, _startPosX - 8, _startPosY - 8, 8, 10);
                    g.FillRectangle(white, _startPosX - 10, _startPosY - 5, 8, 10);
                    g.DrawRectangle(pen, _startPosX - 10, _startPosY - 5, 8, 10);
                    break;
                case 3:
                    g.FillRectangle(white, _startPosX - 6, _startPosY - 10, 8, 10);
                    g.DrawRectangle(pen, _startPosX - 6, _startPosY - 10, 8, 10);
                    g.FillRectangle(white, _startPosX - 8, _startPosY - 8, 8, 10);
                    g.DrawRectangle(pen, _startPosX - 8, _startPosY - 8, 8, 10);
                    g.FillRectangle(white, _startPosX - 10, _startPosY - 5, 8, 10);
                    g.DrawRectangle(pen, _startPosX - 10, _startPosY - 5, 8, 10);
                    break;
            }
        }
    }
}

