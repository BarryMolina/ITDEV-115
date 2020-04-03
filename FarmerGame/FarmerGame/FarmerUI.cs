using System;
using static System.Console;

namespace FarmerGame
{
    public class FarmerUI 
    {
        Farmer farmer;

        String trees = "VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV" +
            "VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV";
        public FarmerUI()
        {
        }

        public void DisplayGameState()
        {
            WriteLine("\n\n\n\n");
            DisplayNorthBank();
            DisplayRiver();
            DisplaySouthBank();

            ForegroundColor = ConsoleColor.White;

            WriteLine("\nThe farmer is on the " + farmer.TheFarmer +
                " bank of the river.");
        }

        private void DisplayNorthBank()
        {
            for (int x = 0; x < 3; x++) 
            { 
                ForegroundColor = ConsoleColor.DarkGreen;
                BackgroundColor = ConsoleColor.Green;
                Write(trees);
                ResetColor();
                WriteLine();
            }
            ForegroundColor = ConsoleColor.DarkGreen;
            BackgroundColor = ConsoleColor.Green;
            Write("********************************** North Bank " +
                "**********************************");
            ResetColor();

            WriteLine();

            foreach (String item in farmer.NorthBank)
            {
                Write(item + " ");
            }
            WriteLine();
        }

        private void DisplayRiver()
        {
            String waves = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" +
                "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
            for (int x = 0; x < 4; x++)
            {
                ForegroundColor = ConsoleColor.DarkBlue;
                BackgroundColor = ConsoleColor.Blue;
                Write(waves);
                ResetColor();
                WriteLine();
            }
        }

        private void DisplaySouthBank()
        {
            foreach (String item in farmer.SouthBank)
            {
                Write(item + " ");
            }
            WriteLine();

            for (int x = 0; x < 3; x++) 
            { 
                ForegroundColor = ConsoleColor.DarkGreen;
                BackgroundColor = ConsoleColor.Green;
                Write(trees);
                ResetColor();
                WriteLine();
            }
            ForegroundColor = ConsoleColor.DarkGreen;
            BackgroundColor = ConsoleColor.Green;
            Write("********************************** South Bank " +
                "**********************************");
            ResetColor();
            WriteLine();
        }

        private void DisplayWelcome()
        {
            farmer = new Farmer();

            ForegroundColor = ConsoleColor.Red;
            WriteLine("\n\n\tThis is the Farmer Game. The object of the game" +
                "\n\tis to get the farmer, fox, chicken, and grain to the other" +
                "\n\tside of the river. But hold on, not so fast. If the farmer" +
                "\n\tleaves the chicken and grain on either side of the river alone," +
                "\n\tthe chicke will eat the grain and that is not good. If the" +
                "\n\tfarmer leaves the fox and chicken on any side of the river alone," +
                "\n\tthe fox will eat the chicken. This is also not good. In eather case" +
                "\n\tyou lose the game. If you get the farmer, the chicken," +
                "\n\tthe fox, and the grain safely across the river and intact, you win\n\n\n");

            ForegroundColor = ConsoleColor.White;
            WriteLine("Press any key when you are ready to start this though provoking game");
            ReadKey();
            ResetColor();
            Clear();
        }
        public bool GameOver()
        {
            bool gameOver = false;
            bool quit = false;

            if (farmer.AnimalAteFood("FOX"))
            {
                Write("\n\n\n\nOh no! the Fox ate the Chicken!!" + 
                    "\nYOU LOSE");
                gameOver = true;
            }
            else if (farmer.AnimalAteFood("CHICKEN"))
            {
                Write("\n\n\n\nOh no! the Chicken ate the Grain!!" +
                    "\nYOU LOSE");
                gameOver = true;
            }
            else if (farmer.DetermineWin())
            {
                WriteLine("\n\n\nYou have successfully completed the game!!" +
                    "\nCONGRATULATIONS");
                gameOver = true;
            }
            if (gameOver)
            { 
                Write("\n\n\nWould you like to play again? ");
                if (ReadLine().ToUpper()[0] == 'Y')
                {
                    farmer = new Farmer();
                }
                else
                {
                    quit = true;
                }
            }
            Clear();
            return quit;
        }

        public void Play()
        {
            DisplayGameState();
            while (!farmer.Move(PromptForMove()))
            {
                Clear();
                WriteLine("\nThat item is not on this side of the river." +
                    "\nPlease try again");
                DisplayGameState();
            }
        }

        public void PlayGame()
        {
            DisplayWelcome();
            do
            {
                Play();
            } while (!GameOver());
        }

        public String PromptForMove()
        {
            String move;
           
            Write("\n\nChoose next item for the farmer. If you choose nothing, " +
                "just hit the enter key ");

            move = ReadLine().ToUpper();

            Clear();

            return move;
        }
    }
}
