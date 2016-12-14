// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Sample
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton BtnNext { get; set; }

		[Outlet]
		UIKit.UIButton BtnPrevious { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (BtnPrevious != null) {
				BtnPrevious.Dispose ();
				BtnPrevious = null;
			}

			if (BtnNext != null) {
				BtnNext.Dispose ();
				BtnNext = null;
			}
		}
	}
}
