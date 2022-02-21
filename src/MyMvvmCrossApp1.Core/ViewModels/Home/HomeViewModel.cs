using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace MyMvvmCrossApp1.Core.ViewModels.Home
{
    public class HomeViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public IMvxAsyncCommand TestAsyncCommandSimpleBinding { get; set; }
        public IMvxAsyncCommand TestAsyncCommandCollection { get; set; }
        public IMvxAsyncCommand TestAsyncCommandIsBusy { get; set; }
        public IMvxAsyncCommand TestAsyncCommandClickEventPage { get; set; }
        public IMvxAsyncCommand TestAsyncCommandNavigationSample { get; set; }
        public IMvxAsyncCommand TestAsyncCommandEntrySample { get; set; }

        public HomeViewModel(IMvxNavigationService navigation)
        {
            _navigationService = navigation;
        }

        public override Task Initialize()
        {
            //TODO: Add starting logic here

            TestAsyncCommandSimpleBinding = new MvxAsyncCommand(async () => {

                var result = await _navigationService.Navigate<GeneralBindingPageViewModel>();
            });
            TestAsyncCommandCollection = new MvxAsyncCommand(async () => {

                var result = await _navigationService.Navigate<CollectionViewSampleViewModel>();
            });

            TestAsyncCommandIsBusy = new MvxAsyncCommand(async () => {

                var result = await _navigationService.Navigate<MyBusyPageViewModel>();
            });

            TestAsyncCommandClickEventPage = new MvxAsyncCommand(async () => {

                var result = await _navigationService.Navigate<CLeckEventPageViewModel>();
            });

            TestAsyncCommandNavigationSample = new MvxAsyncCommand(async () => {

                var result = await _navigationService.Navigate<NavigationSamplePageViewModel>();
            });
            TestAsyncCommandEntrySample = new MvxAsyncCommand(async () => {

                var result = await _navigationService.Navigate<EntryPageSampleViewModel>();
            });
            return base.Initialize();
        }
    }
}
