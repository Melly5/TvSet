using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TvSet
{
	public class Bunny : Animal1
	{
		string _string;
        Brush color;
        public override void Type() { }

        public new Rectangle Add(Rectangle _newAnimal)
        {
            ImageBrush animalImage = new ImageBrush();

            animalImage.ImageSource = Images.GetImage("Animals.animal5.png");
            _newAnimal.Height = 60;
            _newAnimal.Width = 80;
            _newAnimal.Name = "Animal";
            _newAnimal.Fill = animalImage;
            _newAnimal.Tag = 4;

            return _newAnimal;
        }
        public (string, Brush) CheckCondition(double temp, double hum)
        {
            if (temp > 35 & hum > 75)
            {
                color = Brushes.Red;
                _string = "Зайчик мертв";
               
            }
            else if (temp > 35 & hum <= 75)
            {
                color = Brushes.OrangeRed;
                _string = "Ваш заяц на грани гибели";
            }
            else if (temp < -30)
            {
                color = Brushes.Orange;
                _string = "Хотелось бы температуру повыше";
            }
            else if (temp >= -30 & temp < 10 & hum >= 40)
            {
                color = Brushes.GreenYellow;
                _string = "Вполне приемлемо";
            }
            else if (temp >= -10 & temp < 10 & hum < 50)
            {
                color = Brushes.Yellow;
                _string = "Хотелось бы воздух повлажнее";
            }
            else if (temp >= 10 & temp < 20 & hum >= 50 & hum <= 70)
            {
                color = Brushes.Green;
                _string = "Великолепные ощущения";
            }
            else if (temp >= 10 & temp < 20 & (hum < 50 | hum > 70)| temp >= 20 & temp < 40)
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
