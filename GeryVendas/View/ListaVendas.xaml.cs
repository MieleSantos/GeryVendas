using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GeryVendas
{
	public partial class ListaVendas : ContentPage
	{
		private readonly VendaListViewModel _viewModel = new VendaListViewModel();
		public ListaVendas()
		{
			InitializeComponent();
			Title = "Minhas vendas";
			this.BindingContext = this._viewModel;
		}
		//public async void List_ItemV(object sender, ItemTappedEventArgs e)
		//{
		//	var action = await DisplayActionSheet("Selecione a opção desejada?", "Cancel", null, "Mais informações", "Atualizar", "Excluir");
		//	if (action.Equals("Mais informações"))
		//	{
		//		//var exibir = new Produto();
		//		//exibir = (GeryVendas.Produto)e.SelectedItem;
		//		var venda = e.Item as Venda;
		//		await DisplayAlert("Informações", venda.ToString(), "Ok");

		//	}
		//	else if (action.Equals("Atualizar"))
		//	{
		//		await Navigation.PushAsync(new AtualizaVenda((Venda)e.Item));
		//	}
		//	else if (action.Equals("Excluir"))
		//	{

		//		//var excluir = new Produto();
		//		//excluir = (GeryVendas.Produto)e.SelectedItem;
		//		var venda = e.Item as Venda;
		//		var deleta = new DaoVenda();

		//		var answer = await DisplayAlert("Atenção", "Deseja excluir?", "Sim", "Não");
		//		if (answer == true)
		//		{
		//			deleta.DeleteVenda(venda);
		//		}
		//	}
		//}

		//public async void MenuItemClicked(object sender, EventArgs e)
		//{
		//	var menuItem = sender as Xamarin.Forms.MenuItem;
		//	var item = menuItem.CommandParameter as Venda;
		//	var excluir = new DaoVenda();

		//	if (menuItem.IsDestructive)
		//	{
		//		var answer = await DisplayAlert("Atenção", "Deseja excluir?", "Sim", "Não");
		//		if (answer == true)
		//		{
		//			_viewModel.ProdutoVenda.Remove(item);
		//			excluir.DeleteVenda(item);
		//		}
		//	}
		//	else {
		//		await DisplayAlert("Informações", item.ToString(), "Ok");
		//	}
		//}
		public async void infoProClicked(object sender, EventArgs e)
		{
			var menuItem = sender as Xamarin.Forms.MenuItem;

			var item = menuItem.CommandParameter as Venda;

			await DisplayAlert("Informações", item.ToString(), "Ok");

		}

		public async void editarClicked(object sender, EventArgs e)
		{
			var menuItem = sender as Xamarin.Forms.MenuItem;

			var item = menuItem.CommandParameter as Venda;

			await Navigation.PushAsync(new AtualizaVenda((item)));
		}

		public async void excluirClicked(object sender, EventArgs e)
		{
			var menuItem = sender as Xamarin.Forms.MenuItem;

			var item = menuItem.CommandParameter as Venda;
			var excluir = new DaoVenda();
			if (menuItem.IsDestructive)
			{
				var answer = await DisplayAlert("Atenção", "Deseja excluir?", "Sim", "Não");
				if (answer == true)
				{
					_viewModel.ProdutoVenda.Remove(item);
					excluir.DeleteVenda(item);
				}
			}

		}
	}
}
