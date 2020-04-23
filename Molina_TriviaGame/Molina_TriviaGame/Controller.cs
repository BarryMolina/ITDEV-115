using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.IO;

namespace Molina_TriviaGame
{
    class Controller
    {
        public void Play()
        {
            Question_Bank qBank = new Question_Bank();
            string[] answers;
            int correct;
            //StreamWriter writer = new StreamWriter("outfile.txt");
            //writer.WriteLine("This is a test file");
            //writer.Close();
            Welcome();

            try
            {
                qBank.ReadQuestionFile();
            }
            catch (FileNotFoundException ex)
            {
                //Environment.Exit(1);
                Console.WriteLine("File not found: " + ex.Message);
            }
            //Console.WriteLine(qBank);

            do
            {
                correct = 0;
                Clear();
                for (int i = 0; i < Question_Bank.NO_OF_QUESTIONS; i++)
                {
                    string response;
                    WriteLine("\n\n\n\nQuestion " + (i + 1) + ":");
                    WriteLine("\n" + qBank.GetQuestion(i) + "\n");
                    answers = qBank.GetAnswers(i);
                    WriteLine("  A. " + answers[0] + "\tB. " + answers[1]);
                    WriteLine("  C. " + answers[2] + "\tD. " + answers[3]);
                    Write("\n\nWhat is your answer: ");

                    response = ReadLine();

                    if (!string.IsNullOrEmpty(response) && response.ToUpper()[0] == qBank.GetCorrectAnswer(i))
                    {
                            WriteLine("\nYou are correct!");
                            correct++;
                    }
                    else
                    {
                        WriteLine("\nSorry you are wrong");
                        WriteLine("The correct answer is " + qBank.GetCorrectAnswer(i));
                    }
                    WriteLine("\n" + qBank.GetExplanation(i));
                    WriteLine("\n\n\nPlease press the Enter key when you are ready to continue");
                    ReadKey();
                    Clear();
                }
                WriteLine("\n\n\n\nYou had " + correct + " correct answers out of " + Question_Bank.NO_OF_QUESTIONS);
                WriteLine("This gives you a percentage of {0:P}", ((double)correct / Question_Bank.NO_OF_QUESTIONS));
            } while (PlayAgain() == true);
        }
        public bool PlayAgain()
        {
            bool again = false;
            string resp;

            Write("\n\nWould you like to play again? (Y or N): ");
            resp = ReadLine();

            if (!string.IsNullOrEmpty(resp))
            {
                if (resp.ToUpper()[0] == 'Y')
                {
                    again = true;
                }
            }
            return again;
        }

        public void Welcome()
        {
            WriteLine("\n\n\n\tLet's play a game of trivia. You will be shown a series of questions," +
                "\n\tone at a time. Each question will have four possible answers, only one" +
                "\n\tis the correct answer. Your job is to pick the correct answer.");
            Write("\n\nPress the Enter key when you are ready to begin. GoodLuck\t");
            ReadKey();
        }
    }
}
