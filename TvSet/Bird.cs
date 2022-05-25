using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TvSet
{
    public class Bird
    {
        
        static Random rand = new Random();
        public Rectangle AddBird(Rectangle _newBird,int ind)
        {
            ImageBrush birdImage = new ImageBrush();
            switch (ind)
            {
                case 1:
                    birdImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Birds/bird1.png", UriKind.Relative));
                    _newBird.Height = 60;
                    _newBird.Width = 60;
                    break;
                case 2:
                    birdImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Birds/bird2.png", UriKind.Relative));
                    _newBird.Height = 50;
                    _newBird.Width = 60;
                    break;
                case 3:
                    birdImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Birds/bird3.png", UriKind.Relative));
                    _newBird.Height = 70;
                    _newBird.Width = 70;
                    break;
                case 4:
                    birdImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Birds/bird4.png", UriKind.Relative));
                    _newBird.Height = 50;
                    _newBird.Width = 50;
                    break;
                case 5:
                    birdImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Birds/bird5.png", UriKind.Relative));
                    _newBird.Height = 60;
                    _newBird.Width = 75;
                    break;
            }
            _newBird.Name = "Bird";
            _newBird.Fill = birdImage;
            _newBird.Tag = ind - 1;

            Canvas.SetTop(_newBird, rand.Next(30, 180));
            Canvas.SetLeft(_newBird, rand.Next(30, 540));
            return _newBird;

        }

    }
}
