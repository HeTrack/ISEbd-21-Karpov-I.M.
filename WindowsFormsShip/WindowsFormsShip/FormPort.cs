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
        /// Объект от класса многоуровневого порта
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
                listBoxlevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxlevels.SelectedIndex = 0;
        }
        /// <summary>
        /// Метод отрисовки порта
        /// </summary>
        private void Draw()
        {
            if (listBoxlevels.SelectedIndex > -1)
            {
               //если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
                Bitmap bmp = new Bitmap(pictureBoxPort.Width,
               pictureBoxPort.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxlevels.SelectedIndex].Draw(gr);
                pictureBoxPort.Image = bmp;
            }
        }
       
        private void AddShip(IShip ship)
        {
            if (ship != null && listBoxlevels.SelectedIndex > -1)
            {
                try
                {
                    int place = parking[listBoxlevels.SelectedIndex] + ship;
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
            if (saveFilePort.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    parking.SaveData(saveFilePort.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFilePort.FileName);
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
            if (openFilePort.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    parking.LoadData(openFilePort.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFilePort.FileName);
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

        private void listBox1levels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGetShip_Click(object sender, EventArgs e)
        {
            if (listBoxlevels.SelectedIndex > -1)
            {
                if (maskedTextBoxSpot.Text != "")
                {
                    try
                    {
                        var ship = parking[listBoxlevels.SelectedIndex] - Convert.ToInt32(maskedTextBoxSpot.Text);
                        Bitmap bmp = new Bitmap(pictureBoxTake.Width,
                       pictureBoxTake.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        ship.SetPosition(15, 55, pictureBoxTake.Width,
                       pictureBoxTake.Height);
                        ship.DrawShip(gr);
                        pictureBoxTake.Image = bmp;
                        logger.Info("Изъято судно" + ship.ToString() + " с места " + maskedTextBoxSpot.Text);
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
    }
}
 

