using System.Windows.Shapes;
using System.Windows.Media;

namespace TvSet
{
	public abstract class Animal1
	{
		string _string;
		Brush color;
		public Rectangle Add( Rectangle _newAnimal ) { return _newAnimal; }
		public (string, Brush) CheckCondition(int temp, int hum) { return (_string, color); }
	}
}
