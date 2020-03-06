using System;
using static System.Console;
namespace Molina_MagicApp
{
    public class MagicPCUI
    {
        MagicPC pC;

        public MagicPCUI()
        {
            pC = new MagicPC();
        }
        public void MainMethod()
        { 
            UserInstructions();

            while (GetUserQuestion())
                RespondToQuestion(pC.GetUserAnswer());
            goodBye();
        }
        public bool GetUserQuestion()
        {
            string question;
            bool questionAsked = true;

            Clear();
            Console.ForegroundColor = ConsoleColor.White;
            WriteLine("\nEnter your question, if you dare\n");
            question = ReadLine();

            if (String.IsNullOrEmpty(question))
                questionAsked = false;

            return questionAsked;
        }
        public void RespondToQuestion(string answer)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine("\n\t" + answer);
            Console.ResetColor();
            ReadKey();
        }
        public void UserInstructions()
        { 
            Console.ForegroundColor = ConsoleColor.White;
            WriteLine("*******************************************************************************\n");
            WriteLine("\tWelcome my friend welcome. Come closer. That's right.\n");
            WriteLine("\tThis is the magic PC screen. All your questions will be answered!");
            WriteLine("\tJust enter a question and the magic PC screen will give you the answer!\n");
            WriteLine("\tHowever, it must be a question that can be answered with a yes or a no.");
            WriteLine("\tTo exit the program, just hit the Enter key.\n");
            WriteLine("*******************************************************************************\n");
            WriteLine("Press any key to continue.");
            ReadKey();
        }
        public void goodBye()
        {
            Clear();
            WriteLine("\nUntil we meet again, may you have good fortune.");
            ReadKey();
        }
    }
}
