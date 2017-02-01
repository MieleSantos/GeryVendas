using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(GeryVendas.Droid.ConfigBanco))]
namespace GeryVendas.Droid
{
	public class ConfigBanco : IConfig
	{
		public ConfigBanco()
		{
		}

		public SQLite.SQLiteConnection GetConnection()
		{
			var filename = "GeVendasBanco.db3";
			string documentSpath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			var path = Path.Combine(documentSpath, filename);

			var connection = new SQLite.SQLiteConnection(path);
			return connection;
		}
	}
}
