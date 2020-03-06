using System;
using static System.Console;

namespace UsePredefinedMethods
{
    class UsePredefinedMethods
    {
        static void Main(string[] args)
        {
            double [ ] waterDepth = {45, 19, 2, 16.8, 190, 
                                    0.8, 510, 6, 18};
            string outputMsg = "";
            double [ ] w = new double [20];

            outputMsg += "waterDepth Array\n\n";
            foreach(double wVal in waterDepth)
                outputMsg += wVal + "\n";
            WriteLine(outputMsg);

            Array.Copy(waterDepth, 2, w, 0, 5);
            
            Array.Sort(w);

            outputMsg = "Array w Sorted\n\n";
            foreach(double wVal in w)
            {
                if (wVal > 0)
                    outputMsg += wVal + "\n";
            }
            WriteLine(outputMsg);

            Array.Reverse(w);

            outputMsg = "Array w Reversed\n\n";
            foreach(double wVal in w)
            {
                if (wVal > 0)
                    outputMsg += wVal + "\n";
            }
            WriteLine(outputMsg);
        }
    }
}
