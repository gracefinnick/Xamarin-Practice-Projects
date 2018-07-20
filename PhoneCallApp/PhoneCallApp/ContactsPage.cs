using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace PhoneCallApp
{
    public partial class ContactsPage : ContentPage
    {
        public List<string> contactsList;
        public ContactsPage()
        {

            this.Padding = new Thickness(20, 20, 20, 20);
            StackLayout panel = new StackLayout
            {
                Spacing = 15
            };
            panel.Children.Add(new Label
            {
                Text = "Name, Phone Number",
                FontAttributes = FontAttributes.Bold
            });
            panel.Children.Add(new Label
            {
                Text = "Jesse Manders, 770-856-2021",
            });
            panel.Children.Add(new Label
            {
                Text = "Grace Finnick, 678-490-4165"
            });
            this.Content = panel;
        }
    }
}
