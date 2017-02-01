using System;
using System.ComponentModel;
using SQLite;
using Xamarin.Forms;

namespace GeryVendas
{
	[Table("FotoPro")]
	public class FotoPro : INotifyPropertyChanged
	{

		private int idImagem;

		[PrimaryKey, AutoIncrement]
		public int _idImagem
		{
			get
			{
				return idImagem;
			}
			set
			{
				idImagem = value;
				OnPropertyChanged(nameof(_idImagem));
			}

		}

		public Image fotoProduto { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this,
			  new PropertyChangedEventArgs(propertyName));
		}


	}
}
