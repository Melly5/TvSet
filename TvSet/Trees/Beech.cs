using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TvSet
{
	public class Beech : Tree1
	{
        string _string;
        Brush color;

        public new Rectangle Add(Rectangle _newTree)
        {
            ImageBrush treeImage = new ImageBrush();

            treeImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Trees/tree3.png", UriKind.Relative));
            _newTree.Height = 150;
            _newTree.Width = 120;
            _newTree.Name = "Tree";
            _newTree.Fill = treeImage;
            _newTree.Tag = 2;

            return _newTree;
        }
        public (string, Brush) CheckCondition(double temp, double hum)
        {
            if (temp < -25 & hum < 55)
            {
                color = Brushes.Red;
                _string = "Ваше дерево мертво";
            }
            else if (temp >= -25 & temp < 0 | temp < -25 & hum >= 55)
            {
                color = Brushes.OrangeRed;
                _string = "Хотелось бы температуру повыше";
            }
            else if (temp >= 0 & temp < 15 & hum >= 40)
            {
                color = Brushes.YellowGreen;
                _string = "Вполне приемлемо";
            }
            else if (temp >= 0 & temp < 15 & hum < 40)
            {
                color = Brushes.Yellow;
                _string = "Хотелось бы воздух повлажнее";
            }
            else if (temp >= 15 & temp < 30 & hum >= 50 & hum <= 70)
            {
                color = Brushes.Green;
                _string = "Великолепные ощущения";
            }
            else if (temp >= 15 & temp < 40 & (hum < 50 | hum > 70))
            {
                color = Brushes.GreenYellow;
                _string = "Мне довольно таки хорошо";
            }
            else if (temp >= 40)
            {
                color = Brushes.Orange;
                _string = "Ух, хотелось бы похолоднее";
            }
            else
            {
                color = Brushes.GreenYellow;
                _string = "Вполне приемлемо";
            }

            return (_string, color);
        }
    }
}
