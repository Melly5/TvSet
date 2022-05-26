using System.Windows.Media;
using System.Windows.Shapes;

namespace TvSet
{
	public class Wolf : Animal1
	{
		string _string;
        Brush color;
        public override void Type() { }
        public new Rectangle Add(Rectangle _newAnimal)
		{
            ImageBrush animalImage = new ImageBrush();

            animalImage.ImageSource = Images.GetImage("Animals.animal1.png");
            _newAnimal.Height = 80;
            _newAnimal.Width = 115;
            _newAnimal.Name = "Animal";
            _newAnimal.Fill = animalImage;
            _newAnimal.Tag = 0;

            return _newAnimal;
        }

		public (string, Brush) CheckCondition(double temp, double hum)
		{
            if (temp > 35 & hum > 85)
            {
                color = Brushes.Red;
                _string = "Волк мертв";              
            }
            else if (temp > 35 & hum <= 85)
            {
                color = Brushes.OrangeRed;
                _string = "Волк на грани гибели";
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
            else
            {
                color = Brushes.GreenYellow;
                _string = "Вполне приемлемо";
            }

            return (_string, color);
		}
	}
}
