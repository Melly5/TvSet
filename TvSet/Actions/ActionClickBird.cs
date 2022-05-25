using System.Windows;
using System.ComponentModel;
using System.Windows.Shapes;
using System.Windows.Controls;

namespace TvSet
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private void Click_bird(object sender, RoutedEventArgs e)
        {
            if (_selectedItem == null)
                return;
            if (count >= 35)
                return;

            int index = _selectedItem.TabIndex + 1;
            Rectangle _newObj = new Rectangle();

            if (index == 1)
            {
                Redpoll bird = new Redpoll();
                World.Children.Add(bird.Add(_newObj));
            }
            else if (index == 2)
            {
                BlueTit bird = new BlueTit();
                World.Children.Add(bird.Add(_newObj));
            }
            else if (index == 3)
            {
                Pigeon bird = new Pigeon();
                World.Children.Add(bird.Add(_newObj));
            }
            else if (index == 4)
            {
                Hummingbird bird = new Hummingbird();
                World.Children.Add(bird.Add(_newObj));
            }
            else if (index == 5)
            {
                Finch bird = new Finch();
                World.Children.Add(bird.Add(_newObj));
            }
            Canvas.SetTop(_newObj, rand.Next(30, 180));
            Canvas.SetLeft(_newObj, rand.Next(30, 540));
            Action(_newObj);
        }
    }
}
