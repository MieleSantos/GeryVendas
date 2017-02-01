using System;
using System.Collections.Generic;

namespace GeryVendas
{
	public class MenuListData : List<MenuItem>
	{
		 public MenuListData()
		{
			Add(new MenuItem()
			{
				Titulo = "Início",
				TargetType = typeof(MyVendas),
				Image = "ic_launcher.png"
			});

			 Add(new MenuItem()
			{
				Titulo = "Meus clientes",
				TargetType =  typeof(ListaPessoaPage),
				Image = "lista.png"

			});

			Add(new MenuItem()
			{
				Titulo = "Meus produtos",
				TargetType = typeof(ListProduto),
				Image = "lista.png"
			});

			Add(new MenuItem()
			{
				Titulo = "Minhas Vendas",
				TargetType = typeof(ListaVendas),
				Image = "lista.png"
			});

			Add(new MenuItem()
			{
				Titulo = "Pagamentos",
				TargetType = typeof(ListaPagamentos),
				Image = "lista.png"
			});

		}
	}
}
