using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShip
{
    public class SuperShip : Ship,IComparable<SuperShip>,IEquatable<SuperShip>
    {
        public Color DopColor { private set; get; }
        public bool LifeBuoy { private set; get; }
        public bool SecondBoard { private set; get; }
        public int Motors { private set; get; }
        public SuperShip(int maxSpeed, float weight, Color bottomColor, Color dopColor, bool secondBoard, bool lifebuoy, int countmotors) :
            base(maxSpeed, weight, bottomColor)
        {
            DopColor = dopColor;
            LifeBuoy = lifebuoy;
            SecondBoard = secondBoard;
            Random rnd = new Random();
            Motors = countmotors;
        }
        public SuperShip(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                LifeBuoy = Convert.ToBoolean(strs[4]);
                SecondBoard = Convert.ToBoolean(strs[5]);
                Motors = Convert.ToInt32(strs[6]);
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
            switch (Motors)
            {
                case 1:
                    g.FillRectangle(white, _startPosX - 10, _startPosY - 5, 8, 10);
                    g.DrawRectangle(pen, _startPosX - 10, _startPosY - 5, 8, 10);
                    break;
                case 2:
                    g.FillRectangle(white, _startPosX - 8, _startPosY - 8, 8, 10);
                    g.DrawRectangle(
                    pen, _startPosX - 8, _startPosY - 8, 8, 10);
                    g.FillRectangle(white, _startPosX - 10, _startPosY - 5, 8, 10);
                    g.DrawRectangle(pen, _startPosX - 10, _startPosY - 5, 8, 10);
                    break;
                case 3:
                    g.FillRectangle(white, _startPosX - 6, _startPosY - 10, 8, 10);
                    g.DrawRectangle(pen, _startPosX - 6, _startPosY - 10, 8, 10);
                    g.FillRectangle(white, _startPosX - 8, _startPosY - 8, 8, 10);
                    g.DrawRectangle(pen, _startPosX - 8, _startPosY - 8, 8, 10);
                    break;
            }
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
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" +  SecondBoard + ";" + LifeBuoy + ";" + Motors;
        }
        /// <summary>
        /// Метод интерфейса IComparable для класса SuperShip
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(SuperShip other)
        {
            var res = (this is Ship).CompareTo(other is Ship);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (LifeBuoy != other.LifeBuoy)
            {
                return LifeBuoy.CompareTo(other.LifeBuoy);
            }
            if (SecondBoard != other.SecondBoard)
            {
                return SecondBoard.CompareTo(other.SecondBoard);
            }
            if (Motors != other.Motors)
            {
                return Motors.CompareTo(other.Motors);
            }
            return 0;
        }
        /// <summary>
        /// Метод интерфейса IEquatable для класса SuperShip
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(SuperShip other)
        {
            var res = (this as Ship).Equals(other as Ship);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (LifeBuoy != other.LifeBuoy)
            {
                return false;
            }
        if (SecondBoard != other.SecondBoard)
            {
                return false;
            }
            if (Motors != other.Motors)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is SuperShip shipObj))
            {
                return false;
            }
            else
            {
                return Equals(shipObj);
            }
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
