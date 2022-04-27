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
        public string condition = "";
        public string Check_condition(double temp, double hum)
        {
            if (temp < 0&hum>50) 
                    condition = "beeee";
            else if (temp < 0 & hum < 40)
                    condition = "die human";
            else if (temp < 0 & hum > 40 & hum < 50)
                    condition = "die little human";
            else if (temp > 0 & hum > 30 )
                condition = "uhh, move me, human";
            else if (temp > 0 & hum > 30 & hum < 70)
                condition = "uhh, could be better, human";
            else if (temp > 15 & hum > 30 & hum < 70)
                condition = "that's nice,human";
            else condition = "that's nice,oh-eh human";
            return condition;
        }
    }
}
