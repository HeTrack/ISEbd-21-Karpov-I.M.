using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShip
{//InvalidOperationException — выбрасывается когда состояние объекта является неподходящим для нормального выполнения метода
    public class ParkingOccupiedPlaceException : InvalidOperationException
    {
        public ParkingOccupiedPlaceException(int i) : base("На месте " + i + " уже стоит автомобиль")
        {
            { }
        }
    }
}