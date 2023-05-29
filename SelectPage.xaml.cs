using Microsoft.Maui.Controls;
using System;

namespace MauiApp1
{
    public partial class SelectPage : ContentPage
    {
        public SelectPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // Redirige a la página "CRUDPage.xaml"
            Navigation.PushAsync(new CRUDPage());
        }
    }
}
