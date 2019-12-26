using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShip
{
    class MultiLevelPort
    {
        /// <summary>
        /// Список с уровнями порта
        /// </summary>
        List<Port<IShip>> parkingStages;
        /// <summary>
        /// Сколько мест на каждом уровне
        /// </summary>
        private const int countPlaces = 20;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="countStages">Количество уровенй в порту</param>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public MultiLevelPort(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Port<IShip>>();
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Port<IShip>(countPlaces, pictureWidth, pictureHeight));
            }
        }
        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Port<IShip> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
        public IShip this[int level, int key]
        {
            get
            {
                if (level > -1 && level < parkingStages.Count)
                {
                    return parkingStages[level].GetShipByKey(key);
                }
                return null;
            }
        }
    }
}
