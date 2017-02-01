using System;
using GeryVendas;
using Xamarin.Forms;

namespace GeryVendas
{
	public class IndexPage : MasterDetailPage
	{
		readonly MenuPage menuPage;
		public IndexPage()
		{
			menuPage = new MenuPage();

			menuPage.Menu.ItemSelected += (sender, e) => NavigateTo(e.SelectedItem as MenuItem);

			Master = menuPage;

			//Detail = new NavigationPage(new GeVendasPage());
			 Detail = new  NavigationPage(new MyVendas());
		}
		public async void NavigateTo(MenuItem menu)
		{
			if (menu == null)
				return;

			var displayPage =(Page)Activator.CreateInstance(menu.TargetType);

			try
			{
				Detail = new NavigationPage(displayPage);
			}
			catch (Exception ex)
			{
				await Application.Current.MainPage.DisplayAlert("ERRO", "Erro" + ex.Message, "OK");
			}
			menuPage.Menu.SelectedItem = null;
			IsPresented = false;
		}
	}
}
