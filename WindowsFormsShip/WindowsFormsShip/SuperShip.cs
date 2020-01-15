using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShip
{
    public class SuperShip : Ship
    {
        public Color DopColor { private set; get; }
        public bool LifeBuoy { private set; get; }
        public bool SecondBoard { private set; get; }
        public CountMotors Motors { private set; get; }
        public string num;
        private int MotorsForm;
        public SuperShip(int maxSpeed, float weight, Color bottomColor, Color dopColor, bool secondBoard, bool lifebuoy, CountMotors countmotors, int motorsType ) :
            base(maxSpeed, weight, bottomColor)
        {
            DopColor = dopColor;
            LifeBuoy = lifebuoy;
            SecondBoard = secondBoard;     
            Motors = countmotors;
            MotorsForm = motorsType;
        }

        public SuperShip(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 8)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                LifeBuoy = Convert.ToBoolean(strs[4]);
                SecondBoard = Convert.ToBoolean(strs[5]);
                num = Convert.ToString(strs[6]);
                switch (num)
                {
                    case "One":
                        {
                            Motors = CountMotors.One;
                            break;
                        }
                    case "Two":
                        {
                            Motors = CountMotors.Two;
                            break;
                        }
                    case "Three":
                        {
                            Motors = CountMotors.Three;
                            break;
                        }
                }
                MotorsForm = Convert.ToInt32(strs[7]);
            }
        }

        public override void DrawShip(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush white = new SolidBrush(Color.White);
            Brush bottom = new SolidBrush(MainColor);
            Brush brBlack = new SolidBrush(Color.Black);
            Brush hull = new SolidBrush(DopColor);
            if (SecondBoard)
            {
                g.FillRectangle(white, _startPosX + 20, _startPosY - 35, 55, 4);
                g.DrawRectangle(pen, _startPosX + 20, _startPosY - 35, 55, 4);
                Point sboard1 = new Point((int)_startPosX + 40, (int)_startPosY - 35);
                Point sboard2 = new Point((int)_startPosX + 44, (int)_startPosY - 37);
                Point sboard3 = new Point((int)_startPosX + 74, (int)_startPosY - 42);
                Point sboard4 = new Point((int)_startPosX + 76, (int)_startPosY - 35);
                Point[] sboard = { sboard1, sboard2, sboard3, sboard4 };
                Pen pen1 = new Pen(Color.Blue);
                g.DrawPolygon(pen1, sboard);
                g.FillPolygon(brBlack, sboard);
                g.DrawArc(pen1, _startPosX + 44, _startPosY - 48, 30, 15, 0, -60);
            }
            IMotors motors;
            switch (MotorsForm)
            {
                case 0:
                    motors = new SimpleMotors(_startPosX, _startPosY);
                    break;
                case 1:
                    motors = new TrapMotors(_startPosX, _startPosY);
                    break;
                case 2:
                    motors = new VentilMotors(_startPosX, _startPosY);
                    break;
                default:
                    motors = new SimpleMotors(_startPosX, _startPosY);
                    break;
            }
            motors.DrawMotors(g, Motors, Color.Black);
            base.DrawShip(g);
            Point po1 = new Point((int)_startPosX, (int)_startPosY);
            Point po2 = new Point((int)_startPosX + 125, (int)_startPosY);
            Point po3 = new Point((int)_startPosX + 150, (int)_startPosY - 15);
            Point po4 = new Point((int)_startPosX + 7, (int)_startPosY - 15);
            Point[] po = { po1, po2, po3, po4 };
            g.FillPolygon(hull, po);
            if (LifeBuoy)
            {
                Pen orange = new Pen(Color.Orange, 2);
                Pen whitep = new Pen(Color.White, 2);
                g.DrawEllipse(orange, _startPosX + 120, _startPosY - 14, 10, 10);
                g.DrawLine(whitep, _startPosX + 131, _startPosY - 9, _startPosX + 131, _startPosY - 7);
                g.DrawLine(whitep, _startPosX + 121, _startPosY - 9, _startPosX + 121, _startPosY - 7);
                g.DrawLine(whitep, _startPosX + 126, _startPosY - 14, _startPosX + 126, _startPosY - 12);
                g.DrawLine(whitep, _startPosX + 126, _startPosY - 4, _startPosX + 126, _startPosY - 2);
            }
        }

        public void LocateMotorsType(int form)
        {
            MotorsForm = form;
        }

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + SecondBoard + ";" + LifeBuoy + ";" + Motors + ";" + MotorsForm;
        }
    }
}