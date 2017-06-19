using System;
using MvvmCross.iOS.Views;
using UIKit;
using BaseProject.Core.ViewModels;
using MvvmCross.Binding.BindingContext;

namespace Base.iOS.Views
{
    public partial class TipViewController : MvxViewController<SampleCalculationViewModel>
    {
        public TipViewController() : base("TipViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			this.CreateBinding(finalTotal).To((SampleCalculationViewModel vm) => vm.Tip).Apply();
			this.CreateBinding(subtotalTextField).To((SampleCalculationViewModel vm) => vm.SubTotal).Apply();
			this.CreateBinding(sliderGenerosity).To((SampleCalculationViewModel vm) => vm.Generosity).Apply();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

