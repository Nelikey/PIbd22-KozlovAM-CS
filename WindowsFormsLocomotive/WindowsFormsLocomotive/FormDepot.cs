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
		/// Объект от класса-коллекции парковок
		/// </summary>
		private readonly DepotCollection depotCollection;

		/// <summary>
		/// Конструктор
		/// </summary>
		public FormDepot()
		{
			InitializeComponent();
			depotCollection = new DepotCollection(pictureBoxDepot.Width, pictureBoxDepot.Height);
		}

		/// <summary>
		/// Заполнение listBoxLevels
		/// </summary>
		private void ReloadLevels()
		{
			int index = listBoxDepots.SelectedIndex;
			listBoxDepots.Items.Clear();
			for (int i = 0; i < depotCollection.Keys.Count; i++)
			{
				listBoxDepots.Items.Add(depotCollection.Keys[i]);
			}
			if (listBoxDepots.Items.Count > 0 && (index == -1 || index >=
		   listBoxDepots.Items.Count))
			{
				listBoxDepots.SelectedIndex = 0;
			}
			else if (listBoxDepots.Items.Count > 0 && index > -1 && index <
		   listBoxDepots.Items.Count)
			{
				listBoxDepots.SelectedIndex = index;
			}
		}

		/// <summary>
		/// Метод отрисовки депо
		/// </summary>
		private void Draw()
		{
			if (listBoxDepots.SelectedIndex > -1)
			{
			//если выбран один из пуктов в listBox (при старте программы ни один пункт
			 //не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу
			 //listBox)
				Bitmap bmp = new Bitmap(pictureBoxDepot.Width, pictureBoxDepot.Height);
				Graphics gr = Graphics.FromImage(bmp);
				depotCollection[listBoxDepots.SelectedItem.ToString()].Draw(gr);
				pictureBoxDepot.Image = bmp;
			}
		}

		/// <summary>
		/// Обработка нажатия кнопки "Добавить парковку"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonAddParking_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
			{
				MessageBox.Show("Введите название депо", "Ошибка",
			   MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			depotCollection.AddDepot(textBoxNewLevelName.Text);
			ReloadLevels();
		}

		/// <summary>
		/// Обработка нажатия кнопки "Удалить парковку"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonDelParking_Click(object sender, EventArgs e)
		{
			if (listBoxDepots.SelectedIndex > -1)
			{
				if (MessageBox.Show($"Удалить депо { listBoxDepots.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
		   MessageBoxIcon.Question) == DialogResult.Yes)
				{
					depotCollection.DelDepot(listBoxDepots.SelectedItem.ToString());
					ReloadLevels();
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
			if (listBoxDepots.SelectedIndex > -1 && maskedTextBox.Text != "")
			{
				var loco = depotCollection[listBoxDepots.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
				if (loco != null)
				{
					FormLoco form = new FormLoco();
					form.SetLoco(loco);
					form.ShowDialog();
				}
				Draw();
			}
		}

		/// <summary>
		/// Метод обработки выбора элемента на listBoxLevels
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void listBoxDepots_SelectedIndexChanged(object sender, EventArgs e)
        {
			Draw();
		}

		/// <summary>
		/// Обработка нажатия кнопки "Добавить автомобиль"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonSetLoco_Click(object sender, EventArgs e)
		{
			var formLocoConfig = new FormLocoConfig();
			formLocoConfig.AddEvent(AddLoco);
			formLocoConfig.Show();
		}

		/// <summary>
		/// Метод добавления машины
		/// </summary>
		/// <param name="car"></param>
		private void AddLoco(Vehicle loco)
		{
			if (loco != null && listBoxDepots.SelectedIndex > -1)
			{
				if ((depotCollection[listBoxDepots.SelectedItem.ToString()]) + loco)
				{
					Draw();
				}
				else
				{
					MessageBox.Show("Машину не удалось поставить");
				}
			}
		}

        
    }
}
