using static TicTacToe.GamePlate;

namespace TicTacToe
{
    public class ScenariosChecker
    {
        public static int checkForWinner()
        {
            // First row
            if (gamePlate[0] == gamePlate[1] && gamePlate[1] == gamePlate[2])
            {
                return gamePlate[0];
            }
            // Second row
            if (gamePlate[3] == gamePlate[4] && gamePlate[4] == gamePlate[5])
            {
                return gamePlate[3];
            }
            // Third row
            if (gamePlate[6] == gamePlate[7] && gamePlate[7] == gamePlate[8])
            {
                return gamePlate[6];
            }
            // First column
            if (gamePlate[0] == gamePlate[3] && gamePlate[3] == gamePlate[6])
            {
                return gamePlate[0];
            }
            //second column
            if (gamePlate[1] == gamePlate[4] && gamePlate[4] == gamePlate[7])
            {
                return gamePlate[1];
            }

            // Third column
            if (gamePlate[2] == gamePlate[5] && gamePlate[5] == gamePlate[8])
            {
                return gamePlate[2];
            }

            // First diagonal
            if (gamePlate[0] == gamePlate[4] && gamePlate[4] == gamePlate[8])
            {
                return gamePlate[0];
            }
            // second diagonal
            if (gamePlate[2] == gamePlate[4] && gamePlate[4] == gamePlate[8])
            {
                return gamePlate[2];
            }

            return 0;
        }
    }
}