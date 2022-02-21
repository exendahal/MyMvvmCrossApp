using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Commands;
using Xamarin.Forms;

namespace MyMvvmCrossApp1.Core.ViewModels
{
    public class CLeckEventPageViewModel: BaseViewModel
    {
        public IMvxAsyncCommand ClickMeCommand { get; set; }
        public CLeckEventPageViewModel()
        {

        }

        public override Task Initialize()
        {
            //TODO: Add starting logic here

            ClickMeCommand = new MvxAsyncCommand(async () => {

                await Application.Current.MainPage.DisplayAlert("Clicked", "Yay Clicked", "ok");
            });

            return base.Initialize();

        }
    }
}
