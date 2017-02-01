using System;
using System.ComponentModel;
using SQLite;

namespace GeryVendas
{
	public class Venda : INotifyPropertyChanged
	{
		[PrimaryKey, AutoIncrement]
		public int idVenda { get; set; }

		public DateTime DataVenda { get; set; }
		public string nomeCliente { get; set; }
		public string nomeProduto { get; set; }
		public int quantidadeVendida { get; set; }
		public int numeroParcela { get; set; }
		public DateTime dataParcela { get; set; }
		public decimal valorParcela { get; set; }
		public decimal totalVenda { get; set; }
		public int atualPro { get; set; }

		public int idPor { get; set; }
		public string dataVendaS
		{
			get
			{
				return string.Format("{0:dd-MM-yy}", DataVenda);
			}
		}

		public string dataPagamento
		{
			get
			{
				return string.Format("{0:dd-MM-yy}", dataParcela);
			}
		}
		public Venda()
		{
		}


		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this,
			  new PropertyChangedEventArgs(propertyName));
		}

		/// <summary>
		/// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:GerencidordeVendas.VendaProduto"/>.
		/// </summary>
		/// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:GerencidordeVendas.VendaProduto"/>.</returns>
		public override string ToString()
		{
			return string.Format("Data da venda: {1},Cliente: {2}, Produto: {3}, Quantidade: {4},Numero de parcelas: {5},valorParcela: {6},dataParcela: {7} Preco: {8}", idVenda, dataVendaS, nomeCliente, nomeProduto, quantidadeVendida,numeroParcela,valorParcela,dataPagamento, totalVenda);

		}

		public  string ItensVendas()
		{
			return string.Format("Data da venda: {1},Cliente: {2}, Produto: {3}, Quantidade: {4},Numero de parcelas: {5},valorParcela: {6},dataParcela: {7} Preco: {8}", idVenda, dataVendaS, nomeCliente, nomeProduto, quantidadeVendida, numeroParcela, valorParcela, dataPagamento, totalVenda);

		}
	}
}


