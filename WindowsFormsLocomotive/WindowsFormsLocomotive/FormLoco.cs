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
    public partial class FormLoco : Form
    {
        public FormLoco()
        {
            InitializeComponent();
        }

        private Locomotive loco;

        /// <summary>
        /// Метод отрисовки машины
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxLocos.Width, pictureBoxLocos.Height);
            Graphics gr = Graphics.FromImage(bmp);
            loco.DrawTransport(gr);
            pictureBoxLocos.Image = bmp;
        }

        /// <summary>
        /// Обработка нажатия кнопки "Создать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            loco = new Locomotive();
            loco.Init(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Green,
                Color.Yellow, true, true, true, true);
            loco.SetPosition(rnd.Next(10, 100),
                rnd.Next(10, 100), pictureBoxLocos.Width, pictureBoxLocos.Height);
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    loco.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    loco.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    loco.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    loco.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

    }
}
