using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsLocomotive
{
    class Locomotive
    {
        /// <summary>
        /// Левая координата отрисовки тепловоза
        /// </summary>
        private float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки тепловоза
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int _pictureHeight;
        /// <summary>
        /// Ширина отрисовки тепловоза
        /// </summary>
        private readonly int locoWidth = 130;
        /// <summary>
        /// Высота отрисовки тепловоза
        /// </summary>
        private readonly int locoHeight = 65;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }
        /// <summary>
        /// Вес тепловоза
        /// </summary>
        public float Weight { private set; get; }
        /// <summary>
        /// Основной цвет кузова
        /// </summary>
        public Color MainColor { private set; get; }
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия дымовой трубы
        /// </summary>
        public bool Smokestack { private set; get; }
        /// <summary>
        /// Признак наличия переднего фонаря
        /// </summary>
        public bool FrontLight { private set; get; }
        /// <summary>
        /// Признак наличия заднего фонаря
        /// </summary>
        public bool BackLight { private set; get; }
        /// <summary>
        /// Признак наличия боковой полосы
        /// </summary>
        public bool SideLine { private set; get; }
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="frontSpoiler">Признак наличия переднего спойлера</param>
        /// <param name="sideSpoiler">Признак наличия боковых спойлеров</param>
        /// <param name="backSpoiler">Признак наличия заднего спойлера</param>
        /// <param name="sportLine">Признак наличия гоночной полосы</param>
        public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor,
       bool smokestack, bool frontLight, bool backLight, bool sideLine)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Smokestack = smokestack;
            FrontLight = frontLight;
            BackLight = backLight;
            SideLine = sideLine;
        }
        /// <summary>
        /// Установка позиции тепловоза
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - locoWidth)
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
        public void DrawTransport(Graphics g)
        {
            //объявление перьев
            Pen pen = new Pen(Color.Black);
            Pen bluePen = new Pen(Color.Blue);
            Pen dopPen = new Pen(DopColor);
            //объявление заливок
            Brush mainBrush = new SolidBrush(MainColor);
            Brush dopBrush = new SolidBrush(DopColor);
            Brush blackBrush = new SolidBrush(Color.Black);
            Brush whiteBrush = new SolidBrush(Color.White);
            int x = (int)_startPosX;
            int y = (int)_startPosY;
            if (Smokestack || FrontLight || BackLight)
            {
                if (Smokestack)
                {
                    g.FillRectangle(dopBrush, x + 87, y + 2, 15, 18);
                    g.DrawRectangle(pen, x + 87, y + 2, 15, 18);
                }
                if (FrontLight)
                {
                    g.FillPolygon(dopBrush, new PointF[] {new PointF(x+21,y+20), new PointF(x+21, y+13),
                                                 new PointF(x+11,y+13), new PointF(x+13,y+16),
                                                 new PointF(x+20,y+16), new PointF(x+20,y+20)});
                    g.DrawPolygon(pen, new PointF[] {new PointF(x+21,y+20), new PointF(x+21, y+13),
                                                 new PointF(x+11,y+13), new PointF(x+13,y+16),
                                                 new PointF(x+20,y+16), new PointF(x+20,y+20)});
                }
                if (BackLight)
                {
                    g.FillPolygon(dopBrush, new PointF[] {new PointF(x+116,y+20), new PointF(x+116, y+13),
                                                 new PointF(x+126,y+13), new PointF(x+124,y+16),
                                                 new PointF(x+117,y+16), new PointF(x+117,y+20)});
                    g.DrawPolygon(pen, new PointF[] {new PointF(x+116,y+20), new PointF(x+116, y+13),
                                                 new PointF(x+126,y+13), new PointF(x+124,y+16),
                                                 new PointF(x+117,y+16), new PointF(x+117,y+20)});
                }
                y += 20;
            }
            //отрисовка вагона
            g.FillPolygon(mainBrush, new PointF[] {new PointF(x+10,y+42), new PointF(x+10, y+20),
                                             new PointF(x+16,y), new PointF(x+121,y),
                                             new PointF(x+121,y+42)});
            g.DrawPolygon(pen, new PointF[] {new PointF(x+10,y+42), new PointF(x+10, y+20),
                                             new PointF(x+16,y), new PointF(x+121,y),
                                             new PointF(x+121,y+42)});
            //отрисовка основной боковой линии
            g.DrawLine(pen, new Point(x+10, y+20), new Point(x+121, y+20));
            if (SideLine)
            {
                g.DrawLines(dopPen, new PointF[] { new PointF(x + 10, y + 30), new PointF(x + 20, y + 25), new PointF(x + 121, y + 25) });
                g.DrawLines(dopPen, new PointF[] { new PointF(x + 10, y + 31), new PointF(x + 20, y + 26), new PointF(x + 121, y + 26) });
            }
            //отрисовка окон
            g.FillRectangle(whiteBrush, x + 18, y + 3, 10, 15);
            g.FillRectangle(whiteBrush, x + 31, y + 3, 10, 15);
            g.FillRectangle(whiteBrush, x + 107, y + 3, 10, 15);
            g.DrawRectangle(bluePen, x+18, y+3, 10, 15);
            g.DrawRectangle(bluePen, x+31, y+3, 10, 15);
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
    }
}
