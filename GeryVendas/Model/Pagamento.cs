using System;
namespace GeryVendas
{
	public class Pagamento
	{

		//public int idPagamento { get; set; }
		//public bool pagamentoAvista { get; set; }
		//public int numeroParcela { get; set; }
		//public DateTime dataParcela { get; set; }
		//public double totalVenda { get; set; }
		//public string precoForm
		//{
		//	get
		//	{
		//		return string.Format("{0:C2}", totalVenda);
		//	}
		//}
		//public Pagamento()
		//{
		//}
		Venda vendaP;

		public Pagamento(Venda vendaP)
		{
			this.vendaP = vendaP;
		}
	}
}
