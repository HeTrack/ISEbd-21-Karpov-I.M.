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
        Port<IShip,IMotors> parking;
        public FormPort()
        {
            InitializeComponent();
            parking = new Port<IShip, IMotors>(15, pictureBoxPort.Width, pictureBoxPort.Height);
            Draw();
        }


        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxPort.Width, pictureBoxPort.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxPort.Image = bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var car = new Ship(100, 1000, dialog.Color);
                int place = parking + car;
                Draw();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var car = new SuperShip(100, 1000, dialog.Color, dialogDop.Color, true, true, CountMotors.Two,Color.White);
                    int place = parking + car;
                    Draw();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                var car = parking - Convert.ToInt32(maskedTextBox1.Text);
                if (car != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTake.Width, pictureBoxTake.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    car.SetPosition(18, 55, pictureBoxTake.Width,  pictureBoxTake.Height);
                    car.DrawShip(gr);
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

        private void button4_Click(object sender, EventArgs e)
        {
            int place = parking + 15;
            Draw();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int place = parking - "15";
            Draw();
        }
    }
}
