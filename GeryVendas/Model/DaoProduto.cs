using System;
using System.Collections.Generic;
using System.Linq;
using SQLite;
using Xamarin.Forms;

namespace GeryVendas
{
	public class DaoProduto
	{
		readonly SQLiteConnection dataBaseProduto;

		private static readonly object locker = new object();

		public DaoProduto()
		{
			dataBaseProduto = DependencyService.Get<IConfig>().GetConnection();
			dataBaseProduto.CreateTable<Produto>();
		}

		public bool insertProduto(Produto produto)
		{
			lock (locker)
			{
				dataBaseProduto.Insert(produto);
				return true;
			}
		}

		public bool DeleteProduto(Produto produto)
		{
			lock (locker)
			{
				dataBaseProduto.Delete<Produto>(produto._idP);
				return true;
			}
		}
		/*
		public int DeleteProduto(Produto produto)
		{
			lock (locker)
			{
				return dataBaseProduto.Delete<Produto>(produto.IdP);
			}
		}*/

		public bool atualizarQuantidade (int x,int id)
		{
			lock (locker)
			{
				//var updateMarks = db.Execute<Student>("UPDATE Student Set marks  = ? WHERE Stockid = ?",100,stdId);

				dataBaseProduto.Query<Produto>("update Produto set _quantidade = ? where _idP == ?",x,id);
				return true;
			}
		}

		//public List<Produto> ObterPorId(int id, int x)
		//{
		//	lock (locker)
		//	{
		//		return dataBaseProduto.Query<Produto>("update Produto set quatidade = [x] where[_idP] == id");
		//	}
		//}

		public bool UpdateProduto(Produto produto)
		{
			lock (locker)
			{
				dataBaseProduto.Update(produto);
				return true;
			}
		}

		public List<Produto> ListaProduto()
		{
			lock (locker)
			{
				return dataBaseProduto.Table<Produto>().OrderBy(c => c._nomeProduto).ToList();
			}
		}

		public IList<Produto> GetItemsProduto()
		{
			lock (locker)
			{
				return (from i in dataBaseProduto.Table<Produto>() select i).ToList();
			}
		}
	}
}
