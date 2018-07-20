using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace PhoneCallApp
{
    public partial class App : Application
    {
        Button entryButton;
        Button contactsButton;
        public App()
        {
            StackLayout entryPage = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center
            };
            entryPage.Children.Add(new Label
            {
                HorizontalTextAlignment = TextAlignment.Center,
                Text = "Welcome to My Phone App!"
            });
            entryPage.Children.Add(entryButton = new Button
            {
                Text = "Enter"
            });
            entryPage.Children.Add(contactsButton = new Button
            {
                Text = "Contact Book"
            });
            MainPage = new NavigationPage(new ContentPage
            {
                Content = entryPage
            });
            entryButton.Clicked += EntryOnClick;
            contactsButton.Clicked += ContactsOnClick;
            
        }
        private void EntryOnClick(object sender, System.EventArgs e)
        {
            MainPage.Navigation.PushAsync(new MainPage());
        }
        private void ContactsOnClick(object sender, System.EventArgs e)
        {
            MainPage.Navigation.PushAsync(new ListView
            {
                ItemsSource = ContactService.
            });
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
