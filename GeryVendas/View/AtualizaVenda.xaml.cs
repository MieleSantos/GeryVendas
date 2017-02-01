using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GeryVendas
{
	public partial class AtualizaVenda : ContentPage
	{
		Venda item;

		public AtualizaVenda()
		{
			InitializeComponent();
		}

		public AtualizaVenda(Venda item)
		{
			this.item = item;
		}
	}
}
