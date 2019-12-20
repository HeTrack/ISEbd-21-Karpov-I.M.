using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShip
{// производный от ArgumentException класс, выбрасывается когда аргумент функции имеет слишком большое или слишком маленькое значение для данного типа
    // или  IndexOutOfRangeException - Выбрасывается во время запуска при доступе в элемент массива с неправильным индексом.
    public class ParkingOverflowException : ArgumentOutOfRangeException
    {
        public ParkingOverflowException(): base("На парковке нет свободных мест")
        { }
    }
}
