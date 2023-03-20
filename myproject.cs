using System;

public class Program
{
    static void Main()
    {
        string[] choices = {"ROCK", "PAPER", "SCISSORS"};
        int scorePlayer = 0;
        int scoreCPU = 0;
        bool playAgain = true;
        
        Console.WriteLine("Let's play Rock-Paper-Scissors!");

        while (playAgain)
        {
            Console.Write("Enter your choice (ROCK, PAPER or SCISSORS): ");
            string inputPlayer = Console.ReadLine().ToUpper();

            Random rnd = new Random();
            int randomInt = rnd.Next(choices.Length);
            string inputCPU = choices[randomInt];

            Console.WriteLine($"CPU chose {inputCPU}");

            int winner = GetWinner(inputPlayer, inputCPU);

            switch (winner)
            {
                case 0:
                    Console.WriteLine("DRAW!");
                    break;
                case 1:
                    Console.WriteLine("PLAYER WINS!");
                    scorePlayer++;
                    break;
                case -1:
                    Console.WriteLine("CPU WINS!");
                    scoreCPU++;
                    break;
            }

            Console.WriteLine($"Score: Player {scorePlayer} - {scoreCPU} CPU");

            Console.Write("Do you want to play again? (YES/NO) ");
            string answer = Console.ReadLine().ToUpper();
            
            if(answer == "Y")
            {
                playAgain = true;
                Console.Clear();
            }
            else
            {
                playAgain = false;
                Console.WriteLine("Thanks for playing!");
            }
        }
    }

    static int GetWinner(string player, string cpu)
    {
        if (player == cpu)
        {
            return 0; // DRAW
        }

        if (player == "ROCK")
        {
            if (cpu == "PAPER")
            {
                return -1; // CPU WINS
            }
            else
            {
                return 1; // PLAYER WINS
            }
        }
        else if (player == "PAPER")
        {
            if (cpu == "SCISSORS")
            {
                return -1; // CPU WINS
            }
            else
            {
                return 1; // PLAYER WINS
            }
        }
        else // player == "SCISSORS"
        {
            if (cpu == "ROCK")
            {
                return -1; // CPU WINS
            }
            else
            {
                return 1; // PLAYER WINS
            }
        }
    }
}