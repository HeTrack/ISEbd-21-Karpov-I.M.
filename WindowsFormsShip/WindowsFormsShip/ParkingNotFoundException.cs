using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShip
{
    public class ParkingNotFoundException : ArgumentNullException
    {
        public ParkingNotFoundException(int i):base("Не найдено судно по месту " + i)
        { }
    }
}
