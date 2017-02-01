using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GeryVendas
{
	public partial class ListProduto : ContentPage
	{
		private readonly ProdutoListViewModel _viewModelProduto = new ProdutoListViewModel();
		public ListProduto()
		{
			InitializeComponent();
			Title = "Meus Produtos";

			this.BindingContext = this._viewModelProduto;
			//this.listaPro.RefreshCommand = this._viewModelProduto.AtualizaLista;
			//listaPro.ItemSelected += listaPro_clicked;

		}

		//public async void List_ItemP(object sender, ItemTappedEventArgs e)
		//{
			
		//		await Navigation.PushAsync(new AtualizaProduto((Produto)e.Item));

		//		var produto = e.Item as Produto;
		//		var deleta = new DaoProduto();


		//}
		//private async void listaPro_clicked(object sender, SelectedItemChangedEventArgs e)
		//{
		//	var action = await DisplayActionSheet("Selecione a opção desejada?", "Cancel", null, "Mais informações", "Atualizar", "Excluir");
		//	if (action.Equals("Mais informações"))
		//	{
		//		var exibir = new Produto();
		//		exibir = (GeryVendas.Produto)e.SelectedItem;

		//		await DisplayAlert("Informações", exibir.ToString(), "Ok");

		//	}
		//	else if (action.Equals("Atualizar"))
		//	{
		//		await Navigation.PushAsync(new AtualizaProduto((Produto)e.SelectedItem));
		//	}
		//	else if (action.Equals("Excluir"))
		//	{

		//		var excluir = new Produto();
		//		excluir = (GeryVendas.Produto)e.SelectedItem;
		//		var deleta = new DaoProduto();

		//		var answer = await DisplayAlert("Atenção", "Deseja excluir?", "Sim", "Não");
		//		if (answer == true)
		//		{
		//			deleta.DeleteProduto(excluir);
		//		}
		//	}


		////}
		//public async void MenuItemClicked(object sender, EventArgs e)
		//{
		//	var menuItem = sender as Xamarin.Forms.MenuItem;
		//	var item = menuItem.CommandParameter as Produto;
		//	var deleta = new DaoProduto();
		//	if (menuItem.IsDestructive)
		//	{

		//		var answer = await DisplayAlert("Atenção", "Deseja excluir?", "Sim", "Não");
		//		if (answer == true)
		//		{
		//			_viewModelProduto.ProdutoLista.Remove(item);
		//			deleta.DeleteProduto(item);
		//		}

		//	}
		//	else {
		//		await DisplayAlert("Informações", item.ToString(), "Ok");

		//	}
		//}

		public async void infoProClicked(object sender, EventArgs e)
		{
			var menuItem = sender as Xamarin.Forms.MenuItem;

			var item = menuItem.CommandParameter as Produto;

			await DisplayAlert("Informações", item.InfoProduto(), "Ok");

		}

		public async void editarClicked(object sender, EventArgs e)
		{
			var menuItem = sender as Xamarin.Forms.MenuItem;

			var item = menuItem.CommandParameter as Produto;

			await Navigation.PushAsync(new AtualizaProduto((item)));
		}

	public async void excluirClicked(object sender, EventArgs e)
	{
		var menuItem = sender as Xamarin.Forms.MenuItem;

		var item = menuItem.CommandParameter as Produto;
		var excluir = new DaoProduto();
		if (menuItem.IsDestructive)
		{
			var answer = await DisplayAlert("Atenção", "Deseja excluir?", "Sim", "Não");
			if (answer == true)
			{
				_viewModelProduto.ProdutoLista.Remove(item);
				excluir.DeleteProduto(item);
			}
		}
	
		}
	}
}
