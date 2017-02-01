﻿using System;
using System.IO;
//using Plugin.Media;
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
		//public event Action ShouldTakePicture = () => { };

		//public void ShowImage(string filepath)
		//{
		//	image.Source = ImageSource.FromFile(filepath);
		//}

		//private async void uploadFoto_Clicked(object sender, EventArgs e)
		//{
		//	if (!CrossMedia.Current.IsPickPhotoSupported)
		//	{
		//		await DisplayAlert("No upload", "Foto nao suportada", "Ok");
		//		return;
		//	}
		//	var file = await CrossMedia.Current.PickPhotoAsync();
		//	if (file == null)
		//		return;
		//	inage.Source = ImageSource.FromStream(() => file.GetStream());

		//}
		//private async void tiraFoto_Clicked(object sender, EventArgs e)
		//{
		//	await CrossMedia.Current.Initialize();

		//	if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
		//	{
		//		await DisplayAlert("no camera", "Não tem camera", "Ok");
		//		return;
		//	}

		//	var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
		//	{
		//		SaveToAlbum = true,
		//		Name = "test.jpg"
		//	});

		//	if (file == null)
		//	{
		//		return;
		//	}
		//	inage.Source = ImageSource.FromStream(() => file.GetStream());

		//}


		/// <summary>
		/// Salvars the pro clicked.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		protected async void SalvarPro_Clicked(object sender, EventArgs e)
		{
			//Photo.Source = ImageSource.FromStream(() => new MemoryStream(result.Image));
			//int cod = int.Parse(this.codigo.Text);
			//int quant = int.Parse(this.quantidadeP.Text);
			//decimal prec = decimal.Parse(this.preco.Text);

			//var produto = new Produto();
			//produto._codProduto = cod;
			//produto._nomeProduto = this.nome.Text;

			//produto._quantidade = quant;
			//produto._descricao = this.descricao.Text;
			//produto.preco = prec;

			//var addProduto = new DaoProduto();

			//if (addProduto.insertProduto(produto))
			//{
			//	await (DisplayAlert("Atenção", "Produto Salvo", "OK"));

			//	await Navigation.PopAsync(true);
			//}
			//else {
			//	await DisplayAlert("Atenção", "Dados nao foram salvos", "Ok");
			//}
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
		//private void tiraFoto_Clicked(object sender, EventArgs e)
		//{
		//	Navigation.PushAsync(new MyCamera(),true);
		//}
	}

}
