using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

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
        /// Разделитель для записи информации в файл
        /// </summary>
        private readonly char separator = ':';

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

        /// <summary>
        /// Сохранение информации по автомобилям на парковках в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public void SaveData(string filename)
        {
            using (StreamWriter streamWriter = new StreamWriter(filename, false, System.Text.Encoding.Default))
            {
                streamWriter.WriteLine("DepotCollection");
                foreach (var level in depotStages)
                {
                    //Начинаем парковку
                    streamWriter.WriteLine($"Depot{separator}{level.Key}");
                    foreach (ITransport loco in level.Value)
                    {
                        //Записываем тип мшаины
                        if (loco.GetType().Name == "BaseLocomotive")
                        {
                            streamWriter.Write($"BaseLocomotive{separator}");
                        }
                        if (loco.GetType().Name == "Locomotive")
                        {
                            streamWriter.Write($"Locomotive{separator}");
                        }
                        //Записываемые параметры
                        streamWriter.WriteLine(loco);
                    }
                }
            }
        }

        /// <summary>
        /// Загрузка нформации по автомобилям на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new IOException("Файла по выбранному пути не существует: ");
            }
            using (StreamReader streamReader = new StreamReader(filename, System.Text.Encoding.Default))
            {
                if (!streamReader.ReadLine().Contains("DepotCollection"))
                {
                    throw new System.NullReferenceException("Выбранный файл не соответствует требованиям к загрузочному файлу: ");
                }
                //очищаем записи
                depotStages.Clear();

                Vehicle loco = null;
                string key = string.Empty;
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (line.Contains("Depot"))
                    {
                        key = line.Substring(6);
                        depotStages.Add(key, new Depot<Vehicle>(pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    if (line.Contains("BaseLocomotive"))
                    {
                        loco = new BaseLocomotive(line.Substring(15));
                    }
                    else if (line.Contains("Locomotive")){
                        loco = new Locomotive(line.Substring(11));
                    }
                    var result = depotStages[key] + loco;
                    if (!result)
                    {
                        throw new InvalidOperationException("Не удалось загрузить локомотив в депо");
                    }
                }
            }
        }
    }
}
