using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TvSet
{
	public partial class MainWindow : Window
	{
		
		

		string[,] Kind = new string[3, 5] {
				{"Пихта","Дракон","Бук","Липа","дуб"},
				{"Чечётка","Лазоревка","Голубь","Колибри","Зяблик"},
				{"Волк","Белка","Лиса","Медведь","Заяц"}
			};
		string[,] Information = new string[3, 5] {
				{Inf_tree1,Inf_tree2,Inf_tree3,Inf_tree4,Inf_tree5},
				{"Чечётка","Лазоревка","Голубь","Колибри","Зяблик"},
				{"Волк","Белка","Лиса","Медведь","Заяц"}
			};
		static string Inf_tree1 = "Пихта – многолетнее неприхотливое растение из семейства сосновых. Идеальные условия обитания - 20oC и 60%. Смертельные - -40oC и 10% или 37oC и 90%";
		static string Inf_tree2 = "";
		static string Inf_tree3 = "";
		static string Inf_tree4 = "";
		static string Inf_tree5 = "";
	}
}
