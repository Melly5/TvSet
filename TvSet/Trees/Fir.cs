using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TvSet
{
	public class Fir : Tree1
	{
        string _string;
        Brush color;
        public new Rectangle Add(Rectangle _newTree)
        {
            ImageBrush treeImage = new ImageBrush();

            treeImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Trees/tree1.png", UriKind.Absolute));
            _newTree.Height = 120;
            _newTree.Width = 120;
            _newTree.Name = "Tree";
            _newTree.Fill = treeImage;
            _newTree.Tag = 0;

            return _newTree;
        }
        public (string, Brush) CheckCondition(double temp, double hum)
        {
            if (temp <= -35 & hum <= 15 | temp >= 35 & hum >= 85)
            {
                color = Brushes.Red;
                _string = "Ваше дерево мертво";
            }
            else if (temp < -35 & hum > 15 | temp >= 25 & temp < 35 & hum >= 80)
            {
                color = Brushes.DarkRed;
                _string = "Дерево на грани гибели";
            }
            else if (temp > -35 & temp < 0)
            {
                color = Brushes.OrangeRed;
                _string = "Холодно, но приемлемо";
            }
            else if (temp >= 0 & temp < 10 & hum < 50)
            { 
                color = Brushes.DarkOrange;
                _string = "Хотелось бы побольше влажности";
            }
            else if (temp >= 0 & temp < 10 & hum >= 80)
            {
                color = Brushes.Yellow;
                _string = "Хотелось бы более сухого воздуха";
            }
            else if (temp >= 0 & temp < 15 & hum >= 50 | temp >= 25 & temp < 35 & hum >= 50 & hum < 80)
            {
                color = Brushes.YellowGreen;
                _string = "Вполне приемлемо";
            }
            else if (temp >= 15 & temp < 25 & hum >= 50)
            {
                color = Brushes.Green;
                _string = "Чувствую себя прекрасно";
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
