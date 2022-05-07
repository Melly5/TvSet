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
            _newAnimal = new Rectangle();
            switch (ind)
            {
                case 1:
                    animalImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Animals/animal1.png", UriKind.Relative));
                    _newAnimal.Height = _newAnimal.ActualHeight + 80;
                    _newAnimal.Width = _newAnimal.ActualWidth + 115;
                    break;
                case 2:
                    animalImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Animals/animal2.png", UriKind.Relative));
                    _newAnimal.Height = _newAnimal.ActualHeight + 60;
                    _newAnimal.Width = _newAnimal.ActualWidth + 60;
                    break;
                case 3:
                    animalImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Animals/animal3.png", UriKind.Relative));
                    _newAnimal.Height = _newAnimal.ActualHeight + 80;
                    _newAnimal.Width = _newAnimal.ActualWidth + 90;
                    break;
                case 4:
                    animalImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Animals/animal4.png", UriKind.Relative));
                    _newAnimal.Height = _newAnimal.ActualHeight + 130;
                    _newAnimal.Width = _newAnimal.ActualWidth + 140;
                    break;
                case 5:
                    animalImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Animals/animal5.png", UriKind.Relative));
                    _newAnimal.Height = _newAnimal.ActualHeight + 60;
                    _newAnimal.Width = _newAnimal.ActualWidth + 80;
                    break;
            }
            _newAnimal.Fill = animalImage;
            _newAnimal.Tag = ind - 1;
            _newAnimal.MouseDown += Rectangle_OnMouseDown;

            Canvas.SetTop(_newAnimal, rand.Next(40, 150));
            Canvas.SetLeft(_newAnimal, rand.Next(30, 300));
            return _newAnimal;           
        }

    }
}
