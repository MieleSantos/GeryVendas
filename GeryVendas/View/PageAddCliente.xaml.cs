using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GeryVendas
{
	public partial class PageAddCliente : ContentPage
	{
		public PageAddCliente()
		{
			InitializeComponent();
			this.Title = "Cadastro de Cliente";
		}

		public void PickerEstado_SelectedIndexChanged(object sender, EventArgs e)
		{
			var est = pickerEstado.Items[pickerEstado.SelectedIndex];
		}


		protected async void Salvar_Clicked(object sender, EventArgs e)
		{
			//if (string.IsNullOrEmpty(nome.Text))
			//{
			//	await DisplayAlert("Erro", "Campo vazio", "OK");
			//	email.Focus();
			//	return;
			//}
			//if (string.IsNullOrEmpty(email.Text))
			//{
			//	await DisplayAlert("Erro", "Campo vazio", "OK");
			//	telefone.Focus();
			//	return;
			//}
			//if (string.IsNullOrEmpty(telefone.Text))
			//{
			//	await DisplayAlert("Erro", "Campo vazio", "OK");
			//	rua.Focus();
			//	return;
			//}
			//if (string.IsNullOrEmpty(numero.Text))
			//{
			//	await DisplayAlert("Erro", "Campo vazio", "OK");
			//	bairro.Focus();
			//	return;
			//}
			//    if (string.IsNullOrEmpty(bairro.Text))
			//{
			//	await DisplayAlert("Erro", "Campo vazio", "OK");
			//	cidade.Focus();
			//	return;
			//}
		 //   if (string.IsNullOrEmpty(cidade.Text))
			//{
			//	await DisplayAlert("Erro", "Campo vazio", "OK");
			//	pickerEstado.Focus();
			//	return;
			//}

			var pessoa = new Pessoa();
			pessoa._nome = this.nome.Text;
			pessoa._email = this.email.Text;
			pessoa._telefone = int.Parse(this.telefone.Text);
			pessoa._rua = this.rua.Text;
			pessoa._numero = int.Parse(this.numero.Text);
			pessoa._bairro = this.bairro.Text;
			pessoa._cidade = this.cidade.Text;
			pessoa._estado = pickerEstado.Items[pickerEstado.SelectedIndex];

			var addCliente = new DaoPessoa();
		
				if (addCliente.insertPessoa(pessoa))
				{
					await (DisplayAlert("Dados", "Salvos", "OK"));
					await Navigation.PopAsync(true);

				}
				else {
					await DisplayAlert("Erro", "Dados nao foram salvos", "Ok");
				}
	   	}


		protected void Cancelar_Clicked(object sender, EventArgs e)
		{
			Navigation.PopAsync(true);
		}
	}
}
