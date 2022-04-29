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
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            _selectedItem = selectedItem;
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
        }
        private void Close(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
