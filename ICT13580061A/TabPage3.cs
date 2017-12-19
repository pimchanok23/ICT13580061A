using System;

using Xamarin.Forms;

namespace ICT13580061A
{
    public class TabPage3 : ContentPage
    {
        public TabPage3()
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

