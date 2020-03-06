using System;

namespace Molina_MagicApp
{
    class Program
    {
        static void Main()
        {
            Info info = new Info();
            MagicPCUI ui = new MagicPCUI();

            info.AssignementInfo();

            ui.MainMethod();
        }
    }
}
