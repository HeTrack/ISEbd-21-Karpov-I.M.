using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShip
{
    // или ObjectDisposedException
    public class ParkingNotFoundException: ArgumentNullException
    {
        public ParkingNotFoundException(int i):base("Не найден автомобиль по месту " + i)
        { }
    }
}
