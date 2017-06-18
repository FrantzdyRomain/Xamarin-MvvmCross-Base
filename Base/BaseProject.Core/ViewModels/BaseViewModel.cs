using MvvmCross.Core.ViewModels;
using MvvmCross.Localization;
namespace BaseProject.Core.ViewModels
{
    public class BaseViewModel:MvxViewModel
    {
        public IMvxLanguageBinder TextSource => new MvxLanguageBinder("", GetType().Name);
    }
}