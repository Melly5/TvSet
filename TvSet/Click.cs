using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace TvSet
{
    public partial class MainWindow : Window
    {
        private void Click_t(object sender, RoutedEventArgs e)
        {
            ImageBrush treeImage = new ImageBrush();      
            World.Children.Add(addT(treeImage, rand));
        }
        private void Click_a(object sender, RoutedEventArgs e)
        {
            ImageBrush animalImage = new ImageBrush();         
            World.Children.Add(addA(animalImage, rand));
        }
        private void Click_b(object sender, RoutedEventArgs e)
        {
            ImageBrush birdImage = new ImageBrush();       
            World.Children.Add(addB(birdImage, rand));
        }
        /*MediaPlayer ClickSound = new MediaPlayer();

        private void click_cat(object sender, RoutedEventArgs e)
        {
            ClickSound.Open(new Uri("/Sounds/meow.mp3", UriKind.Relative));
            ClickSound.Play();
        }
        */
        private void Rectangle_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            var mouseWasDownOn = e.Source as FrameworkElement;

            if (mouseWasDownOn != null)
            {
                SelectedCanvasObject = mouseWasDownOn;
                InfoGrid.Visibility = Visibility.Visible;
            }
        }
    }
}
