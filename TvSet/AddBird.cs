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
        int _countB = 0;
        private Rectangle _newBird;
        public Rectangle addB(ImageBrush birdImage, Random rand)
        {
            int random = rand.Next(1, 5);
            _countB++;
            switch (random)
            {
                case 1:
                    birdImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Birds/bird1.png", UriKind.Relative));
                    break;
                case 2:
                    birdImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Birds/bird2.png", UriKind.Relative));
                    break;
                case 3:
                    birdImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Birds/bird3.png", UriKind.Relative));
                    break;
                case 4:
                    birdImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Birds/bird4.png", UriKind.Relative));
                    break;
                case 5:
                    birdImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Birds/bird5.png", UriKind.Relative));
                    break;
            }
            _newBird = new Rectangle
            {
                Tag = _countB.ToString(CultureInfo.InvariantCulture),           
                Height = rand.Next(70, 100),
                Width = rand.Next(40, 50),
                Fill = birdImage
            };
            _newBird.MouseDown += Rectangle_OnMouseDown;

            Canvas.SetTop(_newBird, rand.Next(40, 150));
            Canvas.SetLeft(_newBird, rand.Next(30, 300));
            return _newBird;

        }
    }
}
