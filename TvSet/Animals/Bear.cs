using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TvSet
{
	public class Bear : Animal1
	{
        string _string;
        Brush color;
        public override void Type() { }
        public new Rectangle Add(Rectangle _newAnimal)
        {
            ImageBrush animalImage = new ImageBrush();

            animalImage.ImageSource = Images.GetImage("Animals.animal4.png"); ;
            _newAnimal.Height = 130;
            _newAnimal.Width = 140;
            _newAnimal.Name = "Animal";
            _newAnimal.Fill = animalImage;
            _newAnimal.Tag = 3;

            return _newAnimal;
        }

        public (string, Brush) CheckCondition(double temp, double hum)
        {
            if (temp < -47 & hum < 25)
            {
                color = Brushes.Red;
                _string = "Медведь мертв";
              
            }
            else if (temp < -47 & hum <= 25)
            {
                color = Brushes.OrangeRed;
                _string = "Ваш медведь на грани гибели";
            }
            else if (temp >= -40 & temp < 5 & hum >= 40)
            {
                color = Brushes.GreenYellow;
                _string = "Вполне приемлемо";
            }
            else if (temp >= -10 & temp < 5 & hum < 50)
            {
                color = Brushes.Yellow;
                _string = "Хотелось бы воздух повлажнее";
            }
            else if (temp >= 5 & temp < 15 & hum >= 60 & hum <= 70)
            {
                color = Brushes.Green;
                _string = "Великолепные ощущения";
            }
            else if (temp >= 5 & temp < 15 & (hum < 60 | hum > 70))
            {
                color = Brushes.GreenYellow;
                _string = "Мне довольно таки хорошо";
            }
            else if (temp >= 15 & temp < 35)
            {
                color = Brushes.Yellow;
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
