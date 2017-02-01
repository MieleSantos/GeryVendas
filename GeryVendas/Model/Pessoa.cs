using System;
using System.ComponentModel;
using SQLite;


namespace GeryVendas
{

	[Table("Pessoa")]
	public class Pessoa : INotifyPropertyChanged
	{

		private int idPessoa;

		[PrimaryKey, AutoIncrement]
		public int _IdPessoa
		{
			get
			{
				return idPessoa;
			}
			set
			{
				idPessoa = value;
				OnPropertyChanged(nameof(_IdPessoa));
			}
		}

		private string nome;

		public string _nome
		{
			get
			{
				return nome;
			}
			set
			{
				nome = value;
				OnPropertyChanged(nameof(_nome));
			}
		}
		private int telefone;
		public int _telefone
		{
			get
			{
				return telefone;
			}
			set
			{
				telefone = value;
				OnPropertyChanged(nameof(_telefone));
			}
		}

		/*public static explicit operator string(Pessoa v)
		{
			throw new NotImplementedException();
		}*/

		private string email;
		public string _email
		{
			get
			{
				return email;
			}
			set
			{
				email = value;
				OnPropertyChanged(nameof(_email));
			}
		}

		private string rua;
		public string _rua
		{
			get
			{
				return rua;
			}
			set
			{
				rua = value;
				OnPropertyChanged(nameof(_rua));
			}
		}
		private int numero;
		public int _numero
		{
			get
			{
				return numero;
			}
			set
			{
				numero = value;
				OnPropertyChanged(nameof(_numero));
			}
		}

		private string bairro;
		public string _bairro
		{
			get
			{
				return bairro;
			}
			set
			{
				bairro = value;
				OnPropertyChanged(nameof(_bairro));
			}
		}

		private string cidade;
		public string _cidade
		{
			get
			{
				return cidade;
			}
			set
			{
				cidade = value;
				OnPropertyChanged(nameof(_cidade));
			}
		}

		private string estado;
		public string _estado
		{
			get
			{
				return estado;
			}
			set
			{
				estado = value;
				OnPropertyChanged(nameof(_estado));
			}
		}

		public Pessoa()
		{

		}


		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this,
			  new PropertyChangedEventArgs(propertyName));
		}

		public override string ToString()
		{
			// string.Format("Nome: {1}", idPessoa, nome, telefone, email, rua, numero, bairro, cidade, estado);
			return string.Format("Nome: {1}, Telefone: {2}, Email: {3}, Rua: {4}, Numero: {5}, Bairro: {6}, Cidade: {7}, Estado: {8}", idPessoa, nome, telefone, email, rua, numero, bairro, cidade, estado);
		}


	}
}



