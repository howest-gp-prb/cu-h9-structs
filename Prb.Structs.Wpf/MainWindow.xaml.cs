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

namespace Prb.Structs.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Coordinate currentPosition;

        public MainWindow()
        {
            InitializeComponent();
            currentPosition = new Coordinate(4, 7);
            ShowPosition();
        }

        private void ShowPosition()
        {
            lblPosition.Content = $"({currentPosition.x}, {currentPosition.y})";
            lstPath.Items.Insert(0, lblPosition.Content);
        }

        private void BtnUp_Click(object sender, RoutedEventArgs e)
        {
            int newX = currentPosition.x;
            int newY = currentPosition.y + 1;
            currentPosition = new Coordinate(newX, newY);
            ShowPosition();
        }

        private void BtnDown_Click(object sender, RoutedEventArgs e)
        {
            int newX = currentPosition.x;
            int newY = currentPosition.y - 1;
            currentPosition = new Coordinate(newX, newY);
            ShowPosition();
        }

        private void BtnLeft_Click(object sender, RoutedEventArgs e)
        {
            int newX = currentPosition.x - 1;
            int newY = currentPosition.y;
            currentPosition = new Coordinate(newX, newY);
            ShowPosition();
        }

        private void BtnRight_Click(object sender, RoutedEventArgs e)
        {
            int newX = currentPosition.x + 1;
            int newY = currentPosition.y;
            currentPosition = new Coordinate(newX, newY);
            ShowPosition();
        }
    }

    struct Coordinate
    {
        public readonly int x;
        public readonly int y;

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
