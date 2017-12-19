using System;

using Xamarin.Forms;

namespace ICT13580061A
{
    public class App : ContentPage
    {
        public App()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

