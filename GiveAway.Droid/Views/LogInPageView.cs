using Android.App;
using MvvmCross.Droid.Views;

namespace GiveAway.Droid.Views
{
    [Activity(Label = "LogInPageView", MainLauncher = true)]
    public class LogInPageView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.LogInPageView);
        }
    }
}