using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShip
{
   
    public class DrawMotors
    {
        public countMotors motorCount { private get; set; }
        float posx = Ship._startPosX;
        float posy = Ship._startPosY;

        public DrawMotors(countMotors numberOfMotors, float _startPosX, float _startPosY)
        {
            motorCount = numberOfMotors;
            posx = _startPosX;
            posy = _startPosY;

        }
        public void MotorDraw(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush white = new SolidBrush(Color.White);
            switch (motorCount)
            {
                case countMotors.One:
                    g.FillRectangle(white, posx - 10, posy - 5, 8, 10);
                    g.DrawRectangle(pen, posx - 10, posy - 5, 8, 10);
                    break;
                case countMotors.Two:
                    g.FillRectangle(white, posx - 8, posy - 8, 8, 10);
                    g.DrawRectangle(pen, posx - 8, posy - 8, 8, 10);
                    g.FillRectangle(white, posx - 10, posy - 5, 8, 10);
                    g.DrawRectangle(pen, posx - 10, posy - 5, 8, 10);
                    break;
                case countMotors.Three:
                    g.FillRectangle(white, posx - 6, posy - 10, 8, 10);
                    g.DrawRectangle(pen, posx - 6, posy - 10, 8, 10);
                    g.FillRectangle(white, posx - 8, posy - 8, 8, 10);
                    g.DrawRectangle(pen, posx - 8, posy - 8, 8, 10);
                    break;

            }

        }
    }
}