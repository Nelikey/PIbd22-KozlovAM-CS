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
	public partial class FormDepot : Form
	{
		/// <summary>
		/// Объект от класса-депо
		/// </summary>
		private readonly Depot<BaseLocomotive> depot;

		/// <summary>
		/// Конструктор
		/// </summary>
		public FormDepot()
		{
			InitializeComponent();
			depot = new Depot<BaseLocomotive>(pictureBoxDepot.Width,
				pictureBoxDepot.Height);
			Draw();
		}

		/// <summary>
		/// Метод отрисовки депо
		/// </summary>
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxDepot.Width, pictureBoxDepot.Height);
			Graphics gr = Graphics.FromImage(bmp);
			depot.Draw(gr);
			pictureBoxDepot.Image = bmp;
		}

		/// <summary>
		/// Обработка нажатия кнопки "Поставить локомотив в депо"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonSetBaseLoco_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				var car = new BaseLocomotive(100, 1000, dialog.Color);
				if (depot + car != -1)
				{
					Draw();
				}
				else
				{
					MessageBox.Show("Парковка переполнена");
				}
			}
		}
		/// <summary>
		/// Обработка нажатия кнопки "Поставить тепловоз в депо"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonSetLoco_Click(object sender, EventArgs e)
		{
				ColorDialog dialog = new ColorDialog();
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					ColorDialog dialogDop = new ColorDialog();
					if (dialogDop.ShowDialog() == DialogResult.OK)
					{
						var car = new Locomotive(100, 1000, dialog.Color, dialogDop.Color,
					   true, true, true, true);
						if (depot + car != -1)
						{
							Draw();
						}
						else
						{
							MessageBox.Show("Парковка переполнена");
						}
					}
				}
			}

		/// <summary>
		/// Обработка нажатия кнопки "Забрать"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonTakeLoco_Click(object sender, EventArgs e)
		{
			if (maskedTextBox.Text != "")
			{
				var loco = depot - Convert.ToInt32(maskedTextBox.Text);
				if (loco != null)
				{
					FormLoco form = new FormLoco();
					form.SetLoco(loco);
					form.ShowDialog();
				}
				Draw();
			}

		}
	}
}
