using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShip
{
   public class Port<T,N> where T:class, IShip where N:class,IMotors
    {
        /// <summary>
        /// Массив объектов, которые храним
        /// </summary>
        private T[] _places;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int PictureWidth { get; set; }
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int PictureHeight { get; set; }
 /// <summary>
 /// Размер парковочного места в порту (ширина)
 /// </summary>
 private const int _placeSizeWidth = 180;
        /// <summary>
        /// Размер парковочного места в порту (высота)
        /// </summary>
        private const int _placeSizeHeight = 70;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="sizes">Количество мест на парковке</param>
        /// <param name="pictureWidth">Рамзер парковки - ширина</param>
        /// <param name="pictureHeight">Рамзер парковки - высота</param>
        public Port(int sizes, int pictureWidth, int pictureHeight)
        {
            _places = new T[sizes];
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i] = null;
            }
        }
        /// <summary>
        /// Перегрузка оператора сложения
        /// Логика действия: в порт добавляется лодка
        /// </summary>
        /// <param name="p">Парковка</param>
        /// <param name="ship">Добавляемая лодка</param>
        /// <returns></returns>
        public static int operator +(Port<T,N> p, T ship)
        {
            for (int i = 0; i < p._places.Length; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p._places[i] = ship;
                    p._places[i].SetPosition(5 + i / 5 * _placeSizeWidth + 15,
                     i % 5 * _placeSizeHeight + 55, p.PictureWidth,
                    p.PictureHeight);
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// Перегрузка оператора вычитания
        /// Логика действия: с парковки забираем судно
        /// </summary>
        /// <param name="p">Парковка</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь
 /// <returns></returns>
        public static T operator -(Port<T,N> p, int index)
        {
            if (index < 0 || index > p._places.Length)
            {
                return null;
            }

            if (!p.CheckFreePlace(index))
            {
                T ship = p._places[index];
                p._places[index] = null;
                return ship;
            }
            return null;
        }

        //перешвартоваться
        public static int operator +(Port<T, N> p, int size)
        {
            int freeplace = 15;
            for (int i = 0; i < p._places.Length; i++)
            {
                if (!p.CheckFreePlace(i))
                {
                  if(freeplace!=15)
                    if (p.CheckFreePlace(freeplace))
                    {
                        p._places[freeplace] = p._places[i];
                        p._places[freeplace].SetPosition(5 + freeplace / 5 * _placeSizeWidth + 15,
                        freeplace % 5 * _placeSizeHeight + 55, p.PictureWidth,
                       p.PictureHeight);
                        p._places[i] = null;
                         i = freeplace ;
                            freeplace = 15;
                    }
                }
                else
                    if(i <= freeplace)
                    freeplace = i;
            }
            return 1;
        }

        //очистка порта
        public static int operator -(Port<T, N> p, string size)
        {
            for (int i = 0; i < Convert.ToInt32(size); i++)
            {
                p._places[i] = null;
            }
            return 1;
        }


        /// <summary>
        /// Метод проверки заполнености парковочного места (ячейки массива)
        /// </summary>
        /// <param name="index">Номер парковочного места (порядковый номер в

        /// <returns></returns>
        private bool CheckFreePlace(int index)
        {
            return _places[index] == null;
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            { 
                //если место не пустое
                if (!CheckFreePlace(i))
                {                  
                    _places[i].DrawShip(g);
                }
            }
        }
        /// <summary>
        /// Метод отрисовки разметки парковочных мест
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            //границы праковки
            g.DrawRectangle(pen, 0, 0, (_places.Length / 5) * _placeSizeWidth, 480);
            for (int i = 0; i < _places.Length / 5; i++)
            {//отрисовываем, по 5 мест на линии
                for (int j = 0; j < 6; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,
                    i * _placeSizeWidth + 110, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400);
            }
        }
    }
}