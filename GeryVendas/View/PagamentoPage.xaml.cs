using System;
using System.Collections.Generic;
using GeryVendas;
using Xamarin.Forms;

namespace GeryVendas
{
	public partial class PagamentoPage : ContentPage
	{

		//private Venda venda;
		public PagamentoPage(Venda vendaEx)
		{
			InitializeComponent();
			this.Title = "Pagamento";

			//faz o calcula do preco total, preco * quantidade
			var precoTotal = vendaEx.totalVenda * vendaEx.quantidadeVendida;
			var x = vendaEx.atualPro - vendaEx.quantidadeVendida;

			atPru.Text = x.ToString();
			//rcebe o numero de parcelas do pagamento
			labelNumPar.Text = vendaEx.numeroParcela.ToString();

			//recebe o nome do cliente
			exiPro.Text = vendaEx.nomeProduto;

			//recebe o nome do produto
			exiClie.Text = vendaEx.nomeCliente;

			//recebe o preco para exibi o subtotal
			//subtotal.Text = precoTotal.ToString();

			//divide o preco final pelo numero de parcelas
			var parcela = precoTotal / vendaEx.numeroParcela;

			//valor das parcelas
			precopar.Text = parcela.ToString();
			//total da compra
			total.Text = precoTotal.ToString();
			//quantidade comprada
			lblquant.Text = vendaEx.quantidadeVendida.ToString();
			//data da venda
			lblDataVenda.Text = vendaEx.dataVendaS;
			atId.Text = vendaEx.idPor.ToString();
		}

		public void dataParcela_OnDateSelected(object sender, DateChangedEventArgs e)
		{
			var data = e.NewDate.Date;
		}

		async void salvar_Clicked(object sender, EventArgs e)
		{
			var finalVenda = new Venda();
			DaoProduto atualizaProduto = new DaoProduto();
			DaoVenda salvarVenda = new DaoVenda();
			var produto = new Produto();


			finalVenda.DataVenda = DateTime.Today;
			finalVenda.nomeCliente = this.exiClie.Text;
			finalVenda.nomeProduto = this.exiPro.Text;
			finalVenda.quantidadeVendida = int.Parse(this.lblquant.Text);
			finalVenda.totalVenda = decimal.Parse(this.total.Text);
			finalVenda.numeroParcela = int.Parse(this.labelNumPar.Text);
			finalVenda.valorParcela = decimal.Parse(this.precopar.Text);
			//finalVenda.fkPagamento = pagamento.idPagamento;
			finalVenda.dataParcela = this.dataParcela.Date;
			//pagament.totalPagamento = int.Parse(this.total.Text);
			produto._idP = int.Parse(this.atId.Text);
			produto._quantidade = int.Parse(this.atPru.Text);

			//atualizaProduto.atualizarQuantidade(produto._idP, produto._quantidade);

			if (salvarVenda.insertVenda(finalVenda))
			{
				atualizaProduto.atualizarQuantidade(produto._quantidade, produto._idP);
				await (DisplayAlert("Dados", "Salvos", "OK"));
				await Navigation.PopToRootAsync(true);


			}
			else {
				await DisplayAlert("Erro", "Dados nao foram salvos", "Ok");
			}

		}

		async void Cancelar_Clicked(object sender, EventArgs e)
		{
			//Navigation.PopAsync();
			//Navigation.RemovePage(Vendas);
			await Navigation.PopToRootAsync(true);
		}

	}
}
