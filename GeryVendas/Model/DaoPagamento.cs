using System;
using System.Collections.Generic;
using System.Linq;
using SQLite;
using Xamarin.Forms;

namespace GeryVendas
{
	public class DaoPagamento
	{
		readonly SQLiteConnection dataBasePagamento;
		private static readonly object locker = new object();

		public DaoPagamento()
		{
			dataBasePagamento = DependencyService.Get<IConfig>().GetConnection();
			dataBasePagamento.CreateTable<PagamentoClasse>();
		}

	
		public bool insertPagamento(PagamentoClasse pagamento)
		{
			lock (locker)
			{
				dataBasePagamento.Insert(pagamento);
				return true;
			}
		}

		//public int DeleteVenda(PagamentoClasse  venda)
		//{
		//	lock (locker)
		//	{
		//		return dataBasePagamento.Delete<PagamentoClasse>(venda.idVenda);

		//	}
		//}

		public PagamentoClasse  idVenda(int id)
		{
			lock (locker)
			{
				return dataBasePagamento.Table<PagamentoClasse>().FirstOrDefault(c => c.idPagamento == id);
			}
		}

		public void UpdatePagamento(PagamentoClasse pagamento)
		{
			lock (locker)
			{
				dataBasePagamento.Update(pagamento);
			}
		}

		//public List<PagamentoClasse> ListaVendas()
		//{
		//	lock (locker)
		//	{
		//		return dataBasePagamento.Table<PagamentoClasse>().OrderBy(c => c.).ToList();
		//	}
		//}

		public IList<PagamentoClasse> ListaPagamentos()
		{
			lock (locker)
			{
				return (from i in dataBasePagamento.Table<PagamentoClasse>() select i).ToList();
			}
		}

		public IList<PagamentoClasse> GetItemsVenda()
		{
			lock (locker)
			{
				return (from i in dataBasePagamento.Table<PagamentoClasse>() select i).ToList();
			}
		}
	}
}
