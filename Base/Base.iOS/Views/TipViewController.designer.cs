// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Base.iOS.Views
{
	[Register ("TipViewController")]
	partial class TipViewController
	{
		[Outlet]
		UIKit.UILabel finalTotal { get; set; }

		[Outlet]
		UIKit.UISlider sliderGenerosity { get; set; }

		[Outlet]
		UIKit.UILabel subTotal { get; set; }

		[Outlet]
		UIKit.UITextField subtotalTextField { get; set; }

		[Outlet]
		UIKit.UILabel totalTitle { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (subTotal != null) {
				subTotal.Dispose ();
				subTotal = null;
			}

			if (subtotalTextField != null) {
				subtotalTextField.Dispose ();
				subtotalTextField = null;
			}

			if (sliderGenerosity != null) {
				sliderGenerosity.Dispose ();
				sliderGenerosity = null;
			}

			if (totalTitle != null) {
				totalTitle.Dispose ();
				totalTitle = null;
			}

			if (finalTotal != null) {
				finalTotal.Dispose ();
				finalTotal = null;
			}
		}
	}
}
