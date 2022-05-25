using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TvSet
{
	public class Fox : Animal1
	{
        string _string;
        Brush color;

        public new Rectangle Add(Rectangle _newAnimal)
        {
            ImageBrush animalImage = new ImageBrush();

            animalImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Animals/animal3.png", UriKind.Relative));
            _newAnimal.Height = 80;
            _newAnimal.Width = 90;
            _newAnimal.Name = "Animal";
            _newAnimal.Fill = animalImage;
            _newAnimal.Tag = 2;

            return _newAnimal;
        }

        public (string, Brush) CheckCondition(double temp, double hum)
        {
            if (temp < -45 & hum > 75)
            {
                color = Brushes.Red;
                _string = "Лиса мертва";               
            }
            else if (temp < -45 & hum <= 75)
            {
                color = Brushes.OrangeRed;
                _string = "Лиса на грани гибели";
            }
            else if (temp < -10)
            {
                color = Brushes.Yellow;
                _string = "Хотелось бы температуру повыше";
            }
            else if (temp >= -10 & temp < 10 & hum >= 40)
            {
                color = Brushes.YellowGreen;
                _string = "Вполне приемлемо";
            }
            else if (temp >= -10 & temp < 10 & hum < 50)
            {
                color = Brushes.Yellow;
                _string = "Хотелось бы воздух повлажнее";
            }
            else if (temp >= 15 & temp < 30 & hum >= 60 & hum <= 70)
            {
                color = Brushes.Green;
                _string = "Великолепные ощущения";
            }
            else if (temp >= 15 & temp < 30 & (hum < 60 | hum > 70))
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
