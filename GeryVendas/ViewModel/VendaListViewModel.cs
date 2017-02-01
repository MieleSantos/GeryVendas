using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GeryVendas
{

	public class VendaListViewModel
	{


		public ObservableCollection<Venda> ProdutoVenda
		{
			get;
		}

		readonly List<Venda> ListaFake;

		/*public ICommand AtualizaLista
		{
			get;
		}


		public void AtualizaList(object obj)
		{
			var lis = ListaFake;

			foreach (var item in lis)
			{
				ProdutoVenda.Add(item);
			}
		}*/

		public VendaListViewModel()
		{
			var daoVenda = new DaoVenda();
			daoVenda.ListaVendas();
			ProdutoVenda = new ObservableCollection<Venda>();
			ListaFake = new List<Venda>();
			ListaFake.AddRange(daoVenda.GetItemsVenda());

			//AtualizaLista = new Command(AtualizaList);

			var lis = ListaFake;

			foreach (var item in lis)
			{
				ProdutoVenda.Add(item);
			}
		}

	}
}
