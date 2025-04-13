using System.Media;

namespace QA_Ice_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> question = new Dictionary<string, string>
            {
                {"What is the capital of France", "paris" },
                {"What is the largest planet in our solar system", "jupiter" },
                {"What is the capital of Japan", "tokyo" },
                {"What is 5+5?", "10" }
            };
            SoundPlayer wrong = new SoundPlayer("wrong.wav");
            SoundPlayer correct = new SoundPlayer("correct.wav");

            Welcome.ShowWelcomeScreen();
            Console.WriteLine("Answer the questions correctly and try get a high score!");
            int score = 0;
            int count = 0;
            while (count != 4)
            {
                foreach(var q in question)
                {
                    Console.WriteLine($"\nQuestion: {q.Key}");
                    Console.WriteLine($"Your Answer: ");
                    string answer = Console.ReadLine()?.Trim().ToLower();
                    if(answer == q.Value)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correct!");
                        correct.PlaySync();
                        score = score + 1;
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Wrong! The correct answer is: {q.Value}");
                        wrong.PlaySync();
                        Console.ResetColor();
                    }
                    count = count + 1;
                }

                
                
                    Console.WriteLine("End of Game!");
                    Console.WriteLine("Final score: " + score);

                    return;
                

            }
            Thread.Sleep(3000);
            //Console.WriteLine("End of Game!");
            //Console.WriteLine("Final score: " + score);
        }
    }
}
