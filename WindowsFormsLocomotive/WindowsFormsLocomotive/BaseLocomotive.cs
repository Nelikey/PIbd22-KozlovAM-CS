using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsLocomotive
{
    class BaseLocomotive : Vehicle
    {
        /// <summary>
        /// Ширина отрисовки локомотива
        /// </summary>
        private readonly int locoWidth = 130;

        /// <summary>
        /// Высота отрисовки локомотива
        /// </summary>
        private readonly int locoHeight = 70;

        /// <summary>
        /// Разделитель для записи информации по объекту в файл
        /// </summary>
        protected readonly char separator = ';';

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес локомотива</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        public BaseLocomotive(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        /// <summary>
        /// Конструктор для загрузки с файла
        /// </summary>
        /// <param name="info">Информация по объекту</param>
        public BaseLocomotive(string info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        /// <summary>
        /// Конструктор с изменением размеров локомотива
        /// </summary> 
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес локомотива</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="locoWidth">Ширина отрисовки локомотива</param>
        /// <param name="locoHeight">Высота отрисовки локомотива</param>
        protected BaseLocomotive(int maxSpeed, float weight, Color mainColor, int locoWidth, int
       locoHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.locoWidth = locoWidth;
            this.locoHeight = locoHeight;
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step <= _pictureWidth - locoWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - locoHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        /// <summary>
        /// Отрисовка тепловоза
        /// </summary>
        /// <param name="g"></param>
        public override void DrawTransport(Graphics g)
        {
            //объявление перьев
            Pen pen = new Pen(Color.Black);
            Pen bluePen = new Pen(Color.Blue);
            //объявление заливок
            Brush mainBrush = new SolidBrush(MainColor);
            Brush blackBrush = new SolidBrush(Color.Black);
            Brush whiteBrush = new SolidBrush(Color.White);
            int x = (int)_startPosX;
            int y = (int)_startPosY+20;
            
            //отрисовка вагона
            g.FillPolygon(mainBrush, new PointF[] {new PointF(x+10,y+42), new PointF(x+10, y+20),
                                             new PointF(x+16,y), new PointF(x+121,y),
                                             new PointF(x+121,y+42)});
            g.DrawPolygon(pen, new PointF[] {new PointF(x+10,y+42), new PointF(x+10, y+20),
                                             new PointF(x+16,y), new PointF(x+121,y),
                                             new PointF(x+121,y+42)});
            //отрисовка основной боковой линии
            g.DrawLine(pen, new Point(x + 10, y + 20), new Point(x + 121, y + 20));            
            //отрисовка окон
            g.FillRectangle(whiteBrush, x + 18, y + 3, 10, 15);
            g.FillRectangle(whiteBrush, x + 31, y + 3, 10, 15);
            g.FillRectangle(whiteBrush, x + 107, y + 3, 10, 15);
            g.DrawRectangle(bluePen, x + 18, y + 3, 10, 15);
            g.DrawRectangle(bluePen, x + 31, y + 3, 10, 15);
            g.DrawRectangle(bluePen, x + 107, y + 3, 10, 15);
            //отрисовка двери
            g.FillRectangle(mainBrush, x + 48, y + 8, 12, 29);
            g.DrawRectangle(pen, x + 48, y + 8, 12, 29);
            //передняя сцепка
            g.FillPolygon(blackBrush, new PointF[] {new PointF(x+5,y+45), new PointF(x+11, y+45),
                                             new PointF(x+11,y+42), new PointF(x+19,y+42),
                                             new PointF(x+19,y+49), new PointF(x+5,y+49)});
            g.DrawPolygon(pen, new PointF[] {new PointF(x+5,y+45), new PointF(x+11, y+45),
                                             new PointF(x+11,y+42), new PointF(x+19,y+42),
                                             new PointF(x+19,y+49), new PointF(x+5,y+49)});
            //передний низ
            g.FillPolygon(blackBrush, new PointF[] {new PointF(x+20,y+42), new PointF(x+53, y+42),
                                             new PointF(x+43,y+47), new PointF(x+30,y+47)});
            g.DrawPolygon(pen, new PointF[] {new PointF(x+20,y+42), new PointF(x+53, y+42),
                                             new PointF(x+43,y+47), new PointF(x+30,y+47)});
            //задний низ
            g.FillPolygon(blackBrush, new PointF[] {new PointF(x+75,y+42), new PointF(x+106, y+42),
                                             new PointF(x+96,y+47), new PointF(x+85,y+47)});
            g.DrawPolygon(pen, new PointF[] {new PointF(x+75,y+42), new PointF(x+106, y+42),
                                             new PointF(x+96,y+47), new PointF(x+85,y+47)});
            //задняя сцепка
            g.FillPolygon(blackBrush, new PointF[] {new PointF(x+120,y+45), new PointF(x+114, y+45),
                                             new PointF(x+114,y+42), new PointF(x+107,y+42),
                                             new PointF(x+107,y+49), new PointF(x+120,y+49)});
            g.DrawPolygon(pen, new PointF[] {new PointF(x+120,y+45), new PointF(x+114, y+45),
                                             new PointF(x+114,y+42), new PointF(x+107,y+42),
                                             new PointF(x+107,y+49), new PointF(x+120,y+49)});
            //отрисовка колёс
            g.FillEllipse(whiteBrush, x + 19, y + 42, 12, 10);
            g.FillEllipse(whiteBrush, x + 42, y + 42, 12, 10);
            g.FillEllipse(whiteBrush, x + 74, y + 42, 12, 10);
            g.FillEllipse(whiteBrush, x + 95, y + 42, 12, 10);
            g.DrawEllipse(pen, x + 19, y + 42, 12, 10);
            g.DrawEllipse(pen, x + 42, y + 42, 12, 10);
            g.DrawEllipse(pen, x + 74, y + 42, 12, 10);
            g.DrawEllipse(pen, x + 95, y + 42, 12, 10);
            //отрисовка задней части
            g.FillRectangle(blackBrush, x + 121, y + 2, 3, 36);
            g.DrawRectangle(pen, x + 121, y + 2, 3, 36);
        }

        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }
    }
}
