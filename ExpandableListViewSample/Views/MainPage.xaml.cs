using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ExpandableListViewSample.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var vm = BindingContext as ViewModels.MainViewModel;
            var music = e.Item as Models.Music;
            vm.HideOrShowMusic(music);
        }
    }
}
