using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsLocomotive
{
    class Locomotive : BaseLocomotive
    {
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
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="frontSpoiler">Признак наличия переднего спойлера</param>
        /// <param name="sideSpoiler">Признак наличия боковых спойлеров</param>
        /// <param name="backSpoiler">Признак наличия заднего спойлера</param>
        /// <param name="sportLine">Признак наличия гоночной полосы</param>
        public Locomotive(int maxSpeed, float weight, Color mainColor, Color dopColor,
             bool smokestack, bool frontLight, bool backLight, bool sideLine) :
        base(maxSpeed, weight, mainColor, 130, 70)
        {
            DopColor = dopColor;
            Smokestack = smokestack;
            FrontLight = frontLight;
            BackLight = backLight;
            SideLine = sideLine;
        }
        /// <summary>
        /// Отрисовка тепловоза
        /// </summary>
        /// <param name="g"></param>
        public override void DrawTransport(Graphics g)
        {
            //объявление перьев
            Pen pen = new Pen(Color.Black);
            Pen dopPen = new Pen(DopColor);
            //объявление заливок
            Brush dopBrush = new SolidBrush(DopColor);
            
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
            }
            y += 20;
            base.DrawTransport(g);
            if (SideLine)
            {
                g.DrawLines(dopPen, new PointF[] { new PointF(x + 10, y + 30), new PointF(x + 20, y + 25), new PointF(x + 121, y + 25) });
                g.DrawLines(dopPen, new PointF[] { new PointF(x + 10, y + 31), new PointF(x + 20, y + 26), new PointF(x + 121, y + 26) });
            }
        }
    }
}
