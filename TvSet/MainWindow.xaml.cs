using System;
using System.Windows;
using System.Text;
using System.Globalization;
using System.Windows.Input;
using System.Windows.Controls;

namespace TvSet
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rand = new Random();
        string cond = "";
        private static FrameworkElement SelectedCanvasObject;

        public MainWindow()
        {
            InitializeComponent();
            InfoGrid.Visibility = Visibility.Hidden;
        }


        private void Edit_preview(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
    
            //string outp = "Информация об объекте";
            
        
            double temp = Double.Parse(Temp_text.Text, CultureInfo.InvariantCulture);
            double hum = Double.Parse(Hum_text.Text, CultureInfo.InvariantCulture);
            
            cond = Check_condition(temp, hum);
            Condition_text.Text = cond;

          /*  StringBuilder str = new StringBuilder();
            str.Append(temp + "\n" + hum);
            tbout.Text = str.ToString();*/
        }

        public void Add_preview(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            string outp = "add";
            tbout.Text = outp;
        }


    }
}
