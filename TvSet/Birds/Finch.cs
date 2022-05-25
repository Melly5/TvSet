using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TvSet
{
	public class Finch : Bird1
	{
		string _string;
        Brush color;

		public new Rectangle Add(Rectangle _newBird)
		{
			ImageBrush birdImage = new ImageBrush();

			birdImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Birds/bird5.png", UriKind.Relative));
			_newBird.Height = 60;
			_newBird.Width = 75;
			_newBird.Name = "Bird";
			_newBird.Fill = birdImage;
			_newBird.Tag = 4;

			return _newBird;
		}
		public (string,Brush) CheckCondition(double temp, double hum)
		{
            if (temp < -40 & hum < 65 | temp > 30 & hum > 55)
            {
                color = Brushes.Red;
                _string = "Птица мертва";
               
            }
            else if (temp < -40 & hum >= 65 | temp > 30 & hum <= 55)
            {
                color = Brushes.OrangeRed;
                _string = "Птица на грани гибели";
            }
            else if (temp < -10)
            {
                color = Brushes.Orange;
                _string = "Хотелось бы температуру повыше";
            }
            else if (temp >= -10 & temp < 10 & hum >= 40)
            {
                color = Brushes.YellowGreen;
                _string = "Вполне приемлемо";
            }
            else if (temp >= -10 & temp < 10 & hum < 60)
            {
                color = Brushes.Yellow;
                _string = "Хотелось бы воздух повлажнее";
            }
            else if (temp >= 15 & temp < 30 & hum >= 55 & hum <= 70)
            {
                color = Brushes.Green;
                _string = "Великолепные ощущения";
            }
            else if (temp >= 15 & temp < 30 & (hum < 55 | hum > 70))
            {
                color = Brushes.GreenYellow;
                _string = "Мне довольно таки хорошо";
            }
            else if (temp >= 40)
            {
                color = Brushes.OrangeRed;
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
