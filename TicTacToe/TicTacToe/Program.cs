using static TicTacToe.GamePlate;

namespace TicTacToe
{
    public class Program : ScenariosChecker
    {
        public static void Main()
        {
            Console.WriteLine();

            for (int i = 0; i < 9; i++)
            {
                gamePlate[i] = 0;
            }
            int userTurn = -1;
            int computerTurn = -1;
            Random random = new Random();

            while (checkForWinner() == 0)
            {
                while (userTurn == -1 || gamePlate[userTurn] != 0)
                {
                    Console.WriteLine($"Please enter a number from 0 to 8: ");
                    userTurn = int.Parse(Console.ReadLine());
                    Console.WriteLine($"You typed {userTurn}");
                }
                gamePlate[userTurn] = 1;

                while (computerTurn == -1 || gamePlate[computerTurn] != 0)
                {
                    computerTurn = random.Next(8);
                    Console.WriteLine($"Computer chooses {computerTurn}");
                }
                gamePlate[computerTurn] = 2;
                outputBoard();
            }
            Console.WriteLine($"Player {checkForWinner()} won the game");
        }


    }
}
