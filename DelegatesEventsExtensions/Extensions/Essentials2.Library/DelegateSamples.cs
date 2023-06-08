using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essentials2.Library
{
    public static class DelegateSamples
    {
        public static event Action<string> SomethingHappened;

        //public delegate void Del(string input);

        public static void PassMeWork(Action<string> work)
        {
            work("delegates");
        }

        public static void PassMeLogic(Func<string, int> worker)
        {
            int count = worker("Hello World");
            Console.WriteLine($"Function returned {count}");
        }

        public static void DoSomething()
        {
            Console.WriteLine("I'm about to do something.");
            if (SomethingHappened != null)
            {
                SomethingHappened("I did something");
            }
        }
    }
}
