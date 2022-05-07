using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Shapes;

namespace TvSet
{
    public partial class MainWindow : Window
    {
        /*MediaPlayer ClickSound = new MediaPlayer();

        private void click_cat(object sender, RoutedEventArgs e)
        {
            ClickSound.Open(new Uri("/Sounds/meow.mp3", UriKind.Relative));
            ClickSound.Play();
        }
        */
        string boxName;
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            _selectedItem = selectedItem;
            boxName = comboBox.Name;

        }
        private void Click_tree(object sender, RoutedEventArgs e)
        {
            if (_selectedItem == null)
                return;

            int index = _selectedItem.TabIndex + 1;
            World.Children.Add(AddTree(index));            
        }
        private void Click_bird(object sender, RoutedEventArgs e)
        {
            if (_selectedItem == null)
                return;

            int index = _selectedItem.TabIndex + 1;
            World.Children.Add(AddBird(index));
        }
        private void Click_animal(object sender, RoutedEventArgs e)
        {
            if (_selectedItem == null)
                return;

            int index = _selectedItem.TabIndex + 1;
            World.Children.Add(AddAnimal(index));
        }
        
        DropShadowEffect effect = new DropShadowEffect();
        private void Rectangle_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            var mouseWasDownOn = e.Source as FrameworkElement;

            if (mouseWasDownOn != null)
            {
                if(SelectedCanvasObject != null)
				{
                    SelectedCanvasObject.Effect = null;
                }
                SelectedCanvasObject = mouseWasDownOn;
                kind.Text = count.ToString();
                //kind.Text = Kind[0,(int)SelectedCanvasObject.Tag];
                information.Text= Information[0, (int)SelectedCanvasObject.Tag];
                InfoGrid.Visibility = Visibility.Visible;
                effect.Color = Colors.Red;
                effect.Direction = -50;
                effect.BlurRadius = 5;
                effect.ShadowDepth = 6;
                SelectedCanvasObject.Effect = effect;
            }
        }

        private void DeleteObject(object sender, RoutedEventArgs e)
        {
            World.Children.Remove(SelectedCanvasObject as UIElement);
            count--;
          

        }
        private void DeleteAll(object sender, RoutedEventArgs e)
        {
            World.Children.Clear();
            count = 0;
        

        }
        private void Close(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
        private void Temperature_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            temp = (int)Temperature.Value;
            Check_condition(temp, hum);
        }
        private void Humidity_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            hum = (int)Humidity.Value;
            Check_condition(temp, hum);
        }
    }
}
