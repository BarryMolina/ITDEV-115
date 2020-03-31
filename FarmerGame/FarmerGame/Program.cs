using System;

namespace FarmerGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Info info = new Info();
            FarmerUI farmerUI = new FarmerUI();

            //info.AssignmentInfo();
            farmerUI.DisplayGameState();
        }
    }
}
