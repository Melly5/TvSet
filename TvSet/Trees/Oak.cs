using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TvSet
{
	public class Oak : Tree1
	{
        string _string;
        Brush color;

        public new Rectangle Add(Rectangle _newTree)
        {
            ImageBrush treeImage = new ImageBrush();

            treeImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Trees/tree5.png", UriKind.Relative));
            _newTree.Height = 130;
            _newTree.Width = 140;
            _newTree.Name = "Tree";
            _newTree.Fill = treeImage;
            _newTree.Tag = 4;

            return _newTree;
        }
        public (string, Brush) CheckCondition(double temp, double hum)
        {
            if (temp < -30 & hum < 55| temp > 40)
            {
                 color = Brushes.Red;
                _string = "Ваше дерево мертво";

            }
            if (temp < -30 & hum > 55)
            {
                color = Brushes.OrangeRed;
                _string = "Ваше дерево на грани гибели";
            }
            else if (temp >= -30 & temp < 0)
            {
                color = Brushes.Orange;
                _string = "Хотелось бы температуру повыше";
            }
            else if (temp >= 0 & temp < 15 & hum >= 55)
            {
                color = Brushes.YellowGreen;
                _string = "Вполне приемлемо";
            }
            else if (temp >= 0 & temp < 15 & hum < 55)
            {
                color = Brushes.Yellow;
                _string = "Хотелось бы воздух повлажнее";
            }
            else if (temp >= 15 & temp < 30 & hum >= 55 & hum <= 70)
            {
                color = Brushes.Green;
                _string = "Великолепные ощущения";
            }
            else if (temp >= 15 & temp < 40 & (hum < 55 | hum > 70))
            {
                color = Brushes.GreenYellow;
                _string = "Мне довольно таки хорошо";
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
