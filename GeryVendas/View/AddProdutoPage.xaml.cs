using System;
using System.IO;
using Xamarin.Forms;

namespace GeryVendas
{
	public partial class AddProdutoPage : ContentPage
	{

		public AddProdutoPage()
		{
			InitializeComponent();
			TakePhotoButton.Clicked += TakePhotoButton_Clicked;
			this.Title = "Cadastro de produto";


		}

		async void TakePhotoButton_Clicked(object sender, System.EventArgs e)
		{
			var cameraPage = new CameraPage();
			cameraPage.OnPhotoResult += CameraPage_OnPhotoResult;
			await Navigation.PushModalAsync(cameraPage);
		}

		async void CameraPage_OnPhotoResult(GeryVendas.PhotoResultEventArgs result)
		{
			await Navigation.PopModalAsync();
			if (!result.Success)
				return;

			Photo.Source = ImageSource.FromStream(() => new MemoryStream(result.Image));
		}

		/// <summary>
		/// Salvars the pro clicked.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		protected async void SalvarPro_Clicked(object sender, EventArgs e)
		{
			
			int cod = int.Parse(this.codigo.Text);
			int quant = int.Parse(this.quantidadeP.Text);
			decimal prec = decimal.Parse(this.preco.Text);

			var produto = new Produto();
			produto._codProduto = cod;
			produto._nomeProduto = this.nome.Text;

			produto._quantidade = quant;
			produto._descricao = this.descricao.Text;
			produto.preco = prec;

			var addProduto = new DaoProduto();

			if (addProduto.insertProduto(produto))
			{
				await (DisplayAlert("Atenção", "Produto Salvo", "OK"));

				await Navigation.PopAsync(true);
			}
			else {
				await DisplayAlert("Atenção", "Dados nao foram salvos", "Ok");
			}
		}
		/// <summary>
		/// Cancelars the pro clicked.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		protected async void CancelarPro_Clicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync(true);
		}

	}

}
