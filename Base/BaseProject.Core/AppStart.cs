using BaseProject.Core.ViewModels;
using MvvmCross.Core.ViewModels;

namespace BaseProject.Core
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint= null){
            ShowViewModel<SampleCalculationViewModel>(); //replace with your own viewmodel
        }
    }
}