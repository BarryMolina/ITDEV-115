using System;
using static System.Console;

namespace Molina_ElectionResultsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Info info = new Info();
            ElectionUI electionUI = new ElectionUI();
            //Election el = new Election();

            info.DisplayInfo();
            electionUI.MainMethod();
            //WriteLine(el.numCandidates);

        }
    }
}
