using System;

namespace Module3HW3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var first = new First(Show);
            var second = new Second();

            Predicate<double> resultHandler = second.Clalc(first.Pow, 5, 30);

            var state = resultHandler.Invoke(33);
            first.ActionInvoke(state);

            state = resultHandler.Invoke(1);
            first.ActionInvoke(state);
        }

        public static void Show(bool state)
        {
            Console.WriteLine($"is shares entirely? - {state}");
        }
    }
}
