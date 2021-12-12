using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW3
{
    public class First
    {
        private Action<bool> _actionHandler;

        public First()
        {
        }

        public First(Action<bool> action)
        {
            Register(action);
        }

        public void Register(Action<bool> action)
        {
            _actionHandler += action;
        }

        public void UnRegister(Action<bool> action)
        {
            _actionHandler -= action;
        }

        public void ActionInvoke(bool state)
        {
            _actionHandler(state);
        }

        public double Pow(double x, double y)
        {
            return x * y;
        }
    }
}
