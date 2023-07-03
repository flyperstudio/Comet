using System;
using System.Collections.Generic;
using Colors = Microsoft.Maui.Graphics.Colors;
namespace Comet.Samples
{
	public class ButtonSample : View
	{
		readonly State<int> count = 0;

		[Body]
		View body() => new VStack
		{
			new Button("Increment Value", () => count.Value ++ )
				.Frame(200,40)
				.HorizontalLayoutAlignment(LayoutAlignment.Center)
				.VerticalLayoutAlignment(LayoutAlignment.Center)
				.Border(new RoundedRectangle(5).Stroke(Colors.Red, 1.5f, true))
				.Shadow(Colors.Grey,4,2,2),
			new Text(() => $"Value: {count.Value}"),
		};
	}
}
