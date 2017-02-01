using System;
using System.Collections.Generic;
using System.Linq;
using SQLite;
using Xamarin.Forms;

namespace GeryVendas
{
	public class DaoVenda
	{
		readonly SQLiteConnection dataBaseVenda;
		private static readonly object locker = new object();
		public DaoVenda()
		{
			dataBaseVenda = DependencyService.Get<IConfig>().GetConnection();
			dataBaseVenda.CreateTable<Venda>();
		}
		public bool insertVenda(Venda venda)
		{
			lock (locker)
			{
				dataBaseVenda.Insert(venda);
				return true;
			}
		}

		public int DeleteVenda(Venda venda)
		{
			lock (locker)
			{
				return dataBaseVenda.Delete<Venda>(venda.idVenda);

			}
		}

		public Venda idVenda(int id)
		{
			lock (locker)
			{
				return dataBaseVenda.Table<Venda>().FirstOrDefault(c => c.idVenda == id);
			}
		}

		public void UpdateVenda(Venda venda)
		{
			lock (locker)
			{
				dataBaseVenda.Update(venda);
			}
		}

		public List<Venda> ListaVendas()
		{
			lock (locker)
			{
				return dataBaseVenda.Table<Venda>().OrderBy(c => c.nomeCliente).ToList();
			}
		}

		public IList<Venda> ListaPagamentos()
		{
			lock (locker)
			{
				return (from i in dataBaseVenda.Table<Venda>() select i).ToList();
			}
		}

		public IList<Venda> GetItemsVenda()
		{
			lock (locker)
			{
				return (from i in dataBaseVenda.Table<Venda>() select i).ToList();
			}
		}
	}
}
