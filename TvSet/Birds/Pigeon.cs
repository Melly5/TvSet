using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TvSet
{
	public class Pigeon : Bird1
	{
		string _string;
        Brush color;
        public override void Type() { }

        public new Rectangle Add(Rectangle _newBird)
		{
			ImageBrush birdImage = new ImageBrush();

			birdImage.ImageSource = Images.GetImage("Birds.bird3.png");
            _newBird.Height = 70;
			_newBird.Width = 70;
			_newBird.Name = "Bird";
			_newBird.Fill = birdImage;
			_newBird.Tag = 2;

			return _newBird;
		}
        public Dictionary<string, Brush> dictionary = new Dictionary<string, Brush>();

		public (string,Brush) CheckCondition(double temp, double hum)
		{
            if (temp < -45 & hum < 65)
            {
                _string = "Птица мертва";
                color = Brushes.Red;
                          
            }
            else if (temp < -45 & hum > 50)
            {
                _string = "Птица на грани гибели";
                color = Brushes.OrangeRed;
            
            }
            else if (temp < 0)
            {
                _string = "Хотелось бы температуру повыше"; 
                color =  Brushes.Orange;           
            }
            else if (temp >= 0 & temp < 15 & hum >= 40)
            {
                _string = "Вполне приемлемо";
                color = Brushes.YellowGreen;
               
            }
            else if (temp >= 0 & temp < 15 & hum < 60)
            {
                _string = "Хотелось бы воздух повлажнее";
                color = Brushes.Yellow;
            }
            else if (temp >= 15 & temp < 30 & hum >= 55 & hum <= 70)
            {
                _string = "Великолепные ощущения";
                color = Brushes.Green;
            }
            else if (temp >= 15 & temp < 30 & (hum < 55 | hum > 70))
            {
                _string = "Мне довольно таки хорошо";
                color = Brushes.GreenYellow;
            }
            else if (temp >= 40 && hum < 60)
            {
                _string = "Ух, хотелось бы похолоднее";
                color = Brushes.OrangeRed;
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
