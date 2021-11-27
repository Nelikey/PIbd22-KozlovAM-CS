using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLocomotive
{
    class DepotNotFoundException : Exception
    {
        public DepotNotFoundException(int i) : base("Не найден автомобиль по месту " + i)
        { }
    }
}
