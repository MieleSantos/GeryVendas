using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GeryVendas
{
	public partial class AtualizaProduto : ContentPage
	{
		private Produto produtoAtt;
		public AtualizaProduto(Produto produtoAtt)
		{
			InitializeComponent();
			this.produtoAtt = produtoAtt;

			//preenchendo campos com so dados selecionados para editar
			codigoAtt.Text = produtoAtt._codProduto.ToString();
			nomePatt.Text = produtoAtt._nomeProduto;
			descricaoAtt.Text = produtoAtt._descricao;
			quantidadePAtt.Text = produtoAtt._quantidade.ToString();
			precoAtt.Text = produtoAtt.preco.ToString();


		}

		private async void AtualizarP_Clicked(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(codigoAtt.Text))
			{
				await DisplayAlert("Atenção", "Campo vazio", "OK");
				nomePatt.Focus();
				return;
			}
			if (string.IsNullOrEmpty(nomePatt.Text))
			{
				await DisplayAlert("Atenção", "Campo vazio", "OK");
				descricaoAtt.Focus();
				return;
			}
			if (string.IsNullOrEmpty(descricaoAtt.Text))
			{
				await DisplayAlert("Atenção", "Campo vazio", "OK");
				quantidadePAtt.Focus();
				return;
			}
			if (string.IsNullOrEmpty(precoAtt.Text))
			{
				await DisplayAlert("Atenção", "Campo vazio", "OK");
				precoAtt.Focus();
				return;
			}


			produtoAtt._codProduto = int.Parse(codigoAtt.Text);
			produtoAtt._nomeProduto = nomePatt.Text;
			produtoAtt._descricao = descricaoAtt.Text;
			produtoAtt._quantidade = int.Parse(quantidadePAtt.Text);
			produtoAtt.preco = decimal.Parse(precoAtt.Text);


			var atualizaProduto = new DaoProduto();

			if (atualizaProduto.UpdateProduto(produtoAtt))
			{
				await DisplayAlert("Confirmação", "Produto atualizado", "Ok");
				await Navigation.PopAsync(true);
			}
			else
			{
				await DisplayAlert("Atenção", "Produto  não atualizado", "Ok");
				await Navigation.PopAsync(true);
			}
		}

		protected void CancelarPro_Clicked(object sender, EventArgs e)
		{

			Navigation.PopAsync(true);
		}
	}
}
