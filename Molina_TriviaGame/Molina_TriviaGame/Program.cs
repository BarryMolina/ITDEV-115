using System;

namespace Molina_TriviaGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Info info = new Info();
            Controller ctrl = new Controller();

            info.AssignmentInfo();
            ctrl.Play();
                

        }
    }
}
