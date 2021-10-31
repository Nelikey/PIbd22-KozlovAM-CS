using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLocomotive
{
    public partial class FormLocoConfig : Form
    {
        /// <summary>
        /// Переменная-выбранная машина
        /// </summary>
        Vehicle loco = null;

        /// <summary>
        /// Событие
        /// </summary>
        private event Action<Vehicle> eventAddLoco;


        public FormLocoConfig()
        {
            InitializeComponent();

            panelColorBlack.MouseDown += panelColor_MouseDown;
            panelColorBlue.MouseDown += panelColor_MouseDown;
            panelColorGray.MouseDown += panelColor_MouseDown;
            panelColorGreen.MouseDown += panelColor_MouseDown;
            panelColorFuchsia.MouseDown += panelColor_MouseDown;
            panelColorRed.MouseDown += panelColor_MouseDown;
            panelColorWhite.MouseDown += panelColor_MouseDown;
            panelColorYellow.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        /// <summary>
        /// Отрисовать машину
        /// </summary>
        private void DrawLoco()
        {
            if (loco != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxLoco.Width, pictureBoxLoco.Height);
                Graphics gr = Graphics.FromImage(bmp);
                loco.SetPosition(5, 5, pictureBoxLoco.Width, pictureBoxLoco.Height);
                loco.DrawTransport(gr);
                pictureBoxLoco.Image = bmp;
            }
        }

        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev"></param>
        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddLoco == null)
            {
                eventAddLoco = new Action<Vehicle>(ev);
            }
            else
            {
                eventAddLoco += ev;
            }
        }


        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseLocomotive_MouseDown(object sender, MouseEventArgs e)
        {
            labelBaseLocomotive.DoDragDrop(labelBaseLocomotive.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void labelLocomotive_MouseDown(object sender, MouseEventArgs e)
        {
            labelLocomotive.DoDragDrop(labelLocomotive.Text, DragDropEffects.Move |
                DragDropEffects.Copy);
        }

        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelLoco_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelLoco_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный":
                    loco = new BaseLocomotive(Convert.ToInt32(numericUpDownMaxSpeed.Value),
                        Convert.ToInt32(numericUpDownMaxSpeed.Value), Color.White);
                    break;
                case "Тепловоз":
                    loco = new Locomotive(Convert.ToInt32(numericUpDownMaxSpeed.Value),
                        Convert.ToInt32(numericUpDownMaxSpeed.Value), Color.White, Color.Black,
                        checkBoxSmokestack.Checked, checkBoxFrontLight.Checked,
                        checkBoxBackLight.Checked, checkBoxSideLine.Checked);
                    break;
            }
            DrawLoco();
        }

        
        

        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.DoDragDrop(panel.BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            Color data = (Color)e.Data.GetData(typeof(Color));
            loco?.SetMainColor(data);
            DrawLoco();
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            Color data = (Color)e.Data.GetData(typeof(Color));
            (loco as Locomotive)?.SetDopColor(data);
            DrawLoco();
        }

        /// <summary>
        /// Добавление машины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddLoco?.Invoke(loco);
            Close();
        }

        private void checkBoxSmokestack_Click(object sender, EventArgs e)
        {
            if (loco != null && loco is Locomotive)
            {
                if (!checkBoxSmokestack.Checked)
                {
                    Color mainColor = loco.MainColor;
                    Color dopColor = (loco as Locomotive).DopColor;
                    bool frontLight = (loco as Locomotive).FrontLight;
                    bool backLight = (loco as Locomotive).BackLight;
                    bool sideline = (loco as Locomotive).SideLine;
                    loco = new Locomotive(Convert.ToInt32(numericUpDownMaxSpeed.Value),
                        Convert.ToInt32(numericUpDownWeight.Value),
                        mainColor, dopColor, false, frontLight, backLight, sideline);
                }
                else
                {
                    Color mainColor = loco.MainColor;
                    Color dopColor = (loco as Locomotive).DopColor;
                    bool frontLight = (loco as Locomotive).FrontLight;
                    bool backLight = (loco as Locomotive).BackLight;
                    bool sideline = (loco as Locomotive).SideLine;
                    loco = new Locomotive(Convert.ToInt32(numericUpDownMaxSpeed.Value),
                        Convert.ToInt32(numericUpDownWeight.Value),
                        mainColor, dopColor, true, frontLight, backLight, sideline);
                }
                DrawLoco();
            }
        }

        private void checkBoxFrontLight_Click(object sender, EventArgs e)
        {
            if (loco != null && loco is Locomotive)
            {
                if (!checkBoxFrontLight.Checked)
                {
                    Color mainColor = loco.MainColor;
                    Color dopColor = (loco as Locomotive).DopColor;
                    bool smokestack = (loco as Locomotive).Smokestack;
                    bool backLight = (loco as Locomotive).BackLight;
                    bool sideline = (loco as Locomotive).SideLine;
                    loco = new Locomotive(Convert.ToInt32(numericUpDownMaxSpeed.Value),
                        Convert.ToInt32(numericUpDownWeight.Value),
                        mainColor, dopColor, smokestack, false, backLight, sideline);
                }
                else
                {
                    Color mainColor = loco.MainColor;
                    Color dopColor = (loco as Locomotive).DopColor;
                    bool smokestack = (loco as Locomotive).Smokestack;
                    bool backLight = (loco as Locomotive).BackLight;
                    bool sideline = (loco as Locomotive).SideLine;
                    loco = new Locomotive(Convert.ToInt32(numericUpDownMaxSpeed.Value),
                        Convert.ToInt32(numericUpDownWeight.Value),
                        mainColor, dopColor, smokestack, true, backLight, sideline);
                }
                DrawLoco();
            }
        }

        private void checkBoxBackLight_Click(object sender, EventArgs e)
        {
            if (loco != null && loco is Locomotive)
            {
                if (!checkBoxBackLight.Checked)
                {
                    Color mainColor = loco.MainColor;
                    Color dopColor = (loco as Locomotive).DopColor;
                    bool smokestack = (loco as Locomotive).Smokestack;
                    bool frontLight = (loco as Locomotive).FrontLight;
                    bool sideline = (loco as Locomotive).SideLine;
                    loco = new Locomotive(Convert.ToInt32(numericUpDownMaxSpeed.Value),
                        Convert.ToInt32(numericUpDownWeight.Value),
                        mainColor, dopColor, smokestack, frontLight, false, sideline);
                }
                else
                {
                    Color mainColor = loco.MainColor;
                    Color dopColor = (loco as Locomotive).DopColor;
                    bool smokestack = (loco as Locomotive).Smokestack;
                    bool frontLight = (loco as Locomotive).FrontLight;
                    bool sideline = (loco as Locomotive).SideLine;
                    loco = new Locomotive(Convert.ToInt32(numericUpDownMaxSpeed.Value),
                        Convert.ToInt32(numericUpDownWeight.Value),
                        mainColor, dopColor, smokestack, frontLight, true, sideline);
                }
                DrawLoco();
            }
        }

        private void checkBoxSideLine_Click(object sender, EventArgs e)
        {
            if (loco != null && loco is Locomotive)
            {
                if (!checkBoxSideLine.Checked)
                {
                    Color mainColor = loco.MainColor;
                    Color dopColor = (loco as Locomotive).DopColor;
                    bool smokestack = (loco as Locomotive).Smokestack;
                    bool backLight = (loco as Locomotive).BackLight;
                    bool frontLight = (loco as Locomotive).FrontLight;
                    loco = new Locomotive(Convert.ToInt32(numericUpDownMaxSpeed.Value),
                        Convert.ToInt32(numericUpDownWeight.Value),
                        mainColor, dopColor, smokestack, frontLight, backLight, false);
                }
                else
                {
                    Color mainColor = loco.MainColor;
                    Color dopColor = (loco as Locomotive).DopColor;
                    bool smokestack = (loco as Locomotive).Smokestack;
                    bool backLight = (loco as Locomotive).BackLight;
                    bool frontLight = (loco as Locomotive).FrontLight;
                    loco = new Locomotive(Convert.ToInt32(numericUpDownMaxSpeed.Value),
                        Convert.ToInt32(numericUpDownWeight.Value),
                        mainColor, dopColor, smokestack, frontLight, backLight, true);
                }
                DrawLoco();
            }
        }
    }
}
