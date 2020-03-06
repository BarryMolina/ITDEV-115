using System;
namespace Molina_MagicApp
{
    public class MagicPC
    {
        Random rand;
        string[] answers = {
            "As I see it, yes.",
            "Ask again later.",
            "Better now tell you now.",
            "Cannot predict now.",
            "Concentrate and ask again.",
            "Don't count on it.",
            "It is certain.",
            "It is decidedly so.",
            "Most likely.",
            "My reply is no.",
            "My sources say no.",
            "Outlook not so good.",
            "Outlook good.",
            "Reply hazy, try again.",
            "Signs point to yes.",
            "Very doubtful",
            "Without a doubt.",
            "Yes.",
            "Yes - definitely.",
            "You may rely on it.",
        };
        public MagicPC()
        {
            rand = new Random();
        }
        public string GetUserAnswer()
        {
            return answers[rand.Next(answers.Length)]; 
        }
    }
}
