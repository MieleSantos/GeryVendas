using System;
using System.Collections;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GeryVendas
{
	public partial class Vendas : ContentPage
	{
		private readonly ProdutoListViewModel _viewModelProduto = new ProdutoListViewModel();

		public Vendas(Produto ven)
		{
			InitializeComponent();

			this.Title = "Cadastro de vendas";
			this.BindingContext=this._viewModelProduto;

			popularPickerCliente();
			//popularPickerProduto();

			nomeProdutoV.Text = ven._nomeProduto;
			precoUni.Text = ven._preco.ToString();
			atuProduto.Text = ven._quantidade.ToString();
			idPo.Text = ven._idP.ToString();
			//dataVenda.Text =  DateTime.Today.ToString()
		}

		public void DatePicker_OnDateSelected(object sender, DateChangedEventArgs e)
		{
			var data = e.NewDate.Date;
		}

	
		public void clienteVenda_SelectedIndexChanged(object sender, EventArgs e)
		{
			var pessoaSec = seletcCliente.Items[seletcCliente.SelectedIndex];
		}

		//public void VendaPro_SelectedIndexChanged(object sender, EventArgs e)
		//{
		//	var produtoSec = selectProduto.Items[selectProduto.SelectedIndex];
		//	int idPr = int.Parse(produtoSec);
		//	var vendaProduto = new DaoProduto();
		//	int idto = int.Parse(vendaProduto.ObterPorId(idPr).ToString());
		//	subtotal.Text = idto.ToString();
		//}


		public void popularPickerCliente()
		{
			var vendaCliente = new DaoPessoa();
			var listClie = new List<Pessoa>();
			var items = vendaCliente.ListaPessoa();

			foreach (var it in items)
			{
				seletcCliente.Items.Add(it._nome);
			}
		}
	
		//public void popularPickerProduto()
		//{
		//	var vendaProduto = new DaoProduto();
		//	var listPro = new List<Produto>();
		//	var proItems = vendaProduto.ListaProduto();

		//	foreach (var proItem in proItems)
		//	{
		//		selectProduto.Items.Add(proItem.ToString());

		//	}

		//}

	

		async void VendasItem_Clicked(object sender, EventArgs e)
		{
			var vendaP = new Venda();

			vendaP.DataVenda = this.dataVenda.Date;
			vendaP.nomeCliente = seletcCliente.Items[seletcCliente.SelectedIndex];
			vendaP.nomeProduto = this.nomeProdutoV.Text;
			vendaP.numeroParcela = int.Parse(this.numParcelas.Text);
			vendaP.totalVenda = decimal.Parse(this.precoUni.Text);
			vendaP.quantidadeVendida = int.Parse(this.entryquant.Text);
			vendaP.atualPro = int.Parse(this.atuProduto.Text);
			vendaP.idPor = int.Parse(this.idPo.Text);


			if (vendaP != null)
			{
				await Navigation.PushAsync(new PagamentoPage(vendaP));
			}
			//vendaP.dataParcela = this.dataParcela.Date;
			//vendaP.totalVenda = int.Parse(this.total.Text);

			//if (venda.insertVenda(vendaP))
			//{
			//	await (DisplayAlert("Dados", "Salvos", "OK"));
			//	await Navigation.PopAsync(true);


			//}
			//else {
			//	await DisplayAlert("Erro", "Dados nao foram salvos", "Ok");
			//}

		}

		async void Cancelar_Clicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync(true);
		}
	}
}
