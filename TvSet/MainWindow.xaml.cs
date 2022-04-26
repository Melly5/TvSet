using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace TvSet
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rand = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Click_t(object sender, RoutedEventArgs e)
        {
            ImageBrush treeImage = new ImageBrush();
            AddTree addobj = new AddTree();
            World.Children.Add(addobj.add(treeImage, rand));
        }
        private void Click_a(object sender, RoutedEventArgs e)
        {
            ImageBrush animalImage = new ImageBrush();
            AddAnimal addobj = new AddAnimal();
            World.Children.Add(addobj.add(animalImage,rand));
        }
        private void Click_b(object sender, RoutedEventArgs e)
        {
            ImageBrush birdImage = new ImageBrush();
            AddBird addobj = new AddBird();
            World.Children.Add(addobj.add(birdImage, rand));
        }




    }
}
