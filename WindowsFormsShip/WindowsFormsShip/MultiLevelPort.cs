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
        private int pictureWidth;
        private int pictureHeight;
        /// <summary>
        /// Конструктор   
        /// <param name="countStages">Количество уровенй порта</param>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        /// </summary>
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
        public bool SaveData(string filename)
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
                    for (int i = 0; i < countPlaces; i++)
                    {
                        var ship = level[i];
                        if (ship != null)
                        {
                            if (ship.GetType().Name == "Ship")
                            {
                                sw.WriteLine(i + ":Ship:" + ship);
                            }
                            if (ship.GetType().Name == "SuperShip")
                            {
                                sw.WriteLine(i + ":SuperShip:" + ship);
                            }
                        }
                    }
                }
            }
            return true;
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
                    return false;
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

        //сохранить уровень
        public bool Savelvl(int level, string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            if (level < 0 || level >= parkingStages.Count)
            {
                return false;
            }
            if (parkingStages[level] == null)
            {
                return false;
            }
            var lvl = parkingStages[level];
            using (StreamWriter sw = new StreamWriter(filename))
            {
                for (int i = 0; i < countPlaces; i++)
                {
                    var ship = lvl[i];
                    if (ship != null)
                    {
                        if (ship.GetType().Name == "Ship")
                        {
                            sw.WriteLine(i + ":Ship:" + ship);
                        }
                        if (ship.GetType().Name == "SuperShip")
                        {
                            sw.WriteLine(i + ":SuperShip:" + ship);
                        }
                    }
                }
            }
            return true;
        }


        //загрузить уровень
        public bool Loadlvl(int level, string filename)
        {
            if (level < 0 || level >= parkingStages.Count)
            {
                return false;
            }
            if (!File.Exists(filename) || parkingStages[level] == null)
            {
                return false;
            }
            parkingStages[level].ForClearlvl();
            IShip ship = null;
          
              
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
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
                        if (ship != null)
                        {
                            parkingStages[level][Convert.ToInt32(splitLine[0])] = ship;
                        }
                    }
                }
                return true;
            }
        }
    }
}
