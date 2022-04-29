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
        DropShadowEffect effect = new DropShadowEffect();
        private void Rectangle_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            var mouseWasDownOn = e.Source as FrameworkElement;

            if (mouseWasDownOn != null)
            {
                SelectedCanvasObject = mouseWasDownOn;
                InfoGrid.Visibility = Visibility.Visible;
                kind.Text = NameT[random];
 
                effect.Color = Colors.Red;
                effect.Direction = -50;
                effect.BlurRadius = 5;
                effect.ShadowDepth = 6;
                SelectedCanvasObject.Effect = effect;
            }
        }
        private void Rectangle_OnMouseUp(object sender, MouseEventArgs e)
        {
            var mouseWasUpOn = e.Source as FrameworkElement;

            if (mouseWasUpOn != null)
            {
                SelectedCanvasObject = mouseWasUpOn;
                effect.Color = Colors.Transparent;
                effect.Direction = 0;
                effect.BlurRadius = 0;
                effect.ShadowDepth = 0;
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
