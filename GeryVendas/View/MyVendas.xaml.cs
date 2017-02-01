using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GeryVendas
{
	public partial class MyVendas : ContentPage
	{
		public MyVendas()
		{
			InitializeComponent();
		}
		private void VerCliente_Clicked(object sender, EventArgs e)
		{ 
			Navigation.PushAsync(new PageAddCliente(), true);
		}

		private void VerProdutos_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new AddProdutoPage(), true);
			
		}

		private void AddVendas_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new ExibirPessoa(), true);
		}
	}
}
