using System.Collections.Generic;
using System;
using System.Linq;
using Xamarin.Forms;
using SQLite;

namespace GeryVendas
{
	public class DaoPessoa
	{
		readonly SQLiteConnection dataBasePessoa;

		private static readonly object locker = new object();

		public DaoPessoa()
		{
			dataBasePessoa = DependencyService.Get<IConfig>().GetConnection();
			dataBasePessoa.CreateTable<Pessoa>();

		}

		public IList<Pessoa> GetPessoaLis()
		{
			lock (locker)
			{
				return (from t in dataBasePessoa.Table<Pessoa>()
						select t).ToList();
			}
		}

		public IList<Pessoa> getList()
		{
			return dataBasePessoa.Table<Pessoa>().ToList();
		}

	
		public bool insertPessoa(Pessoa pessoa)
		{
			lock (locker)
			{
				dataBasePessoa.Insert(pessoa);
				return true;
			}
		}

		public int DeletePessoa(Pessoa pessoa)
		{
			lock (locker)
			{
				return dataBasePessoa.Delete<Pessoa>(pessoa._IdPessoa);
			}
		}

		public Pessoa idPessoa(int id)
		{
			lock (locker)
			{
				return dataBasePessoa.Table<Pessoa>().FirstOrDefault(c => c._IdPessoa == id);
			}
		}

		public bool UpdatePessoa(Pessoa pessoa)
		{
			lock (locker)
			{
				dataBasePessoa.Update(pessoa);
				return true;
			}
		}

		public List<Pessoa> ListaPessoa()
		{
			lock (locker)
			{
				return dataBasePessoa.Table<Pessoa>().OrderBy(c => c._nome).ToList();
			}
		}
	}
}
