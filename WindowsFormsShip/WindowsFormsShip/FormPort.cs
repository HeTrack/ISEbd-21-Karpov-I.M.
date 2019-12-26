using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsShip
{
    public partial class FormPort : Form
    {
        Port<IShip, IMotors> parking;
        public FormPort()
        {
            InitializeComponent();
            parking = new Port<IShip, IMotors>(15, pictureBoxPort.Width, pictureBoxPort.Height);
            Draw();
        }
        /// <summary>
        /// Метод отрисовки порта
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxPort.Width, pictureBoxPort.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxPort.Image = bmp;
        }

        private void buttonLocateBoat_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var ship = new Ship(100, 1000, dialog.Color);
                int place = parking + ship;
                Draw();
            }
        }

        private void buttonLocateShip_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var ship = new SuperShip(100, 1000, dialog.Color, dialogDop.Color, true, true, CountMotors.Two, Color.White);
                    int place = parking + ship;
                    Draw();
                }
            }
        }

        private void buttonGetShip_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxSpot.Text != "")
            {
                var ship = parking - Convert.ToInt32(maskedTextBoxSpot.Text);
                if (ship != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTake.Width, pictureBoxTake.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    ship.SetPosition(18, 55, pictureBoxTake.Width, pictureBoxTake.Height);
                    ship.DrawShip(gr);
                    pictureBoxTake.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTake.Width,
                   pictureBoxTake.Height);
                    pictureBoxTake.Image = bmp;
                }
                Draw();
            }
        }

        private void buttonNewPorting_Click(object sender, EventArgs e)
        {
            int place = parking + 15;
            Draw();
        }

        private void buttonCleanPort_Click(object sender, EventArgs e)
        {
            int place = parking - "15";
            Draw();
        }
    }
}
