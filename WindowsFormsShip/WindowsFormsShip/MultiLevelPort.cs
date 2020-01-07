using System;
using System.Collections.Generic;
using System.IO;
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
        private int pictureWidth;
        private int pictureHeight;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="countStages">Количество уровеней в порту</param>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public MultiLevelPort(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Port<IShip>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
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

        //сохранение
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("CountLevels:" + parkingStages.Count);
                foreach (var level in parkingStages)
                {
                    sw.WriteLine("Level");
                    foreach (IShip ship in level)
                        {
                            if (ship.GetType().Name == "Ship")
                            {
                                sw.WriteLine(level.GetKey + ":Ship:" + ship);
                            }
                            if (ship.GetType().Name == "SuperShip")
                            {
                                sw.WriteLine(level.GetKey + ":SuperShip:" + ship);
                            }
                        }
                    }
                }
            }
            
        //выгрузить
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            int counter = -1;
            IShip ship = null;
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();
                int count;
                bool isValid = line.Contains("CountLevels");
                if (isValid)
                {
                    count = Convert.ToInt32(line.Split(':')[1]);
                    if (parkingStages != null)
                    {
                        parkingStages.Clear();
                    }
                    parkingStages = new List<Port<IShip>>(count);
                }
                else
                {
                    throw new Exception("Неверный формат файла");                   
                }
                while ((line = sr.ReadLine()) != null)
                {
                    if (line == "Level")
                    {
                        counter++;
                        parkingStages.Add(new Port<IShip>(countPlaces, pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    string[] splitLine = line.Split(':');
                    if (splitLine.Length > 2)
                    {
                        if (splitLine[1] == "Ship")
                        {
                            ship = new Ship(splitLine[2]);
                        }
                        else
                        {
                            ship = new SuperShip(splitLine[2]);
                        }
                        parkingStages[counter][Convert.ToInt32(splitLine[0])] = ship;
                    }
                }
                return true;
            }
        }

        public void Sort()
        {
            parkingStages.Sort();
        }
    }
}
