using MatchFour.AI;
using MatchFour.Game;
using MatchFour.UserControlls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MatchFour
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private PlayStone[,] visualField = new PlayStone[7,6];

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

        private void ClickOnCol(int col)
        {
            (int row, int player) = game.TryToAddStone(col);
            if (player != -1)
            {
                visualField[col, 5 - row].PlayerId = player;
                if (game.CheckGameOver(player))
                {
                    MessageBoxResult result = MessageBox.Show($"Spiel ist vorbei uns Spieler {player} hat gewonnen.\nNoch eine Runde?", "Gameover", MessageBoxButton.YesNo);

                    if (result == MessageBoxResult.Yes)
                    {
                        Reset();
                    }
                }
            }
        }

        private async void CallPython(object sender, RoutedEventArgs e)
        {
            var client = new PythonClient();
            string answer = await client.SendTextAsync("Hallo von C#");

            MessageBox.Show(answer);
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
    }
}
