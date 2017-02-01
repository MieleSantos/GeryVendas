using System;
using System.ComponentModel;
using SQLite;
using Xamarin.Forms;
using System.Threading.Tasks;
namespace GeryVendas
{
	public class Produto : INotifyPropertyChanged
	{

		private int id;

		[PrimaryKey, AutoIncrement]
		public int _idP
		{
			get { return id; }
			set
			{
				id = value;
				OnPropertyChanged(nameof(_idP));
			}
		}

		private int codProtudo;
		public int _codProduto
		{
			get
			{
				return codProtudo;
			}
			set
			{
				codProtudo = value;
				OnPropertyChanged(nameof(_codProduto));
			}
		}

		private string nomeProduto;
		public string _nomeProduto
		{
			get
			{
				return nomeProduto;
			}
			set
			{
				nomeProduto = value;
				OnPropertyChanged(nameof(_nomeProduto));
			}
		}
		private int quantidade;
		public int _quantidade
		{
			get
			{
				return quantidade;
			}
			set
			{
				quantidade = value;
				OnPropertyChanged(nameof(_quantidade));
			}
		}


		private string descricao;
		public string _descricao
		{
			get
			{
				return descricao;
			}
			set
			{
				descricao = value;
				OnPropertyChanged(nameof(_descricao));
			}
		}


		public decimal preco;
		public decimal _preco
		{
			get
			{
				return preco;
			}
			set
			{
				preco = value;
				OnPropertyChanged(nameof(_preco));
			}
		}

		public string precoPro
		{
			get
			{
				return string.Format("{0:N1", preco);
			}
		}



		//public string FileProduto { get; set; }

		public Produto()
		{
		}

		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this,
			  new PropertyChangedEventArgs(propertyName));
		}

		public string InfoProduto()
		{
			return string.Format("Nome: {2},Descricao: {3},Quantidade: {4}, Preco: {5}", id, codProtudo, nomeProduto, descricao, quantidade, preco);
		}
		public override string ToString()
		{
			//return string.Format("COdigo: {1}, Nome: {2}, Quantidade: {3},Cor: {4},descricao: {5} tamanho: {6}, preco: {7}",IdP, codProtudo, nomeP,quantidade,cor,descricao, tamanho,preco);
			//return string.Format("Nome: {2},Descricao: {3},Quantidade: {4}, Preco: {5}", id, codProtudo, nomeProduto, descricao, quantidade, preco);

			return string.Format("{1},Quantidade: {2}, Preco: {3}", id, nomeProduto, quantidade, preco);
		}


	}
}



