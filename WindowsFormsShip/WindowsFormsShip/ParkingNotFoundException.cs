using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShip
{
    // или ObjectDisposedException - выбрасывается при попытке вызвать метод объекта, который уже был уничтожен (disposed)
    //ArgumentNullException — производный от ArgumentException класс, выбрасывается если один из аргументов функции неожиданно равен null.
    public class ParkingNotFoundException: ArgumentNullException
    {
        public ParkingNotFoundException(int i):base("Не найден автомобиль по месту " + i)
        { }
    }
}
