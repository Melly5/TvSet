using System;
using System.Windows;
using System.Text;



namespace TvSet
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rand = new Random();
        bool editMode = false;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Edit_preview(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            editMode = true;
            string outp = "edit";

            tbout.Text = outp;
        }

        private void Add_preview(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            string outp = "add";
            tbout.Text = outp;
        }
    }
}
