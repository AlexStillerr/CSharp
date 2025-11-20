using MatchFour.AI;
using MatchFour.Game;
using MatchFour.UserControlls;
using System;
using System.Numerics;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MatchFour
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private PlayStone[,] visualField = new PlayStone[7,6];
        PythonClient client = new PythonClient();
        private MatchFourGame game = new();

        public MainWindow()
        {
            InitializeComponent();

            CreateField();
        }

        private void CreateField()
        {

            //SolidColorBrush brush = new(new Color(0, 230,47,47));

            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    PlayStone stone = new PlayStone();
                    stone.Name = $"S{x}_{y}";

                    Grid.SetColumn(stone, x);
                    Grid.SetRow(stone, y);

                    Field.Children.Add(stone);
                    visualField[x, y] = stone;
                }
            }
        }
        
        private async void ClickOnCol(int col)
        {
            int player = game.ActivePlayer();
            bool isOver = DoTurn(col);
            bool keepOnPlaying = CheckGameOver();

            if (keepOnPlaying)
            {
                player = game.ActivePlayer();
                isOver = await DoAiTurn(true);
                CheckGameOver();
            }


            bool CheckGameOver()
            {
                if (isOver)
                {
                    MessageBoxResult result = MessageBox.Show($"Spiel ist vorbei uns Spieler {player} hat gewonnen.\nNoch eine Runde?", "Gameover", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes)
                        Reset();
                    else
                        return false;
                }
                return true;
            }
        }

        private bool DoTurn(int col)
        {
            (int row, int player) = game.TryToAddStone(col);
            if (player != -1)
            {
                visualField[col, 5 - row].PlayerId = player;
                return game.CheckGameOver(player);
            }
            return false;
        }

        private bool isLearning = false, stop = false;
        private async void CallPython(object sender, RoutedEventArgs e)
        {
            if (isLearning)
                stop = true;
            else
                await RunAI();

            MessageBoxResult result = MessageBox.Show($"Berechnung vorbei", "Gameover", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
                Reset();
        }

        private async Task RunAI()
        {
            isLearning = true;
            for (int i = 0; i < 1000; ++i)
            {
                int player = game.ActivePlayer();
                bool isOver = false;
                while (!isOver)
                {
                    isOver = await DoAiTurn(false);
                }

                await client.SendGameover();
                Reset();
                if (stop)
                    break;
            }
            stop = false;
            isLearning = false;
        }

        private async Task<bool> DoAiTurn(bool isProductionTurn)
        {
            int player = game.ActivePlayer();
            int x = await client.SendStateAndActions(game.GetField(), game.GetPossibleActions(), player, isProductionTurn);
            bool isOver = DoTurn(x % 7);
            await client.SendReward(game.GetField(), game.GetReward(player), player);
            return isOver;
        }

        private void Reset()
        {
            game.Reset();
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    visualField[x, y].PlayerId = 0;
                }
            }
        }

        string path = "";
        //string pathPlayer1 = "matchFourPlayer1.json";
        //string pathPlayer2 = "matchFourPlayer2.json";
        string pathPlayer1 = "MatchFourAi1.json";
        string pathPlayer2 = "MatchFourAi2.json";
        private async void SaveAI(object sender, RoutedEventArgs e)
        {
            await client.SendSaveAi(path+pathPlayer1, path + pathPlayer2);
            MessageBoxResult result = MessageBox.Show($"Es wurde gespeichert", "Save AI", MessageBoxButton.OK);
        }

        private async void LoadAI(object sender, RoutedEventArgs e)
        {
            await client.SendLoadAi(path + pathPlayer1, path + pathPlayer2);
            MessageBoxResult result = MessageBox.Show($"Es wurde geladen", "Load AI", MessageBoxButton.OK);
        }
    }
}
