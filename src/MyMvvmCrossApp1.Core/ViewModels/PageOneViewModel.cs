using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyMvvmCrossApp1.Core.ViewModels
{
    public class PageOneViewModel: BaseViewModel<string>
    {
        private string _value1 = "Bajra";
        public string Value1
        {
            get { return _value1; }
            set { SetProperty(ref _value1, value); }
        }
        public PageOneViewModel()
        {
        }

        public override Task Initialize()
        {
            return base.Initialize();
        }
        public override void Prepare(string parameter)
        {
            //Implementation
            Value1 = parameter;
        }
    }
}
