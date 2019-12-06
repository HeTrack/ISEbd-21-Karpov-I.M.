using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShip
{
    public class Ship
    {
        public  static float _startPosX;

        public static float _startPosY;

        private int _pictureWidth;

        private int _pictureHeight;

        private const int shipWidth = 150;

        private const int shipHeight = 10;

        public int MaxSpeed { private set; get; }

        public float Weight { private set; get; }

        public Color MainColor { private set; get; }

        public Color DopColor { private set; get; }

        public bool SecondBoard { private set; get; }

        public bool LifeBuoy { private set; get; }

        public countMotors Motors { private set; get; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>

        public Ship(int maxSpeed, float weight, Color bottomColor, Color dopColor, bool secondBoard, bool lifebuoy, countMotors countmotors)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = bottomColor;
            DopColor = dopColor;
            SecondBoard = secondBoard;
            LifeBuoy = lifebuoy;
            Motors = countmotors;
        }
        /// Установка позиции корабля
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            int k = 30;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - shipWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - 10 - step > 0)

                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (SecondBoard)
                        k = 48;
                    else
                        k = 30;
                    if (_startPosY  - k -step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - shipHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public void DrawShip(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush white = new SolidBrush(Color.White);
            Brush bottom = new SolidBrush(MainColor);
            Brush brBlack = new SolidBrush(Color.Black);
            Brush hull = new SolidBrush(DopColor);
              DrawMotors drawMotors = new DrawMotors(Motors, _startPosX, _startPosY);
            drawMotors.MotorDraw(g);
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

            //Днище
            Point point1 = new Point((int)_startPosX, (int)_startPosY);
            Point point2 = new Point((int)_startPosX + 5, (int)_startPosY + 10);
            Point point3 = new Point((int)_startPosX + 100, (int)_startPosY + 10);
            Point point4 = new Point((int)_startPosX + 125, (int)_startPosY);
            Point[] board = { point1, point2, point3, point4 };
            g.DrawPolygon(pen, board);
            g.FillPolygon(bottom, board);

            //корпус
            Point po1 = new Point((int)_startPosX, (int)_startPosY);
            Point po2 = new Point((int)_startPosX + 125, (int)_startPosY);
            Point po3 = new Point((int)_startPosX + 150, (int)_startPosY - 15);
            Point po4 = new Point((int)_startPosX + 7, (int)_startPosY - 15);
            Point[] po = { po1, po2, po3, po4 };
            g.FillPolygon(hull, po);

            //кабина
            Point karkas1 = new Point((int)_startPosX + 40, (int)_startPosY - 15);
            Point karkas2 = new Point((int)_startPosX + 40, (int)_startPosY - 30);
            Point karkas3 = new Point((int)_startPosX + 80, (int)_startPosY - 30);
            Point karkas4 = new Point((int)_startPosX + 100, (int)_startPosY - 15);
            Point karkas5 = new Point((int)_startPosX + 40, (int)_startPosY - 25);
            Point karkas6 = new Point((int)_startPosX + 85, (int)_startPosY - 25);
            Point[] karkas = { karkas1, karkas2, karkas3, karkas4 };
            g.FillPolygon(white, karkas);

            //крыша 1 палубы
            Brush red = new SolidBrush(Color.Red);
            Point[] roof = { karkas2, karkas5, karkas6, karkas3 };
            g.FillPolygon(red, roof);
            g.DrawPolygon(pen, karkas);

            //Окна
            g.DrawLine(pen, _startPosX + 52, _startPosY - 25, _startPosX + 55, _startPosY - 16);
            g.DrawLine(pen, _startPosX + 70, _startPosY - 25, _startPosX + 75, _startPosY - 16);
            g.DrawLine(pen, _startPosX + 73, _startPosY - 25, _startPosX + 78, _startPosY - 16);
            g.DrawLine(pen, _startPosX + 82, _startPosY - 25, _startPosX + 97, _startPosY - 15);

            Point window1 = new Point((int)_startPosX + 54, (int)_startPosY - 25);
            Point window2 = new Point((int)_startPosX + 57, (int)_startPosY - 15);
            Point window3 = new Point((int)_startPosX + 76, (int)_startPosY - 15);
            Point window4 = new Point((int)_startPosX + 71, (int)_startPosY - 25);
            Point[] windows1 = { window1, window2, window3, window4 };
            g.FillPolygon(brBlack, windows1);

            Point window5 = new Point((int)_startPosX + 74, (int)_startPosY - 25);
            Point window6 = new Point((int)_startPosX + 79, (int)_startPosY - 15);
            Point window7 = new Point((int)_startPosX + 96, (int)_startPosY - 15);
            Point window8 = new Point((int)_startPosX + 82, (int)_startPosY - 25);
            Point[] windows2 = { window5, window6, window7, window8 };
            g.FillPolygon(brBlack, windows2);

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
    }
}