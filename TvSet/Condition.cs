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

        public void Check_condition(double temp, double hum)
        {
            if (temp < 0 & hum>50)
			{
                Condition.Fill = Brushes.Red;  
                Condition_text.Text = "die human1";
            }
                    
            else if (temp < 0 & hum < 40)
            {
                Condition.Fill = Brushes.Purple;
                Condition_text.Text = "die human2";
            }
            else if (temp < 0 & hum > 40 & hum < 50)
            {
                Condition.Fill = Brushes.Pink;
                Condition_text.Text = "die human3";
            }
            else if (temp > 0 & hum > 30 )
            {
                Condition.Fill = Brushes.OrangeRed;
                Condition_text.Text = "die human4";
            }
            else if (temp > 0 & hum > 30 & hum < 70)
            {
                Condition.Fill = Brushes.Orange;
                Condition_text.Text = "die human5";
            }
            else if (temp > 15 & hum > 30 & hum < 70)
            {
                Condition.Fill = Brushes.Yellow;
                Condition_text.Text = "die human5";
            }
            else
            {
                Condition.Fill = Brushes.Cyan;
                Condition_text.Text = "die human6";
            }
           
        }
    }
}
