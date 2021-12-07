using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLocomotive
{
    public class LocoComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x.GetType().Name == "BaseLocomotive" && y.GetType().Name == "BaseLocomotive")
            {
                return ComparerBaseLocomotive(x as BaseLocomotive, y as BaseLocomotive);
            }
            else if (x.GetType().Name == "Locomotive" && y.GetType().Name == "Locomotive")
            {
                return ComparerLocomotive(x as Locomotive, y as Locomotive);
            }
            else if (x.GetType().Name == "Locomotive" && y.GetType().Name == "BaseLocomotive")
            {
                return -1;
            }
            else if (x.GetType().Name == "BaseLocomotive" && y.GetType().Name == "Locomotive")
            {
                return 1;
            }
            return 0;
        }
        private int ComparerBaseLocomotive(BaseLocomotive x, BaseLocomotive y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerLocomotive(Locomotive x, Locomotive y)
        {
            var res = ComparerBaseLocomotive(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.FrontLight != y.FrontLight)
            {
                return x.FrontLight.CompareTo(y.FrontLight);
            }
            if (x.BackLight != y.BackLight)
            {
                return x.BackLight.CompareTo(y.BackLight);
            }
            if (x.Smokestack != y.Smokestack)
            {
                return x.Smokestack.CompareTo(y.Smokestack);
            }
            if (x.SideLine != y.SideLine)
            {
                return x.SideLine.CompareTo(y.SideLine);
            }
            return 0;
        }

    }
}
