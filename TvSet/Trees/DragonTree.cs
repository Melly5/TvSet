using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TvSet
{
	public class DragonTree : Tree1
	{
        string _string;
        Brush color;
        public override void Type() { }
        public new Rectangle Add(Rectangle _newTree)
        {
            ImageBrush treeImage = new ImageBrush();

            treeImage.ImageSource = Images.GetImage("Trees.tree2.png");
            _newTree.Height = 120;
            _newTree.Width = 140;
            _newTree.Name = "Tree";
            _newTree.Fill = treeImage;
            _newTree.Tag = 1;

            return _newTree;
        }
        public (string, Brush) CheckCondition(double temp, double hum)
        {
            if (temp < -2 & hum < 55)
            {
                _string = "Ваше дерево мертво";
                color = Brushes.Red;
            }
            else if (temp >= -2 & temp < 10 | temp < -2 & hum >= 55)
            {
                color = Brushes.OrangeRed;
                _string = "Хотелось бы температуру повыше";
            }
            else if (temp >= 10 & temp < 16 & hum >= 40)
            {
                color = Brushes.Yellow;
                _string = "Вполне приемлемо";
            }
            else if (temp >= 15 & temp < 23 & hum >= 50)
            {
                color = Brushes.YellowGreen;
                _string = "Чувствую себя хорошо";
            }
            else if (temp >= 23 & temp < 40 & hum >= 50 & hum <= 70)
            {
                color = Brushes.Green;
                _string = "Великолепные ощущения";
            }
            else if (temp >= 23 & temp < 40 & (hum < 50 | hum > 70))
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

            return (_string,color);
        }
    }
}
