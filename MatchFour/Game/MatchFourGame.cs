using System;
using System.Collections.Generic;
using System.Text;

namespace MatchFour.Game
{
    internal class MatchFourGame
    {
        private int[,] playField = new int[7,6];
        private int[] colHeight = new int[7];
        private int currentPlayer = 1;
        private int winningPlayer = 0;

        public void Reset()
        {
            for (int col = 0; col < 7; col++)
            {
                for (int row = 0; row < 6; row++)
                {
                    playField[col, row] = 0;
                }
                colHeight[col] = 0;
            }
            winningPlayer = 0;
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

        //public List<int> GetField()
        //{
        //    List<int> f = new();
        //    for (int row = 0; row < 6; row++)
        //        for (int col = 0; col < 7; col++)
        //            f.Add(playField[col, row]);

        //    return f;
        //}
        public string GetField()
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < 6; row++)
                for (int col = 0; col < 7; col++)
                    sb.Append(playField[col, row]);

            return sb.ToString();
        }

        public List<int> GetPossibleActions()
        {
            List<int> actions = new();
            for(int col = 0;col < 7;col++) 
                if(colHeight[col] < 6)
                    actions.Add(col + colHeight[col] * 7);
            return actions;
        }

        public int ActivePlayer() => currentPlayer;
        private bool CanAddStone(int col) => colHeight[col] < 6;
        private void SwapPlayer() => currentPlayer = currentPlayer == 1 ? 2 : 1;

        private void AddStone(int col, int player)
        {
            playField[col, colHeight[col] ] = player;
            colHeight[col]++;
        }

        public bool CheckGameOver(int player)
        {
            bool hasEmptyField = false;
            for (int col = 0; col < 7; col++)
            {
                for (int row = 0; row < 6; row++)
                {
                    if(playField[col, row] == 0)
                        hasEmptyField = true;
                    if (playField[col, row] != player)
                        continue;

                    if (CheckDirections(row, col, player))
                    {
                        winningPlayer = player;
                        return true;
                    }
                }
            }
            return !hasEmptyField;
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

                    if(playField[newCol, newRow] == player)
                        count++;
                }

                if(count == 4)
                    return true;
            }
            return false;
        }

        internal int GetReward(int player) => winningPlayer == player ? 100 : -1;
    }
}
