using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShip
{
    public class Ship: WaterVehicle
    {
        /// Ширина отрисовки катера
        /// </summary>
        protected const int shipWidth = 150;
        /// <summary>
        /// Ширина отрисовки катера
        /// </summary>
        protected const int shipHeight = 10;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        /// <summary>
        /// Конструктор    
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес катера</param>
        /// <param name="bottomColor">Основной цвет - цвет ватерлинии</param>      
        /// <summary>
        public Ship(int maxSpeed, float weight, Color bottomColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = bottomColor;
        }
        /// <summary>
        /// Изменение направления перемещения      
        /// <param name="direction">Направление</param>
        /// </summary>
        public override void MoveTransport(Direction direction)
        {
            int k = 30;
            float step = MaxSpeed * 100 / Weight;
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
                    // if (SecondBoard)
                    //    k = 48;
                    if (_startPosY - k - step > 0)
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
        /// <summary>
        /// Отрисовка катера
        /// </summary>
        /// <param name="g"></param>
        public override void DrawShip(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush white = new SolidBrush(Color.White);
            Brush bottom = new SolidBrush(MainColor);
            Brush brBlack = new SolidBrush(Color.Black);
            Brush hull = new SolidBrush(Color.LightGray);

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
        }
    }
}