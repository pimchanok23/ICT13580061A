using System;

using Xamarin.Forms;

namespace ICT13580061A
{
    public class stackPage : ContentPage
    {
        public stackPage()
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

