using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShip
{
   public class Port<T> where T:class, IShip
    {
        /// <summary>
        /// Массив объектов, которые храним
        /// </summary>
        private Dictionary<int, T> _places;
        /// <summary>
        /// Максимальное количество мест в порту
        /// </summary>
        private int _maxCount;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int PictureWidth { get; set; }
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int PictureHeight { get; set; }
        /// <summary>
        /// Размер парковочного места (ширина)
        /// </summary>
        private const int _placeSizeWidth = 180;
        /// <summary>
        /// Размер парковочного места (высота)
        /// </summary>
        private const int _placeSizeHeight = 80;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="sizes">Количество мест в порту</param>
        /// <param name="pictureWidth">Рамзер порта - ширина</param>
        /// <param name="pictureHeight">Рамзер порта - высота</param>
        public Port(int sizes, int pictureWidth, int pictureHeight)
        {
            _maxCount = sizes;
            _places = new Dictionary<int, T>();
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
        }
        /// <summary>
        /// Перегрузка оператора сложения
        /// Логика действия: в порт добавляется судно
        /// </summary>
        /// <param name="p">Порт</param>
        /// <param name="ship">Добавляемое судно</param>
        /// <returns></returns>
        public static int operator +(Port<T> p, T ship)
        {
            if (p._places.Count == p._maxCount)
            {
                return -1;
            }
            for (int i = 0; i < p._maxCount; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p._places.Add(i, ship);
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
        /// Логика действия: с порта забираем судно
        /// </summary>
        /// <param name="p">Порт</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь     
        /// <returns></returns>
             public static T operator -(Port<T> p, int index)
        {
            if (!p.CheckFreePlace(index))
            {
                T ship = p._places[index];
                p._places.Remove(index);
                return ship;
            }
            return null;
        }
        /// <summary>
        /// Метод проверки заполнености парковочного места (ячейки массива)
        /// </summary>
        /// <param name="index">Номер парковочного места (порядковый номер в
        /// <returns></returns>
            private bool CheckFreePlace(int index)
        {
            return !_places.ContainsKey(index);
        }
        public T GetShipByKey(int key)
        {
            return _places.ContainsKey(key) ? _places[key] : null;
        }
        /// <summary>
        /// Метод отрисовки порта
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            var keys = _places.Keys.ToList();
            for (int i = 0; i < keys.Count; i++)
            {
                _places[keys[i]].DrawShip(g);
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
            g.DrawRectangle(pen, 0, 0, (_maxCount / 5) * _placeSizeWidth, 480);
            for (int i = 0; i < _maxCount / 5; i++)
            {//отрисовываем, по 5 мест на линии
                for (int j = 0; j < 6; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,
                    i * _placeSizeWidth + 110, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400);
            }
        }
        public T this[int ind]
        {
            get
            {
                if (_places.ContainsKey(ind))
                {
                    return _places[ind];
                }
                return null;
            }
            set
            {
                if (CheckFreePlace(ind))
                {
                    _places.Add(ind, value);
                    _places[ind].SetPosition(5 + ind / 5 * _placeSizeWidth + 15, ind % 5
                    * _placeSizeHeight + 55, PictureWidth, PictureHeight);
                }
            }
        }
    }
}
