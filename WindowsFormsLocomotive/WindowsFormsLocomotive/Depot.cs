using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsLocomotive
{
    /// <summary>
    /// Параметризованный класс для хранения набора объектов от интерфейса ITransport
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Depot<T> where T : class, ITransport
    {
        /// <summary>
        /// Массив объектов, которые храним
        /// </summary>
        private readonly T[] _places;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;
        /// <summary>
        /// Размер депо (ширина)
        /// </summary>
        private readonly int _placeSizeWidth = 210;
        /// <summary>
        /// Размер депо (высота)
        /// </summary>
        private readonly int _placeSizeHeight = 80;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="picWidth">Рамзер депо - ширина</param>
        /// <param name="picHeight">Рамзер депо - высота</param>
        public Depot(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }

        /// <summary>
        /// Перегрузка оператора сложения
        /// Логика действия: в депо добавляется локомотив
        /// </summary>
        /// <param name="d">Депо</param>
        /// <param name="loco">Добавляемый локомотив</param>
        /// <returns></returns>
        public static int operator +(Depot<T> d, T loco)
        {
                for (int i = 0; i < d._places.Length; i++)
                {
                    if (d._places[i] == null)
                    {
                        d._places[i] = loco;
                        return i;
                    }
                }
                return -1;
        }

        /// <summary>
        /// Перегрузка оператора вычитания
        /// Логика действия: с депо забираем локомотив
        /// </summary>
        /// <param name="d">Депо</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь объект</param>
        /// <returns></returns>
        public static T operator -(Depot<T> d, int index)
        {
            if (index >= 0 && index < d._places.Length && d._places[index] != null)
            {
                T temp = d._places[index];
                d._places[index] = null;
                return temp;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Метод отрисовки разметки парковочных мест
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                   _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
               (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }


        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < pictureHeight / _placeSizeHeight; i++)
            {
                for (int j = 0; j < pictureWidth / _placeSizeWidth; j++)
                {
                    int k = (pictureWidth / _placeSizeWidth) * i + j;
                    _places[k]?.SetPosition(j * _placeSizeWidth, i * _placeSizeHeight, pictureWidth, pictureHeight);
                    _places[k]?.DrawTransport(g);
                }
            }
        }
    }
}
