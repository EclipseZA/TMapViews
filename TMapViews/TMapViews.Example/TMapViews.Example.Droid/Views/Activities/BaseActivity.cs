using Android.OS;
using Android.Support.V7.Widget;
using MvvmCross.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace TMapViews.Example.Droid.Views
{
    public abstract class BaseActivity<TViewModel> : MvxAppCompatActivity<TViewModel>
        where TViewModel : class, IMvxViewModel
    {
        protected abstract int ActivityLayoutId { get; }

        protected Toolbar Toolbar => FindViewById<Toolbar>(Resource.Id.toolbar);

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(ActivityLayoutId);

            SetSupportActionBar(Toolbar);
        }
    }
}