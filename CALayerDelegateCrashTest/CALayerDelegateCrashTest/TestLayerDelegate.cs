using MonoTouch.CoreAnimation;
using System;

public class TestLayerDelegate : CALayerDelegate {
	WeakReference layer;
	public TestLayerDelegate (CALayer layer) {
		this.layer = new WeakReference (layer);
	}
	protected override void Dispose (bool disposing) {
		Console.WriteLine ("---dispose Delegate");
		if (this.layer != null) {
			var layer = (CALayer) this.layer.Target;
			if (layer != null) {
				Console.WriteLine ("---dispose Layer");
				layer.Delegate = null;
			}
		}
		base.Dispose (disposing);
		Console.WriteLine ("---postdispose Delegate");
	}
}