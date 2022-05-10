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
        private Rectangle _newBird;
        
        public Rectangle AddBird(int ind)
        {
            count++;
            CountObjects = count.ToString();
            ImageBrush birdImage = new ImageBrush();
            _newBird = new Rectangle();
            switch (ind)
            {
                case 1:
                    birdImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Birds/bird1.png", UriKind.Relative));
                    _newBird.Height = _newBird.ActualHeight + 60;
                    _newBird.Width = _newBird.ActualWidth + 60;
                    break;
                case 2:
                    birdImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Birds/bird2.png", UriKind.Relative));
                    _newBird.Height = _newBird.ActualHeight + 50;
                    _newBird.Width = _newBird.ActualWidth + 60;
                    break;
                case 3:
                    birdImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Birds/bird3.png", UriKind.Relative));
                    _newBird.Height = _newBird.ActualHeight + 70;
                    _newBird.Width = _newBird.ActualWidth + 70;
                    break;
                case 4:
                    birdImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Birds/bird4.png", UriKind.Relative));
                    _newBird.Height = _newBird.ActualHeight + 50;
                    _newBird.Width = _newBird.ActualWidth + 50;
                    break;
                case 5:
                    birdImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Birds/bird5.png", UriKind.Relative));
                    _newBird.Height = _newBird.ActualHeight + 60;
                    _newBird.Width = _newBird.ActualWidth + 75;
                    break;
            }
            _newBird.Name = "Bird";
            _newBird.Fill = birdImage;
            _newBird.Tag = ind - 1;
            _newBird.MouseDown += Rectangle_OnMouseDown;

            Canvas.SetTop(_newBird, rand.Next(30, 180));
            Canvas.SetLeft(_newBird, rand.Next(30, 540));
            return _newBird;

        }

    }
}
