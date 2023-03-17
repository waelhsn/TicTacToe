

namespace TicTacToe
{
    public class GamePlate
    {
        public static int[] gamePlate = new int[9];
        public static void outputBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                if (gamePlate[i] == 0)
                {
                    Console.Write("  .  ");
                }
                if (gamePlate[i] == 1)
                {
                    Console.Write("  X  ");
                }
                if (gamePlate[i] == 2)
                {
                    Console.Write("  O  ");
                }
                if (i == 2 || i == 5 || i == 8)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }
    }

}