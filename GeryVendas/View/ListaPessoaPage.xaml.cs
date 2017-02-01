using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GeryVendas
{
	public partial class ListaPessoaPage : ContentPage
	{
		private PessoaListVielModel _viewModel = new PessoaListVielModel();

		public ListaPessoaPage()
		{
			InitializeComponent();
			Title = "Meus Clientes";
			this.BindingContext = this._viewModel;

			//listaEs.ItemSelected += listaEs_clicked;
		}

		//public  async void List_Item(object sender, ItemTappedEventArgs e)
		//{
			
		//	var action = await DisplayActionSheet("Selecione a opção desejada?", "Cancel", null, "Mais informações", "Atualizar", "Excluir");
		//	if (action.Equals("Mais informações"))
		//	{
		//		//var exibir = new Pessoa();
		//		var pessoa = e.Item as Pessoa;
		//		//exibir = (GeryVendas.Pessoa)e.SelectedItem;

		//		await DisplayAlert("Informações",pessoa.ToString(), "Ok");
		//		//await Navigation.PushAsync(new ExibirPessoa((Pessoa)e.Item));
		//	}
		//	else if (action.Equals("Atualizar"))
		//	{
		//		await Navigation.PushAsync(new AtualizaPessoa((Pessoa)e.Item));
		//	}
		//	else if (action.Equals("Excluir"))
		//	{

		//		//var excluir = new Pessoa();
		//		//excluir = (GeryVendas.Pessoa)e.SelectedItem;
		//		var pessoa = e.Item as Pessoa;
		//		var deleta = new DaoPessoa();

		//		var answer = await DisplayAlert("Atenção", "Deseja excluir?", "Sim", "Não");
		//		if (answer == true)
		//		{
		//			deleta.DeletePessoa(pessoa);

		//		}
		//	}
		//}
		//evento clicked para selecionar os item para serrem atualizados
		//private async void listaEs_clicked(object sender, SelectedItemChangedEventArgs e)
		//{
		//	var action = await DisplayActionSheet("Selecione a opção desejada?", "Cancel", null, "Mais informações", "Atualizar", "Excluir");
		//	if (action.Equals("Mais informações"))
		//	{
		//		var exibir = new Pessoa();
		//		exibir = (GeryVendas.Pessoa)e.SelectedItem;

		//		await DisplayAlert("Informações", exibir.ToString(), "Ok");

		//	}
		//	else if (action.Equals("Atualizar"))
		//	{
		//		await Navigation.PushAsync(new AtualizaPessoa((Pessoa)e.SelectedItem));
		//	}
		//	else if (action.Equals("Excluir"))
		//	{

		//		var excluir = new Pessoa();
		//		excluir = (GeryVendas.Pessoa)e.SelectedItem;
		//		var deleta = new DaoPessoa();

		//		var answer = await DisplayAlert("Atenção", "Deseja excluir?", "Sim", "Não");
		//		if (answer == true)
		//		{
		//			deleta.DeletePessoa(excluir);
		//		}
		//	}
		//}

		public async void infoClicked(object sender, EventArgs e)
		{
			var menuItem = sender as Xamarin.Forms.MenuItem;

			var item = menuItem.CommandParameter as Pessoa;

			await DisplayAlert("Informações", item.ToString(), "Ok");

		}

		public async void editarClicked(object sender, EventArgs e) 
		{
			var menuItem = sender as Xamarin.Forms.MenuItem;

			var item = menuItem.CommandParameter as Pessoa;

			await Navigation.PushAsync(new AtualizaPessoa((item)));
		}

		public async void excluirClicked(object sender, EventArgs e) 
		{
			var menuItem = sender as Xamarin.Forms.MenuItem;

			var item = menuItem.CommandParameter as Pessoa;
			var excluir = new DaoPessoa();
			if (menuItem.IsDestructive)
			{
				var answer = await DisplayAlert("Atenção", "Deseja excluir?", "Sim", "Não");
				if (answer == true)
				{
					_viewModel.PessoaLista.Remove(item);
					excluir.DeletePessoa(item);
				}
			}
			
		}
	}
}
