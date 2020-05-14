using System;

namespace Molina_StudentList
{
    class Program
    {
        static void Main(string[] args)
        {
            Info info = new Info();
            GradesUI ui = new GradesUI();

            info.AssignmentInfo();
            ui.MainMethod();
        }
    }
}
