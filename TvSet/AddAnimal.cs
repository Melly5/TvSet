using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TvSet
{
    public partial class MainWindow : Window
    {
  
        private Rectangle _newAnimal;

        public Rectangle AddAnimal(int ind)
        {
            ImageBrush animalImage = new ImageBrush();
            switch (ind)
            {
                case 1:
                    animalImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Animals/animal1.png", UriKind.Relative));
                    break;
                case 2:
                    animalImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Animals/animal2.png", UriKind.Relative));
                    break;
                case 3:
                    animalImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Animals/animal3.png", UriKind.Relative));
                    break;
                case 4:
                    animalImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Animals/animal4.png", UriKind.Relative));
                    break;
                case 5:
                    animalImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Animals/animal5.png", UriKind.Relative));
                    break;
            }
            _newAnimal = new Rectangle
            {
                Tag = new Guid().ToString(),
                Height = rand.Next(70, 100),
                Width = rand.Next(40, 50),
                Fill = animalImage
            };
            _newAnimal.MouseDown += Rectangle_OnMouseDown;

            Canvas.SetTop(_newAnimal, rand.Next(40, 150));
            Canvas.SetLeft(_newAnimal, rand.Next(30, 300));
            return _newAnimal;           
        }
        private void Click_Animal(object sender, RoutedEventArgs e)
        {
            if (_selectedItem == null)
                return;

            int index = _selectedItem.TabIndex + 1;
            World.Children.Add(AddAnimal(index));
        }
    }
}
