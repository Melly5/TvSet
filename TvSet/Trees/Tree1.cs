using System.Windows.Shapes;
using System.Windows.Media;

namespace TvSet
{
	public abstract class Tree1
	{
		string _string;
		Brush color;
		public Rectangle Add(Rectangle _newBird) { return _newBird; }

		public (string, Brush) CheckCondition() { return (_string, color); }
	}
}
