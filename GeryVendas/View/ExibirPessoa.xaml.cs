using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GeryVendas
{
	public partial class ExibirPessoa : ContentPage
	{
		
		private readonly ProdutoListViewModel _viewModelProduto = new ProdutoListViewModel();


		public ExibirPessoa()
		{
			InitializeComponent();

			this.Title = "Selecao do produto";

			this.BindingContext = this._viewModelProduto;

		}

		public async void List_ItemP(object sender, ItemTappedEventArgs e)
		{

			await Navigation.PushAsync(new Vendas(e.Item as Produto));

			//var produto = e.Item as Produto;

		}
	}
}
