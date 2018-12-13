using System;

using TasksDrop.Core.ViewModels;
using TasksDrop.Core.Models;

using Android.App;
using Android.Content.PM;
using Android.Support.V4.View;
using Android.Support.V4.Widget;
using Android.Views;
using Android.Views.InputMethods;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Platforms.Android;
using MvvmCross.Platforms.Android.Presenters.Attributes;

using MvvmCross.Droid.Views.Attributes;
using Acr.UserDialogs;

namespace TasksDrop.Droid.Views
{

    [MvvmCross.Droid.Views.Attributes.MvxActivityPresentation]
    [Activity(Label = "Star Wars",
        Theme = "@style/AppTheme",
        LaunchMode = LaunchMode.SingleTop,
        Name = "TasksDrop.Droid.Views.TasksDropView"
        )]


    public partial class TasksDropView : MvxAppCompatActivity<TasksDropViewModel>
    {


        protected override int FragmentId => Resource.Layout.TaskView;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);

            ParentActivity.SupportActionBar.Title = Strings.TargetPeople;

            var recyclerView = view.FindViewById<MvxRecyclerView>(Resource.Id.people_recycler_view);
            if (recyclerView != null)
            {
                recyclerView.HasFixedSize = true;
                var layoutManager = new LinearLayoutManager(Activity);
                recyclerView.SetLayoutManager(layoutManager);

                recyclerView.AddOnScrollFetchItemsListener(layoutManager, () => ViewModel.FetchPeopleTask, () => this.ViewModel.FetchPeopleCommand);
            }

            return view;

        }
    }
}