using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GeryVendas
{
	public partial class AtualizaPessoa : ContentPage
	{

		private Pessoa pessoaAtt;

		public AtualizaPessoa(Pessoa pessoaAtt)
		{
			InitializeComponent();
			this.pessoaAtt = pessoaAtt;
			this.Title = "Atualizar cliente";
	
			nomeAtt.Text = pessoaAtt._nome;
			emailAtt.Text = pessoaAtt._email;
			telefoneAtt.Text = pessoaAtt._telefone.ToString();
			ruaAtt.Text = pessoaAtt._rua;
			numeroAtt.Text = pessoaAtt._numero.ToString();
			bairroAtt.Text = pessoaAtt._bairro;
			cidadeAtt.Text = pessoaAtt._cidade;
			pickerEstadoAtt.Items.Equals(pessoaAtt._estado);
	       // pickerEstadoAtt.Items.IndexOf(pessoaAtt._estado);

		}

		public void PickerEstadoAtt_SelectedIndexChanged(object sender, EventArgs e)
		{
			var est = pickerEstadoAtt.Items[pickerEstadoAtt.SelectedIndex];
		}
		private async void Atualizar_Clicked(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(nomeAtt.Text))
			{
				await DisplayAlert("Erro", "Campo vazio", "OK");
				emailAtt.Focus();
				return;
			}
			if (string.IsNullOrEmpty(emailAtt.Text))
			{
				await DisplayAlert("Erro", "Campo vazio", "OK");
				telefoneAtt.Focus();
				return;
			}
			if (string.IsNullOrEmpty(telefoneAtt.Text))
			{
				await DisplayAlert("Erro", "Campo vazio", "OK");
				ruaAtt.Focus();
				return;
			}
			if (string.IsNullOrEmpty(numeroAtt.Text))
			{
				await DisplayAlert("Erro", "Campo vazio", "OK");
				bairroAtt.Focus();
				return;
			}
			//if (string.IsNullOrEmpty(cidadeAtt.Text))
			//{
			//	await DisplayAlert("Erro", "Campo vazio", "OK");
			//	pickerEstadoAtt.Focus();
			//	return;
			//}

			pessoaAtt._nome = nomeAtt.Text;
			pessoaAtt._email = emailAtt.Text;
			pessoaAtt._telefone = int.Parse(telefoneAtt.Text);
			pessoaAtt._rua = ruaAtt.Text;
			pessoaAtt._numero = int.Parse(numeroAtt.Text);
			pessoaAtt._bairro = bairroAtt.Text;
			pessoaAtt._cidade = cidadeAtt.Text;
			//pessoaAtt._estado = pickerEstadoAtt.Items[pickerEstadoAtt.SelectedIndex];

			var atualizaPessoa = new DaoPessoa();
			if (atualizaPessoa.UpdatePessoa(pessoaAtt))
			{

				await DisplayAlert("Confirmação", "Cliente atualizado", "Ok");
				await Navigation.PopModalAsync(true);
			}
			else
			{
				await DisplayAlert("Atenção", "Cliente  não atualizado", "Ok");
			}
		}

		protected async void Cancelar_Clicked(object sender, EventArgs e)
		{

			await Navigation.PopAsync(true);
		}
	}
}
