using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLocomotive
{
	/// <summary>
	/// Класс-коллекция депо
	/// </summary>
	class DepotCollection
	{
		/// <summary>
		/// Словарь (хранилище) с парковками
		/// </summary>
		readonly Dictionary<string, Depot<Vehicle>> depotStages;

		/// <summary>
		/// Возвращение списка названий праковок
		/// </summary>
		public List<string> Keys => depotStages.Keys.ToList();

        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;

        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public DepotCollection(int pictureWidth, int pictureHeight)
        {
            depotStages = new Dictionary<string, Depot<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        /// <summary>
        /// Добавление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void AddDepot(string name)
        {
            if (!depotStages.ContainsKey(name))
            {
                depotStages.Add(name, new Depot<Vehicle>(pictureWidth, pictureHeight));
            }
        }

        /// <summary>
        /// Удаление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void DelDepot(string name)
        {
            if (depotStages.ContainsKey(name))
            {
                depotStages.Remove(name);
            }
        }

        /// <summary>
        /// Доступ к парковке
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Depot<Vehicle> this[string ind] {
            get
            {
                if (depotStages.ContainsKey(ind))
                {
                    return depotStages[ind];
                }
                else { return null; }
            }
            set
            {
                AddDepot(ind);
            }
        }
    }
}
