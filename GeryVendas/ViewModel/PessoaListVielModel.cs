using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GeryVendas
{
	public class PessoaListVielModel
	{
		public ObservableCollection<Pessoa> PessoaLista
		{
			get;
			set;
		}

		readonly List<Pessoa> ListaFake;

		/*	public ICommand AtualizaLista 
			{
				get;
			}*/
		public PessoaListVielModel()
		{
			var daoPessao = new DaoPessoa();
			daoPessao.ListaPessoa();
			PessoaLista = new ObservableCollection<Pessoa>();
			ListaFake = new List<Pessoa>();
			ListaFake.AddRange(daoPessao.GetPessoaLis());

			//AtualizaLista = new Command(AtualizaList);
			var lis = ListaFake;

			foreach (var item in lis)
			{
				PessoaLista.Add(item);
			}
		}

		/*private void AtualizaList(object obj)
		{
			var lis = ListaFake;

			foreach (var item in lis) {
				PessoaLista.Add(item);
			}
		}*/
	}
}
