using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace TvSet
{
    public partial class MainWindow : Window
    {
        private void Click_t(object sender, RoutedEventArgs e)
        {
            ImageBrush treeImage = new ImageBrush();
            AddTree newone = new AddTree();
            World.Children.Add(newone.addT(treeImage, rand));
        }
        private void Click_a(object sender, RoutedEventArgs e)
        {
            ImageBrush animalImage = new ImageBrush();
            AddAnimal newone = new AddAnimal();
            World.Children.Add(newone.addA(animalImage, rand));
        }
        private void Click_b(object sender, RoutedEventArgs e)
        {
            ImageBrush birdImage = new ImageBrush();
            AddBird newone = new AddBird();
            World.Children.Add(newone.addB(birdImage, rand));
        }
        MediaPlayer ClickSound = new MediaPlayer();
        /*private void click_cat(object sender, RoutedEventArgs e)
        {
            ClickSound.Open(new Uri("/Sounds/meow.mp3", UriKind.Relative));
            ClickSound.Play();
        }*/

    }
}
