using System;

namespace Essentials2.Library
{
    public static class DelegateSample
    {
        public delegate void Del(string input);

        public static void PassWork(Del work)
        {
            work("delegated");
        }
    }
}