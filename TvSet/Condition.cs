using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace TvSet
{
    public partial class MainWindow : Window
    {
        int ind;
        public void Check_condition(double temp, double hum)
        {
            ind = (int)SelectedCanvasObject.Tag +1;
            if (SelectedCanvasObject.Name=="Tree")
			{              
                switch(ind)
				{
                    case 1:
                        if (temp <= -35 & hum <= 15)
                        {
                            Condition.Fill = Brushes.Red;
                            Condition_text.Text = "Это дерево мертво";
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                        }
                        else if (temp < -35 & hum > 15)
                        {
                            Condition.Fill = Brushes.DarkRed;
                            Condition_text.Text = "Дерево на грани гибели";
                        }
                        else if (temp > -35 & temp < 0)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Холодно, но приемлемо";
                        }
                        else if (temp >= 0 & temp < 10 & hum < 50)
                        {
                            Condition.Fill = Brushes.DarkOrange;
                            Condition_text.Text = "Хотелось бы побольше влажности";
                        }
                        else if (temp >= 0 & temp < 10 & hum >= 80)
                        {
                            Condition.Fill = Brushes.Yellow;
                            Condition_text.Text = "Хотелось бы более сухого воздуха";
                        }
                        else if (temp >= 0 & temp < 15 & hum >= 50)
                        {
                            Condition.Fill = Brushes.YellowGreen;
                            Condition_text.Text = "Вполне приемлемо";
                        }
                        else if (temp >= 15 & temp < 25 & hum >= 50)
                        {
                            Condition.Fill = Brushes.Green;
                            Condition_text.Text = "Чувствую себя прекрасно";
                        }
                        else if (temp >= 25 & temp < 35 & hum >= 50 & hum < 80)
                        {
                            Condition.Fill = Brushes.YellowGreen;
                            Condition_text.Text = "Вполне приемлемо";
                        }
                        else if (temp >= 25 & temp < 35 & hum >= 80)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Растение на грани гибели";
                        }
                        else if (temp >= 35 & hum >= 85)
                        {
                            Condition.Fill = Brushes.Red;
                            Condition_text.Text = "Ваше дерево мертво";
                        }
                        return;
                    case 2:
                        if (temp < -2 & hum < 55)
                        {
                            Condition.Fill = Brushes.Red;
                            Condition_text.Text = "Ваше дерево мертво";
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                        }
                        else if (temp >= -2 & temp < 10 | temp < -2 & hum >= 55)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Хотелось бы температуру повыше";
                        }
                        else if (temp >= 10 & temp < 16 & hum >= 40)
                        {
                            Condition.Fill = Brushes.Yellow;
                            Condition_text.Text = "Вполне приемлемо";
                        }
                        else if (temp >= 15 & temp < 23 & hum >= 50)
                        {
                            Condition.Fill = Brushes.YellowGreen;
                            Condition_text.Text = "Чувствую себя хорошо";
                        }
                        else if (temp >= 23 & temp < 40 & hum >= 50 & hum <= 70)
                        {
                            Condition.Fill = Brushes.Green;
                            Condition_text.Text = "Великолепные ощущения";
                        }
                        else if (temp >= 23 & temp < 40 & (hum < 50 | hum > 70))
                        {
                            Condition.Fill = Brushes.GreenYellow;
                            Condition_text.Text = "Мне довольно таки хорошо";
                        }
                        else if (temp >= 40)
                        {
                            Condition.Fill = Brushes.Orange;
                            Condition_text.Text = "Ух, хотелось бы похолоднее";
                        }
                        return;
                    case 3:
                        if (temp < -25 & hum < 55)
                        {
                            Condition.Fill = Brushes.Red;
                            Condition_text.Text = "Ваше дерево мертво";
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                        }
                        else if (temp >= -25 & temp < 0 | temp < -25 & hum >= 55)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Хотелось бы температуру повыше";
                        }
                        else if (temp >= 0 & temp < 15 & hum >= 40)
                        {
                            Condition.Fill = Brushes.YellowGreen;
                            Condition_text.Text = "Вполне приемлемо";
                        }
                        else if (temp >= 0 & temp < 15 & hum < 40)
                        {
                            Condition.Fill = Brushes.Yellow;
                            Condition_text.Text = "Хотелось бы воздух повлажнее";
                        }
                        else if (temp >= 15 & temp < 30 & hum >= 50 & hum <= 70)
                        {
                            Condition.Fill = Brushes.Green;
                            Condition_text.Text = "Великолепные ощущения";
                        }
                        else if (temp >= 15 & temp < 40 & (hum < 50 | hum > 70))
                        {
                            Condition.Fill = Brushes.GreenYellow;
                            Condition_text.Text = "Мне довольно таки хорошо";
                        }
                        else if (temp >= 40)
                        {
                            Condition.Fill = Brushes.Orange;
                            Condition_text.Text = "Ух, хотелось бы похолоднее";
                        }
                        return;
                    case 4:
                        if (temp < -25 & hum < 50)
                        {
                            Condition.Fill = Brushes.Red;
                            Condition_text.Text = "Ваше дерево мертво";
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                        }
                        if (temp < -25 & hum > 50)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Ваше дерево на грани гибели";
                        }
                        else if (temp >= -25 & temp < 0)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Хотелось бы температуру повыше";
                        }
                        else if (temp >= 0 & temp < 15 & hum >= 40)
                        {
                            Condition.Fill = Brushes.YellowGreen;
                            Condition_text.Text = "Вполне приемлемо";
                        }
                        else if (temp >= 0 & temp < 15 & hum < 60)
                        {
                            Condition.Fill = Brushes.Yellow;
                            Condition_text.Text = "Хотелось бы воздух повлажнее";
                        }
                        else if (temp >= 15 & temp < 30 & hum >= 60 & hum <= 80)
                        {
                            Condition.Fill = Brushes.Green;
                            Condition_text.Text = "Великолепные ощущения";
                        }
                        else if (temp >= 15 & temp < 40 & (hum < 60 | hum > 80))
                        {
                            Condition.Fill = Brushes.GreenYellow;
                            Condition_text.Text = "Мне довольно таки хорошо";
                        }
                        else if (temp >= 40)
                        {
                            Condition.Fill = Brushes.Orange;
                            Condition_text.Text = "Ух, хотелось бы похолоднее";
                        }
                        return;
                    case 5:
                        //альные условия обитания - 20°C и 60 %.Гибельные - -35°C и 50 % ";
                        if (temp < -30 & hum < 55)
                        {
                            Condition.Fill = Brushes.Red;
                            Condition_text.Text = "Ваше дерево мертво";
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                        }
                        if (temp < -30 & hum > 55)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Ваше дерево на грани гибели";
                        }
                        else if (temp >= - 30 & temp < 0)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Хотелось бы температуру повыше";
                        }
                        else if (temp >= 0 & temp < 15 & hum >= 55)
                        {
                            Condition.Fill = Brushes.YellowGreen;
                            Condition_text.Text = "Вполне приемлемо";
                        }
                        else if (temp >= 0 & temp < 15 & hum < 55)
                        {
                            Condition.Fill = Brushes.Yellow;
                            Condition_text.Text = "Хотелось бы воздух повлажнее";
                        }
                        else if (temp >= 15 & temp < 30 & hum >= 55 & hum <= 70)
                        {
                            Condition.Fill = Brushes.Green;
                            Condition_text.Text = "Великолепные ощущения";
                        }
                        else if (temp >= 15 & temp < 40 & (hum < 55 | hum > 70))
                        {
                            Condition.Fill = Brushes.GreenYellow;
                            Condition_text.Text = "Мне довольно таки хорошо";
                        }
                        else if (temp >= 40)
                        {
                            Condition.Fill = Brushes.Orange;
                            Condition_text.Text = "Ух, хотелось бы похолоднее";
                        }
                        return;
                }              
			}
            else if (SelectedCanvasObject.Name == "Bird")
            {
                switch (ind)
                {
                    case 1:
                        if (temp < -40 & hum < 50 | temp > 40 & hum > 60)
                        {
                            Condition.Fill = Brushes.Red;
                            Condition_text.Text = "Птица мертва";
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                        }
                        if (temp < -40 & hum > 50 | temp > 30 & temp < 40 & hum > 60)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Птица на грани гибели";
                        }
                        else if (temp >= -40 & temp < 0)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Хотелось бы температуру повыше";
                        }
                        else if (temp >= 0 & temp < 15 & hum >= 40)
                        {
                            Condition.Fill = Brushes.YellowGreen;
                            Condition_text.Text = "Вполне приемлемо";
                        }
                        else if (temp >= 0 & temp < 15 & hum < 60)
                        {
                            Condition.Fill = Brushes.Yellow;
                            Condition_text.Text = "Хотелось бы воздух повлажнее";
                        }
                        else if (temp >= 15 & temp < 30 & hum >= 50 & hum <= 70)
                        {
                            Condition.Fill = Brushes.Green;
                            Condition_text.Text = "Великолепные ощущения";
                        }
                        else if (temp >= 15 & temp < 30 & (hum < 50 | hum > 70))
                        {
                            Condition.Fill = Brushes.GreenYellow;
                            Condition_text.Text = "Мне довольно таки хорошо";
                        }
                        else if (temp >= 40 && hum < 60)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Ух, хотелось бы похолоднее";
                        }
                        return;
                    case 2:
                        if (temp < -35 & hum < 65)
                        {
                            Condition.Fill = Brushes.Red;
                            Condition_text.Text = "Птица мертва";
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                        }
                        if (temp < -35 & hum > 50)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Птица на грани гибели";
                        }
                        else if (temp < 0)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Хотелось бы температуру повыше";
                        }
                        else if (temp >= 0 & temp < 15 & hum >= 40)
                        {
                            Condition.Fill = Brushes.YellowGreen;
                            Condition_text.Text = "Вполне приемлемо";
                        }
                        else if (temp >= 0 & temp < 15 & hum < 60)
                        {
                            Condition.Fill = Brushes.Yellow;
                            Condition_text.Text = "Хотелось бы воздух повлажнее";
                        }
                        else if (temp >= 15 & temp < 30 & hum >= 55 & hum <= 70)
                        {
                            Condition.Fill = Brushes.Green;
                            Condition_text.Text = "Великолепные ощущения";
                        }
                        else if (temp >= 15 & temp < 30 & (hum < 55 | hum > 70))
                        {
                            Condition.Fill = Brushes.GreenYellow;
                            Condition_text.Text = "Мне довольно таки хорошо";
                        }
                        else if (temp >= 40 && hum < 60)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Ух, хотелось бы похолоднее";
                        }
                        return;
                    case 3:
                       // Идеальные условия обитания - 25°C и 60 %.Гибельные - -48°C и 60 % ";
                        if (temp < -45 & hum < 65)
                        {
                            Condition.Fill = Brushes.Red;
                            Condition_text.Text = "Птица мертва";
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                        }
                        if (temp < -45 & hum > 50)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Птица на грани гибели";
                        }
                        else if (temp < 0)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Хотелось бы температуру повыше";
                        }
                        else if (temp >= 0 & temp < 15 & hum >= 40)
                        {
                            Condition.Fill = Brushes.YellowGreen;
                            Condition_text.Text = "Вполне приемлемо";
                        }
                        else if (temp >= 0 & temp < 15 & hum < 60)
                        {
                            Condition.Fill = Brushes.Yellow;
                            Condition_text.Text = "Хотелось бы воздух повлажнее";
                        }
                        else if (temp >= 15 & temp < 30 & hum >= 55 & hum <= 70)
                        {
                            Condition.Fill = Brushes.Green;
                            Condition_text.Text = "Великолепные ощущения";
                        }
                        else if (temp >= 15 & temp < 30 & (hum < 55 | hum > 70))
                        {
                            Condition.Fill = Brushes.GreenYellow;
                            Condition_text.Text = "Мне довольно таки хорошо";
                        }
                        else if (temp >= 40 && hum < 60)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Ух, хотелось бы похолоднее";
                        }
                        return;
                    case 4:
                        //деальные условия обитания - 15°C и 60%. Гибельные - 35°C и 60%";
                        
                        if (temp < -45 & hum < 65 | temp > 30 & hum > 55)
                        {
                            Condition.Fill = Brushes.Red;
                            Condition_text.Text = "Птица мертва";
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                        }
                        if (temp < -45 & hum >= 65 | temp > 30 & hum <= 55)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Птица на грани гибели";
                        }
                        else if (temp < -10)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Хотелось бы температуру повыше";
                        }
                        else if (temp >= -10 & temp < 10 & hum >= 40)
                        {
                            Condition.Fill = Brushes.YellowGreen;
                            Condition_text.Text = "Вполне приемлемо";
                        }
                        else if (temp >= -10 & temp < 10 & hum < 60)
                        {
                            Condition.Fill = Brushes.Yellow;
                            Condition_text.Text = "Хотелось бы воздух повлажнее";
                        }
                        else if (temp >= 10 & temp < 20 & hum >= 55 & hum <= 70)
                        {
                            Condition.Fill = Brushes.Green;
                            Condition_text.Text = "Великолепные ощущения";
                        }
                        else if (temp >= 10 & temp < 20 & (hum < 55 | hum > 70))
                        {
                            Condition.Fill = Brushes.GreenYellow;
                            Condition_text.Text = "Мне довольно таки хорошо";
                        }               
                        return;
                    case 5:
                        //деальные условия обитания - 20°C и 60 %.Гибельные - -45°C и 60 % ";
                        if (temp < -40 & hum < 65 | temp > 30 & hum > 55)
                        {
                            Condition.Fill = Brushes.Red;
                            Condition_text.Text = "Птица мертва";
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                        }
                        if (temp < -40 & hum >= 65 | temp > 30 & hum <= 55)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Птица на грани гибели";
                        }
                        else if (temp < -10)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Хотелось бы температуру повыше";
                        }
                        else if (temp >= -10 & temp < 10 & hum >= 40)
                        {
                            Condition.Fill = Brushes.YellowGreen;
                            Condition_text.Text = "Вполне приемлемо";
                        }
                        else if (temp >= -10 & temp < 10 & hum < 60)
                        {
                            Condition.Fill = Brushes.Yellow;
                            Condition_text.Text = "Хотелось бы воздух повлажнее";
                        }
                        else if (temp >= 15 & temp < 30 & hum >= 55 & hum <= 70)
                        {
                            Condition.Fill = Brushes.Green;
                            Condition_text.Text = "Великолепные ощущения";
                        }
                        else if (temp >= 15 & temp < 30 & (hum < 55 | hum > 70))
                        {
                            Condition.Fill = Brushes.GreenYellow;
                            Condition_text.Text = "Мне довольно таки хорошо";
                        }
                        else if (temp >= 40)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Ух, хотелось бы похолоднее";
                        }
                        return;
                }
            }
            else if (SelectedCanvasObject.Name == "Animal")
            {
                switch (ind)
                {
                    case 1:
                        if ( temp > 35 & hum > 85)
                        {
                            Condition.Fill = Brushes.Red;
                            Condition_text.Text = "Волк мертв";
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                        }
                        if (temp > 35 & hum <= 85)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Волк на грани гибели";
                        }
                        else if (temp < -10)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Хотелось бы температуру повыше";
                        }
                        else if (temp >= -10 & temp < 10 & hum >= 40)
                        {
                            Condition.Fill = Brushes.YellowGreen;
                            Condition_text.Text = "Вполне приемлемо";
                        }
                        else if (temp >= -10 & temp < 10 & hum < 60)
                        {
                            Condition.Fill = Brushes.Yellow;
                            Condition_text.Text = "Хотелось бы воздух повлажнее";
                        }
                        else if (temp >= 15 & temp < 30 & hum >= 55 & hum <= 70)
                        {
                            Condition.Fill = Brushes.Green;
                            Condition_text.Text = "Великолепные ощущения";
                        }
                        else if (temp >= 15 & temp < 30 & (hum < 55 | hum > 70))
                        {
                            Condition.Fill = Brushes.GreenYellow;
                            Condition_text.Text = "Мне довольно таки хорошо";
                        }
                        return;
                    case 2:
                        //Идеальные условия обитания - 20°C и 60%. Гибельные - -48°C и 60%";
                        if (temp < -45 & hum > 55)
                        {
                            Condition.Fill = Brushes.Red;
                            Condition_text.Text = "Белка мертва";
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                        }
                        if (temp < -45 & hum <= 55)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Белка на грани гибели";
                        }
                        else if (temp < -10)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Хотелось бы температуру повыше";
                        }
                        else if (temp >= -10 & temp < 10 & hum >= 40)
                        {
                            Condition.Fill = Brushes.YellowGreen;
                            Condition_text.Text = "Вполне приемлемо";
                        }
                        else if (temp >= -10 & temp < 10 & hum < 60)
                        {
                            Condition.Fill = Brushes.Yellow;
                            Condition_text.Text = "Хотелось бы воздух повлажнее";
                        }
                        else if (temp >= 15 & temp < 30 & hum >= 55 & hum <= 70)
                        {
                            Condition.Fill = Brushes.Green;
                            Condition_text.Text = "Великолепные ощущения";
                        }
                        else if (temp >= 15 & temp < 30 & (hum < 55 | hum > 70))
                        {
                            Condition.Fill = Brushes.GreenYellow;
                            Condition_text.Text = "Мне довольно таки хорошо";
                        }
                        else if (temp >= 40)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Ух, хотелось бы похолоднее";
                        }
                        return;
                    case 3:
                        // Идеальные условия обитания - 15°C и 65%. Гибельные - -49°C и 80%";
                        if (temp < -45 & hum > 75)
                        {
                            Condition.Fill = Brushes.Red;
                            Condition_text.Text = "Лиса мертва";
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                        }
                        if (temp < -45 & hum <= 75)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Лиса на грани гибели";
                        }
                        else if (temp < -10)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Хотелось бы температуру повыше";
                        }
                        else if (temp >= -10 & temp < 10 & hum >= 40)
                        {
                            Condition.Fill = Brushes.YellowGreen;
                            Condition_text.Text = "Вполне приемлемо";
                        }
                        else if (temp >= -10 & temp < 10 & hum < 50)
                        {
                            Condition.Fill = Brushes.Yellow;
                            Condition_text.Text = "Хотелось бы воздух повлажнее";
                        }
                        else if (temp >= 15 & temp < 30 & hum >= 60 & hum <= 70)
                        {
                            Condition.Fill = Brushes.Green;
                            Condition_text.Text = "Великолепные ощущения";
                        }
                        else if (temp >= 15 & temp < 30 & (hum < 60 | hum > 70))
                        {
                            Condition.Fill = Brushes.GreenYellow;
                            Condition_text.Text = "Мне довольно таки хорошо";
                        }
                        else if (temp >= 40)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Ух, хотелось бы похолоднее";
                        }
                        return;
                    case 4:
                        // Идеальные условия обитания - 10°C и 60%. Гибельные - -50°C и 20%";
                        if (temp < -47 & hum < 25)
                        {
                            Condition.Fill = Brushes.Red;
                            Condition_text.Text = "Медведь мертв";
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                        }
                        if (temp < -47 & hum <= 25)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Ваш медведь на грани гибели";
                        }
                        else if (temp < -10)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Хотелось бы температуру повыше";
                        }
                        else if (temp >= -10 & temp < 5 & hum >= 40)
                        {
                            Condition.Fill = Brushes.YellowGreen;
                            Condition_text.Text = "Вполне приемлемо";
                        }
                        else if (temp >= -10 & temp < 5 & hum < 50)
                        {
                            Condition.Fill = Brushes.Yellow;
                            Condition_text.Text = "Хотелось бы воздух повлажнее";
                        }
                        else if (temp >= 5 & temp < 15 & hum >= 60 & hum <= 70)
                        {
                            Condition.Fill = Brushes.Green;
                            Condition_text.Text = "Великолепные ощущения";
                        }
                        else if (temp >= 5 & temp < 15 & (hum < 60 | hum > 70))
                        {
                            Condition.Fill = Brushes.GreenYellow;
                            Condition_text.Text = "Мне довольно таки хорошо";
                        }
                        else if (temp >= 15 & temp < 35 )
                        {
                            Condition.Fill = Brushes.GreenYellow;
                            Condition_text.Text = "Мне довольно таки хорошо";
                        }
                        else if (temp >= 40)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Ух, хотелось бы похолоднее";
                        }
                        return;
                    case 5:
                        // Идеальные условия обитания - 15°C и 60 %.Гибельные - 40°C и 80 % ";
                        if (temp > 35 & hum > 75)
                        {
                            Condition.Fill = Brushes.Red;
                            Condition_text.Text = "Зайчик мертв";
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                        }
                        if (temp > 35 & hum <= 75)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Ваш заяц на грани гибели";
                        }
                        else if (temp < -10)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Хотелось бы температуру повыше";
                        }
                        else if (temp >= -10 & temp < 10 & hum >= 40)
                        {
                            Condition.Fill = Brushes.YellowGreen;
                            Condition_text.Text = "Вполне приемлемо";
                        }
                        else if (temp >= -10 & temp < 10 & hum < 50)
                        {
                            Condition.Fill = Brushes.Yellow;
                            Condition_text.Text = "Хотелось бы воздух повлажнее";
                        }
                        else if (temp >= 10 & temp < 20 & hum >= 50 & hum <= 70)
                        {
                            Condition.Fill = Brushes.Green;
                            Condition_text.Text = "Великолепные ощущения";
                        }
                        else if (temp >= 10 & temp < 20 & (hum < 50 | hum > 70))
                        {
                            Condition.Fill = Brushes.GreenYellow;
                            Condition_text.Text = "Мне довольно таки хорошо";
                        }
                        else if (temp >= 20 & temp < 40)
                        {
                            Condition.Fill = Brushes.GreenYellow;
                            Condition_text.Text = "Мне довольно таки хорошо";
                        }
                        else if (temp >= 40)
                        {
                            Condition.Fill = Brushes.OrangeRed;
                            Condition_text.Text = "Ух, хотелось бы похолоднее";
                        }
                        return;
                }
            }
           

        }
    }
}
