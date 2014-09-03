using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreAnimation;

namespace Test
{
	public partial class TestViewController : UIViewController
	{
		private UIView _testView;

		public TestViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			_testView = new UIView (View.Frame);
			View.Add (_testView);
			//case 1
			_testView.Layer.Delegate = new TestLayerDelegate (_testView.Layer);
			//case 2
			//_testView.Layer.Delegate = new CALayerDelegate ();
			_testView.Layer.SetNeedsDisplay ();
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		protected override void Dispose (bool disposing)
		{
			Console.WriteLine ("---dispose Controller");
			base.Dispose (disposing);
			Console.WriteLine ("---postdispose Controller");
		}

	}
}

