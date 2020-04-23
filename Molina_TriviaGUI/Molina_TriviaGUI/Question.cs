using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molina_TriviaGUI
{
    class Question
    {
        private string question;
        private string[] answers;
        private char correctAnswer;
        private string explanation;

        public Question()
        {
        }

        public Question(string question, string[] answers, char correctAnswer, string explanation)
        {
            this.question = question;
            this.answers = answers;
            this.correctAnswer = correctAnswer;
            this.explanation = explanation;
        }

        public string[] Answers
        {
            get { return answers; }
        }

        public char CorrectAnswer
        {
            get { return correctAnswer; }
        }

        public string Explanation
        {
            get { return explanation; }
        }

        public string QuestionText
        {
            get { return question; }
        }
        public override string ToString()
        {
            string str = "";
            str += question + "\n";
            foreach (string a in answers)
            {
                str += a + "\n";
            }
            str += correctAnswer + "\n" + explanation + "\n";
            return str;
        }
    }
}
