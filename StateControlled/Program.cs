using System;
using static System.Console;

namespace StateControlled
{
    class StateControlled
    {
        static void Main(string[] args)
        {
            int s;
            int limit = 100;
            int x = 0;
            Random numb = new Random();
            s = numb.Next(100);
            while (x < limit)
            {
                Write("{0} ", s);
                s = numb.Next(100);
                x++;
            }
        }
    }
}
