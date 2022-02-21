using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Forms.Views;
using MyMvvmCrossApp1.Core.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyMvvmCrossApp1.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewSample : MvxContentPage<CollectionViewSampleViewModel>
    {
        public CollectionViewSample()
        {
            InitializeComponent();
        }
    }
}
