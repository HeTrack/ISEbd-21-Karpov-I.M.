using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShip
{
    interface IMotors
    {
        void DrawMotors(Graphics g, CountMotors countmotors, Color color);
    }
}
