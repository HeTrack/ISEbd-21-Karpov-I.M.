using NLog;
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
        /// Объект от класса многоуровневой парковки
        /// </summary>
        MultiLevelPort parking;
        FormShipConfig form;
        /// <summary>
        /// Количество уровней-парковок
        /// </summary>
        private const int countLevel = 5;
        private Logger logger;
        private Logger error;
        public FormPort()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
            error = LogManager.GetCurrentClassLogger();
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
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Обработка нажатия кнопки "Припарковать гоночный автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var car = new Ship(100, 1000, dialog.Color);
                    int place = parking[listBox1.SelectedIndex] + car;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var car = new SuperShip(100, 1000, dialog.Color,
                       dialogDop.Color, true, true, 2);
                        int place = parking[listBox1.SelectedIndex] + car;
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                if (maskedTextBox1.Text != "")
                {
                    try
                    {
                        var car = parking[listBox1.SelectedIndex] -
                       Convert.ToInt32(maskedTextBox1.Text);

                        Bitmap bmp = new Bitmap(pictureBoxTake.Width,
                       pictureBoxTake.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        car.SetPosition(15, 55, pictureBoxTake.Width,
                       pictureBoxTake.Height);
                        car.DrawShip(gr);
                        pictureBoxTake.Image = bmp;
                        logger.Info("Изъято судно" + car.ToString() + " с места " + maskedTextBox1.Text);
                        Draw();
                    }
                    catch (ParkingNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Bitmap bmp = new Bitmap(pictureBoxTake.Width,
                       pictureBoxTake.Height);
                        pictureBoxTake.Image = bmp;
                        error.Error(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        error.Error(ex.Message);
                    }
                    
                }
            }
        }

        private void AddShip(IShip ship)
        {
            if (ship != null && listBox1.SelectedIndex > -1)
            {
                try
                {
                    int place = parking[listBox1.SelectedIndex] + ship;
                    logger.Info("Добавлено судно " + ship.ToString() + "на место " + place);
                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error.Error(ex.Message);
                }
                catch (ParkingAlreadyHaveException ex)
                {                 
                 MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error.Error(ex.Message);
                }
            }
        }

        private void buttonSetShip_Click(object sender, EventArgs e)
        {
            form = new FormShipConfig();
            form.AddEvent(AddShip);
            form.Show();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    parking.SaveData(saveFileDialog1.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   error.Error(ex.Message);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    parking.LoadData(openFileDialog1.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog1.FileName);
                }
                catch (ParkingOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error.Error(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error.Error(ex.Message);
                }
                Draw();
            }
        }

        private void buttonForSort_Click(object sender, EventArgs e)
        {
            parking.Sort();
            Draw();
            logger.Info("Сортировка уровней");
        }
    }
}
 

