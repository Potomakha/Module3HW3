using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW3
{
    public class Second
    {
        private double _operationResult;
        public Predicate<double> Clalc(Func<double, double, double> operation, double x, double y)
        {
            _operationResult = operation(x, y);
            return new Predicate<double>(Result);
        }

        private bool Result(double value)
        {
            var residue = _operationResult % value;

            if (residue.Equals(0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
