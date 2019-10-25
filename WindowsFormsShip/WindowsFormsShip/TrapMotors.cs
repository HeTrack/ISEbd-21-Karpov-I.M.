using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShip
{
    public class TrapMotors : IMotors
    {
        public float _startPosX;
        public float _startPosY;

        public TrapMotors(float x, float y)
        {
            _startPosX = x;
            _startPosY = y;
        }
        public void DrawMotors(Graphics g, CountMotors countMotors, Color color)
        {
            Pen pen = new Pen(Color.Black);
            Brush white = new SolidBrush(color);
            Point po1 = new Point((int)_startPosX - 15, (int)_startPosY + 7);
            Point po2 = new Point((int)_startPosX - 8, (int)_startPosY - 3);
            Point po3 = new Point((int)_startPosX, (int)_startPosY - 3);
            Point po4 = new Point((int)_startPosX, (int)_startPosY + 7);
            Point[] pocase = { po1, po2, po3, po4 };
            switch ((int)countMotors + 1)
            {
                case 1:
                    g.FillPolygon(white, pocase);
                    g.DrawPolygon(pen, pocase);
                    break;
                case 2:

                     po1 = new Point((int)_startPosX - 15, (int)_startPosY + 2);
                     po2 = new Point((int)_startPosX - 8, (int)_startPosY - 8);
                     po3 = new Point((int)_startPosX, (int)_startPosY - 8);
                     po4 = new Point((int)_startPosX, (int)_startPosY);
                     pocase = new Point[] { po1, po2, po3, po4 };
                    g.FillPolygon(white, pocase);
                    g.DrawPolygon(pen, pocase);
                     po1 = new Point((int)_startPosX - 15, (int)_startPosY + 7);
                     po2 = new Point((int)_startPosX - 8, (int)_startPosY - 3);
                     po3 = new Point((int)_startPosX, (int)_startPosY - 3);
                     po4 = new Point((int)_startPosX, (int)_startPosY + 7);
                    pocase = new Point[] { po1, po2, po3, po4 };
                    g.FillPolygon(white, pocase);
                    g.DrawPolygon(pen, pocase);
                   
                    break;
                case 3:
                    po1 = new Point((int)_startPosX - 15, (int)_startPosY -3);
                    po2 = new Point((int)_startPosX - 8, (int)_startPosY - 13);
                    po3 = new Point((int)_startPosX, (int)_startPosY - 13);
                    po4 = new Point((int)_startPosX, (int)_startPosY -3);
                    pocase = new Point[] { po1, po2, po3, po4 };
                    g.FillPolygon(white, pocase);
                    g.DrawPolygon(pen, pocase);
                    po1 = new Point((int)_startPosX - 15, (int)_startPosY + 2);
                    po2 = new Point((int)_startPosX - 8, (int)_startPosY - 8);
                    po3 = new Point((int)_startPosX, (int)_startPosY - 8);
                    po4 = new Point((int)_startPosX, (int)_startPosY+2);
                    pocase = new Point[] { po1, po2, po3, po4 };
                    g.FillPolygon(white, pocase);
                    g.DrawPolygon(pen, pocase);
                    po1 = new Point((int)_startPosX - 15, (int)_startPosY + 7);
                    po2 = new Point((int)_startPosX - 8, (int)_startPosY - 3);
                    po3 = new Point((int)_startPosX, (int)_startPosY - 3);
                    po4 = new Point((int)_startPosX, (int)_startPosY + 7);
                    pocase = new Point[] { po1, po2, po3, po4 };
                    g.FillPolygon(white, pocase);
                    g.DrawPolygon(pen, pocase);
                    break;
            }
        }
    }
}