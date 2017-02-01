using System;
using SQLite;

namespace GeryVendas

{	
	public class PagamentoClasse
	{

		[PrimaryKey, AutoIncrement]
		public int idPagamento { get; set; }

		public DateTime dataParcela { get; set; }

		public decimal totalPagamento { get; set; }

		public string precoForm
		{
			get
			{
				return string.Format("{0:C2}", totalPagamento);
			}
		}

		public PagamentoClasse()
		{
		}
	}
}
