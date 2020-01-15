using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShip
{
   public class ParkingOverflowException: Exception
    {
        public ParkingOverflowException(): base("В порту нет свободных мест")
        { }
    }
}
