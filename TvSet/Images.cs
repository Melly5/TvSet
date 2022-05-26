using System.Reflection;
using System.Windows.Media.Imaging;

namespace TvSet
{
	public static class Images
	{
		public static BitmapImage GetImage(string uri)
		{
			var img = new BitmapImage();
			img.BeginInit();
			img.StreamSource = Assembly.GetExecutingAssembly().GetManifestResourceStream("TvSet.Images.Embed." + uri);
			img.CacheOption = BitmapCacheOption.OnLoad;
			img.EndInit();
			img.Freeze();
			return img;
		}
	}
}

