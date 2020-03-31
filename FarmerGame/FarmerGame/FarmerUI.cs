using System;
using static System.Console;

namespace FarmerGame
{
    public class FarmerUI
    {
        String trees = "VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV" +
            "VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV";
        public FarmerUI()
        {
        }

        public void DisplayGameState()
        {
            DisplayNorthBank();
            WriteLine();
            DisplayRiver();
            WriteLine();
            DisplaySouthBank();
            WriteLine();
        }

        private void DisplayNorthBank()
        {
            for (int x = 0; x < 3; x++) 
            { 
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.BackgroundColor = ConsoleColor.Green;
                Write(trees);
                Console.ResetColor();
                WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Green;
            Write("********************************** North Bank " +
                "**********************************");
            Console.ResetColor();
            WriteLine();
        }

        private void DisplayRiver()
        {
            String waves = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" +
                "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
            for (int x = 0; x < 4; x++)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.BackgroundColor = ConsoleColor.Blue;
                Write(waves);
                Console.ResetColor();
                WriteLine();
            }
        }

        private void DisplaySouthBank()
        {
            for (int x = 0; x < 3; x++) 
            { 
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.BackgroundColor = ConsoleColor.Green;
                Write(trees);
                Console.ResetColor();
                WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Green;
            Write("********************************** South Bank " +
                "**********************************");
            Console.ResetColor();
            WriteLine();
        }

        private void DisplayWelcome()
        { 
        }

        public void Play()
        { 
        }

        public void PlayGame()
        { 
        }

        public void PromptForMove()
        { 
        }
    }
}
