using System.Collections.Generic;

namespace MatchFour.Game
{
    internal class MatchFourGame
    {
        private int[,] field = new int[7,6];
        private int[] colHeight = new int[7];
        private int currentPlayer = 1;

        public void Reset()
        {
            for (int col = 0; col < 7; col++)
            {
                for (int row = 0; row < 6; row++)
                {
                    field[col, row] = 0;
                }
                colHeight[col] = 0;
            }
        }

        public (int,int) TryToAddStone(int col)
        {
            if(CanAddStone(col))
            {
                (int, int) returnValue = (colHeight[col], currentPlayer);
                
                AddStone(col, currentPlayer);
                SwapPlayer();

                return returnValue;
            }
            return (-1, -1);
        }

        private bool CanAddStone(int col) => colHeight[col] < 6;
        private void SwapPlayer() => currentPlayer = currentPlayer == 1 ? 2 : 1;

        private void AddStone(int col, int player)
        {
            field[col, colHeight[col] ] = player;
            colHeight[col]++;
        }

        public bool CheckGameOver(int player)
        {
            for (int col = 0; col < 7; col++)
            {
                for (int row = 0; row < 6; row++)
                {
                    if (field[col, row] != player)
                        continue;

                    if (CheckDirections(row, col, player))
                        return true;
                }
            }
            return false;
        }

        List<(int,int)> directions = new() { (0,1), (1,0), (1,1), (1,-1) };

        private bool CheckDirections(int row, int col, int player)
        {
            foreach ((int x, int y) in directions)
            {
                int count = 1;

                for(int i = 1;  i < 4; i++)
                {
                    int newRow = row + i * y;
                    int newCol = col + i * x;

                    if (newRow < 0 || newCol < 0 || newRow > 5 || newCol > 6)
                        continue;

                    if(field[newCol, newRow] == player)
                        count++;
                }

                if(count == 4)
                    return true;
            }
            return false;
        }
    }
}
