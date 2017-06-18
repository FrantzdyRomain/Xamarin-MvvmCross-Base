using System;
using MvvmCross.iOS.Views;
using UIKit;

namespace Base.iOS.Views
{
    public partial class TipViewController : MvxViewController<BaseProject.Core.ViewModels.SampleCalculationViewModel>
    {
        public TipViewController() : base("TipViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

