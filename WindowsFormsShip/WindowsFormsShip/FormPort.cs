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
        /// <summary>
        /// Объект от класса многоуровневого порта
        /// </summary>
        MultiLevelPort parking;
        /// <summary>
        /// Количество уровней-парковок
        /// </summary>
        private const int countLevel = 5;
        public FormPort()
        {
            InitializeComponent();
            parking = new MultiLevelPort(countLevel, pictureBoxPort.Width,
           pictureBoxPort.Height);
            //заполнение listBox
            for (int i = 0; i < countLevel; i++)
            {
                listBox1.Items.Add("Уровень " + (i + 1));
            }
            listBox1.SelectedIndex = 0;
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            if (listBox1.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункт
             // не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу
             // listBox)
                Bitmap bmp = new Bitmap(pictureBoxPort.Width,
               pictureBoxPort.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBox1.SelectedIndex].Draw(gr);
                pictureBoxPort.Image = bmp;
            }
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
        /// Обработка нажатия кнопки "Пришвартовать лодку"
        private void buttonLocateBoat_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var ship = new Ship(100, 1000, dialog.Color);
                    int place = parking[listBox1.SelectedIndex] + ship;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }
        }
        /// Обработка нажатия кнопки "Пришвартовать катер"
        private void buttonLocateShip_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var ship = new SuperShip(100, 1000, dialog.Color,
                       dialogDop.Color, true, true, 2);
                        int place = parking[listBox1.SelectedIndex] + ship;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }
                }
            }
        }

        /// Обработка нажатия кнопки "Забрать"
        private void buttonGetShip_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                if (maskedTextBox1.Text != "")
                {
                    var ship = parking[listBox1.SelectedIndex] -
                   Convert.ToInt32(maskedTextBox1.Text);
                    if (ship != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTake.Width,
                       pictureBoxTake.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        ship.SetPosition(15, 55, pictureBoxTake.Width,
                       pictureBoxTake.Height);
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
        }
    }
}