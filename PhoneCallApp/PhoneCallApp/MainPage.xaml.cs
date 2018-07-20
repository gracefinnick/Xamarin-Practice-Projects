using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PhoneCallApp
{
   
	public partial class MainPage : ContentPage
	{
        Entry phoneNumber;
        Button callButton;
        Button contactsButton;
        
        public MainPage()
		{
            this.Padding = new Thickness(20, 20, 20, 20);
            StackLayout panel = new StackLayout
            {
                Spacing = 15

            };
            panel.Children.Add(new Label
            {
                Text = "Enter a Phone Number:",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            });
            panel.Children.Add(phoneNumber = new Entry
            {
                Text = "770-123-4567",
                Keyboard = Keyboard.Numeric
            });
            
            panel.Children.Add(callButton = new Button
            {
                Text = "Call"
            });
            callButton.Clicked += OnCall;
            
            this.Content = panel;
        }
        async void OnCall(object sender, System.EventArgs e)
        {
            if (await this.DisplayAlert(
                "Dial a Number",
                "Would you like to call " + phoneNumber.Text + "?",
                "Yes",
                "No"))
            {
                var dialer = DependencyService.Get<IDialer>();
                if (dialer != null)
                    await dialer.DialAsync(phoneNumber.Text);
            }
        }
       
        
    }
}
