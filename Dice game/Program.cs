namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please write a number between 1 and 7: ");
                int playerRandomNum = int.Parse(Console.ReadLine());

                Console.ReadKey();

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("The enemy AI rolled a: " + enemyRandomNum);
                Console.WriteLine();

                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins this round");
                }
                else if (enemyRandomNum > playerRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy AI wins this round");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }

                Console.WriteLine("The score is now - Player: " + playerPoints + " Enemy: " + enemyPoints);
                Console.WriteLine();
            }

            if (playerPoints > enemyPoints)
            {
                Console.WriteLine("You won!");
            }
            else if (playerPoints < enemyPoints)
            {
                Console.WriteLine("You lost :/");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }

                    
            Console.ReadKey();
        }
    }
}
