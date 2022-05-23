using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TvSet
{
    public class Animal
    {
        private Rectangle _newAnimal;
        static Random rand = new Random();

        public Rectangle AddAnimal(int ind, MainWindow main)
        {
            main.AddCount();

            ImageBrush animalImage = new ImageBrush();
            _newAnimal = new Rectangle();
            switch (ind)
            {
                case 1:
                    animalImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Animals/animal1.png", UriKind.Relative));
                    _newAnimal.Height = 80;
                    _newAnimal.Width = 115;
                    break;
                case 2:
                    animalImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Animals/animal2.png", UriKind.Relative));
                    _newAnimal.Height = 60;
                    _newAnimal.Width = 60;
                    break;
                case 3:
                    animalImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Animals/animal3.png", UriKind.Relative));
                    _newAnimal.Height = 80;
                    _newAnimal.Width = 90;
                    break;
                case 4:
                    animalImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Animals/animal4.png", UriKind.Relative));
                    _newAnimal.Height = 130;
                    _newAnimal.Width = 140;
                    break;
                case 5:
                    animalImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Animals/animal5.png", UriKind.Relative));
                    _newAnimal.Height = 60;
                    _newAnimal.Width = 80;
                    break;
            }
            _newAnimal.Fill = animalImage;
            _newAnimal.Tag = ind - 1;
            main.AddAction(_newAnimal);
            _newAnimal.Name = "Animal";
            Canvas.SetTop(_newAnimal, rand.Next(180, 380));
            Canvas.SetLeft(_newAnimal, rand.Next(20, 520));
            return _newAnimal;           
        }
    }
}
