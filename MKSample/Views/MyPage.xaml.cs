using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MKSample.Views
{
    public partial class MyPage : ContentPage
    {
        ViewModels.MyPageViewModel viewModel;

        public MyPage()
        {

            InitializeComponent();

            BindingContext = viewModel = new ViewModels.MyPageViewModel();

            viewModel.TimeLine = DateTime.Now.ToString("yyyy MMMMM dd hh:mm:ss");
        }
    }
}
