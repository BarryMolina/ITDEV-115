using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Molina_TriviaGUI
{
    class QuestionBank
    {
        private string fileName = "trivia.txt";
        public static int NO_OF_QUESTIONS = 5;
        public static int NO_OF_ANSWERS = 4;
        private Question[] questionBank = new Question[NO_OF_QUESTIONS];


        public string[] GetAnswers(int questionNum)
        {
            return questionBank[questionNum].Answers;
        }

        public char GetCorrectAnswer(int questionNum)
        {
            return questionBank[questionNum].CorrectAnswer;
        }

        public string GetExplanation(int questionNum)
        {
            return questionBank[questionNum].Explanation;
        }

        public string GetQuestion(int questionNum)
        {
            return questionBank[questionNum].QuestionText;
        }
        public void ReadQuestionFile()
        {
            StreamReader inFile;
            string question;
            string[] answers;
            char correct;
            string explanation;

            inFile = new StreamReader(fileName);
            //Console.WriteLine(inFile.ReadLine());

            for (int i = 0; i < questionBank.Length; i++)
            {
                question = inFile.ReadLine();
                answers = new string[NO_OF_ANSWERS];
                for (int x = 0; x < answers.Length; x++)
                {
                    answers[x] = inFile.ReadLine();
                }
                correct = inFile.ReadLine()[0];
                explanation = inFile.ReadLine();
                questionBank[i] = new Question(question, answers, correct, explanation);
            }

            inFile.Close();
        }
        public override string ToString()
        {
            string str = "";
            for (int x = 0; x < questionBank.Length; x++)
            {
                str += questionBank[x].ToString() + "\n";
            }
            return str;
        }

    }
}
