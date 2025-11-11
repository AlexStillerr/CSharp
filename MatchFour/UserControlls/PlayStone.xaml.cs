using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Media;

namespace MatchFour.UserControlls
{
    /// <summary>
    /// Interaktionslogik für PlayStone.xaml
    /// </summary>
    public partial class PlayStone : UserControl, INotifyPropertyChanged
    {
        public PlayStone()
        {
            DataContext = this;
            InitializeComponent();
        }

        private int playerId;

        public event PropertyChangedEventHandler PropertyChanged;

        public int PlayerId 
        {
            get => playerId;
            set
            {
                playerId = value;

                Brush brush = null;
                if (playerId == 1)
                    brush = new SolidColorBrush(Color.FromRgb(230, 47, 47)); // "#FFE62F2F"
                else if(playerId == 2)
                    brush = new SolidColorBrush(Color.FromRgb(236, 236, 10)); // "#FFECEC0A"
                else
                    brush = new SolidColorBrush(Color.FromRgb(227, 227, 227)); // "#FFECEC0A"

                Stone.Fill = brush;
            }
        }

        string boundString;
        public string BoundString 
        { 
            get => boundString;
            set
            {
                boundString = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
