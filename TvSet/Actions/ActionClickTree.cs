using System.Windows;
using System.ComponentModel;
using System.Windows.Shapes;
using System.Windows.Controls;

namespace TvSet
{
	public partial class MainWindow : Window, INotifyPropertyChanged
	{
        private void Click_tree(object sender, RoutedEventArgs e)
        {
            if (_selectedItem == null)
                return;
            if (count >= 35)
                return;
            int index = _selectedItem.TabIndex + 1;
            Rectangle _newObj = new Rectangle();

            if (index == 1)
            {
                Fir tree = new Fir();
                World.Children.Add(tree.Add(_newObj));
            }
            else if (index == 2)
            {
                DragonTree tree = new DragonTree();
                World.Children.Add(tree.Add(_newObj));
            }
            else if (index == 3)
            {
                Beech tree = new Beech();
                World.Children.Add(tree.Add(_newObj));
            }
            else if (index == 4)
            {
                Linden tree = new Linden();
                World.Children.Add(tree.Add(_newObj));
            }
            else if (index == 5)
            {
                Oak tree = new Oak();
                World.Children.Add(tree.Add(_newObj));
            }
            Canvas.SetTop(_newObj, rand.Next(170, 350));
            Canvas.SetLeft(_newObj, rand.Next(20, 520));
            Action(_newObj);
        }
    }
}
