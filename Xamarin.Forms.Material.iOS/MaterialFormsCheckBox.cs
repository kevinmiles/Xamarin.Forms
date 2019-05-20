using System;
using CoreGraphics;
using UIKit;
using Xamarin.Forms.Platform.iOS;

namespace Xamarin.Forms.Material.iOS
{
	public class MaterialFormsCheckBox : FormsCheckBox
	{
		public override float DefaultSize => 20f;
		protected override UIBezierPath GetCheckBoxPath(CGRect backgroundRect) => UIBezierPath.FromRect(backgroundRect);
	}
}
