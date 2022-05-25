using System.Windows;
using System.ComponentModel;
using System.Windows.Shapes;
using System.Windows.Controls;

namespace TvSet
{
	public partial class MainWindow : Window, INotifyPropertyChanged
	{
        private void Click_animal(object sender, RoutedEventArgs e)
        {
            if (_selectedItem == null)
                return;
            if (count >= 35)
                return;
            int index = _selectedItem.TabIndex + 1;
            Rectangle _newObj = new Rectangle();

            if (index == 1)
            {
                Wolf animal = new Wolf();
                World.Children.Add(animal.Add(_newObj));
            }
            else if (index == 2)
            {
                Squirrel animal = new Squirrel();
                World.Children.Add(animal.Add(_newObj));
            }
            else if (index == 3)
            {
                Fox animal = new Fox();
                World.Children.Add(animal.Add(_newObj));
            }
            else if (index == 4)
            {
                Bear animal = new Bear();
                World.Children.Add(animal.Add(_newObj));
            }
            else if (index == 5)
            {
                Bunny animal = new Bunny();
                World.Children.Add(animal.Add(_newObj));
            }
            Canvas.SetTop(_newObj, rand.Next(180, 380));
            Canvas.SetLeft(_newObj, rand.Next(20, 520));
            Action(_newObj);
        }
    }
}
