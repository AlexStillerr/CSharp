using System;
using System.Windows;
using System.Windows.Controls;

namespace MatchFour.UserControlls
{
    /// <summary>
    /// Interaktionslogik für InsertButton.xaml
    /// </summary>
    public partial class InsertButton : UserControl
    {
        public event Action<int> SelectRow;

        public int HandleRow
        { set; get; }

        public InsertButton()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SelectRow?.Invoke(HandleRow);
        }
    }
}
