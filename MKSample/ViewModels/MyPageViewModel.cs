using System;
namespace MKSample.ViewModels
{
    public class MyPageViewModel : BaseViewModel
    {
        public MyPageViewModel()
        {
        }


		string timeLine = string.Empty;
		public string TimeLine
		{
			get { return timeLine; }
			set { timeLine = value; OnPropertyChanged(); }
		}
    }
}
