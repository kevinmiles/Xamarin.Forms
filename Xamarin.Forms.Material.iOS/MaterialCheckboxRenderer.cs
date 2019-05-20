using System;
using Xamarin.Forms.Platform.iOS;

namespace Xamarin.Forms.Material.iOS
{
	public class MaterialCheckBoxRenderer : CheckBoxRendererBase<MaterialFormsCheckBox>
	{
		protected override MaterialFormsCheckBox CreateNativeControl()
		{
			return new MaterialFormsCheckBox();
		}


		protected override void UpdateTintColor()
		{
			if (Element.TintColor != Color.Default)
			{
				base.UpdateTintColor();
				return;
			}

		}
	}
}
