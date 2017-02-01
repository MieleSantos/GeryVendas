using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace GeryVendas
{
	public class ProdutoListViewModel 
	{

		//lista produtos cadastrados
		public ObservableCollection<Produto> ProdutoLista
		{
			get;
			set;
		}

		//public ObservableCollection<Produto> ItemLoad
		//{
		//	get;
		//	set;
		//}

		public ICommand LoadCommand
		{
			get;
			set;
		}

		readonly List<Produto> ListaFake;
		//private int _index = 0;

		//public void LoadItem()
		//{
		//	var daoProduto = new DaoProduto();
		//	daoProduto.ListaProduto();
		//	ProdutoLista = new ObservableCollection<Produto>();
		//	ListaFake.AddRange(daoProduto.GetItemsProduto());

		//	var lis = ListaFake;
		//	//daoProduto.GetItemsProduto();

		//		foreach (var item in lis)
		//		{
		//			for (int i = 0; i < 4; i++)
		//			{
		//				ItemLoad.Add(item);
		//			}
		//		}
		//		//this.ItemLoad.Add((Produto)daoProduto.GetItemsProduto());
		//		//_index++;
		//}
	

		//public ICommand AtualizaLista
		//{
		//	get;
		//}


		//public void AtualizaList(object obj)
		//{
		//	var lis = ListaFake;

		//	foreach (var item in lis)
		//	{
		//		ProdutoLista.Add(item);
		//	}
		//}
		public ProdutoListViewModel()
		{
			var daoProduto = new DaoProduto();
			daoProduto.ListaProduto();
			ProdutoLista = new ObservableCollection<Produto>();
			ListaFake = new List<Produto>();
			ListaFake.AddRange(daoProduto.GetItemsProduto());

			//AtualizaLista = new Command(AtualizaList);
			//this.LoadCommand = new Command(() => this.LoadItem());
			//this.LoadItem();
			var lis = ListaFake;

			foreach (var item in lis)
			{
				ProdutoLista.Add(item);
			}



		}
	}
}
