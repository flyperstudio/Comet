using System;
using System.Collections.Generic;
using Comet.Styles;
namespace Comet.Samples
{
	public class DemoButtonStyle : ButtonStyle
	{
		public DemoButtonStyle()
		{
			TextColor = Colors.Red;
			BackgroundColor = new StyleAwareValue<ControlState, Color>
				{
					[ControlState.Default] = Colors.White,
					[ControlState.Hovered] = Colors.Blue,
					[ControlState.Pressed] = Colors.Red
				};
			Border = new RoundedRectangle(4f).Stroke(Colors.Grey, 1f, true);
			Shadow = new Graphics.Shadow().WithColor(Colors.Grey).WithRadius(1).WithOffset(new Point(1, 1));
			Padding = new Thickness(30, 50);
		}
	}
	public class ButtonSample1 : View
	{
		readonly State<int> count = 0;

		[Body]
		View body() => new VStack
		{
			new Button("Increment Value", () => count.Value ++ )
				.HorizontalLayoutAlignment(LayoutAlignment.Center)
				.VerticalLayoutAlignment(LayoutAlignment.Center)
				.Apply<DemoButtonStyle>(),
			new Text(() => $"Value: {count.Value}"),
		};

	}
}
