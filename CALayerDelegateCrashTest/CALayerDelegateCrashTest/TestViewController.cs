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
			_testView.Layer.Delegate = new TestLayerDelegate ();
			//case 2
			//_testView.Layer.Delegate = new CALayerDelegate ();
			//_testView.Layer.SetNeedsDisplay ();
		}

		protected override void Dispose (bool disposing)
		{
			Console.WriteLine ("---dispose {0}", this);
			base.Dispose (disposing);
			Console.WriteLine ("---postdispose {0}", this);
		}

	}
}

