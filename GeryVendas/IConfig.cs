using SQLite;

namespace GeryVendas
{
	public interface IConfig
	{
		SQLiteConnection GetConnection();
	}
}
