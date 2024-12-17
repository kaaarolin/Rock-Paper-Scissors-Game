using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); 
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine("Please input 1 for rock, 2 for paper, or 3 for scissors: ");

                bool isValidInput = int.TryParse(Console.ReadLine(), out int playerInput);

                if (!isValidInput || playerInput < 1 || playerInput > 3)
                {
                    Console.WriteLine("Invalid input. Please enter 1 for rock, 2 for paper, or 3 for scissors.");
                    i--; 
                    continue;
                }

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 4);
                Console.WriteLine("The enemy AI rolled a: " + GetChoiceName(enemyRandomNum));

                Console.WriteLine("You chose: " + GetChoiceName(playerInput));

                if (playerInput == enemyRandomNum)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if ((playerInput == 1 && enemyRandomNum == 3) ||  
                         (playerInput == 2 && enemyRandomNum == 1) ||  
                         (playerInput == 3 && enemyRandomNum == 2))   
                {
                    Console.WriteLine("Hooray! You win this round!");
                    playerPoints++;
                }
                else
                {
                    Console.WriteLine("Oh no! Enemy AI wins this round!");
                    enemyPoints++;
                }

                Console.WriteLine($"Score: Player {playerPoints} - {enemyPoints} Enemy");
                Console.WriteLine();
            }

            if (playerPoints > enemyPoints)
            {
                Console.WriteLine("Congratulations! OMG you won the game!");
            }
            else if (playerPoints < enemyPoints)
            {
                Console.WriteLine("Yikes you lost...");
            }
            else
            {
                Console.WriteLine("The game is a tie?!");
            }

            Console.WriteLine("Thanks for playing! Press any key to exit the game! :)");
            Console.ReadKey();
        }
        static string GetChoiceName(int choice)
        {
            switch (choice)
            {
                case 1: return "Rock";
                case 2: return "Paper";
                case 3: return "Scissors";
                default: return "Unknown";
            }
        }
    }
}

