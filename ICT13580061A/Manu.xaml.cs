using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICT13580061A
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {

            InitializeComponent();
            viewButton.Clicked += ViewButton_Clicked;
            stackButton.Clicked += StackButton_Clicked;
            gridButton.Clicked += GridButton_Clicked;
            absoluteButton.Clicked += AbsoluteButton_Clicked;
            contentButton.Clicked += ContentButton_Clicked;
            navigationButton.Clicked += NavigationButton_Clicked;

            TabBotton.Clicked += TabBotton_Clicked;
            CarouselBotton.Clicked += CarouselBotton_Clicked;
        }

        private void initializeComponent()
        {
            throw new NotImplementedException();
        }

        void ViewButton_Clicked(object sender, EventArgs e)
        {
            throw new NotSupportedException();
        }

        void StackButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new stackPage());
            mp.Detail = np;
            mp.IsPresented = false;
        }

        void GridButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new GridPage());
			mp.Detail = np;
			mp.IsPresented = false;
        }

        void AbsoluteButton_Clicked(object sender, EventArgs e)
        {
			var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new AbsolutePage());
			mp.Detail = np;
			mp.IsPresented = false;
        }

        void ContentButton_Clicked(object sender, EventArgs e)
        {
			var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new MyPage1());
			mp.Detail = np;
			mp.IsPresented = false;
        }

        void NavigationButton_Clicked(object sender, EventArgs e)
        {
			var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new NavPage1());
			mp.Detail = np;
			mp.IsPresented = false;
        }

        void TabBotton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var tp = new TabbedPage();
            tp.Children.Add(new TabPage1());
            tp.Children.Add(new TabPage2());
            tp.Children.Add(new TabPage3()); 
            var np = new NavigationPage(tp);
mp.Detail = np;
			mp.IsPresented = false;
        }

        void CarouselBotton_Clicked(object sender, EventArgs e)
        {
			var mp = Parent as MasterDetailPage;
			var cp = new TabbedPage();
            cp.Children.Add(new TabPage1());
            cp.Children.Add(new TabPage2());
            cp.Children.Add(new TabPage3());
            var np = new NavigationPage(cp);
			mp.Detail = np;
			mp.IsPresented = false;
        }
    }
}