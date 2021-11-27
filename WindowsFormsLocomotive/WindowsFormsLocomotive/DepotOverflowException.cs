using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLocomotive
{
    /// <summary>
    /// Класс-ошибка "Если на депо уже заняты все места"
    /// </summary>
    public class DepotOverflowException : Exception
    {
        public DepotOverflowException() : base("На парковке нет свободных мест")
        { }
    }
}
