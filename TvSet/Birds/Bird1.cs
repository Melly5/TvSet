using System.Windows.Shapes;

namespace TvSet
{
	public abstract class Bird1
	{
		string _string;
		public Rectangle Add(Rectangle _newBird) { return _newBird; }
		public string CheckCondition() { return _string; }
		abstract public void Type();
	}
}
