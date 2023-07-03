using System;
using System.Collections.Generic;
using Colors = Microsoft.Maui.Graphics.Colors;
using Comet.Styles;

namespace Comet.Samples
{
	public class DemoButtonStyle : ButtonStyle
	{
		public DemoButtonStyle()
		{
			TextColor = Colors.Red;
			BackgroundColor = Colors.White;
			Border = new RoundedRectangle(5).Stroke(Colors.Red, 1.5f, true);
			Shadow = new Graphics.Shadow().WithColor(Colors.Gray).WithRadius(1).WithOffset(new Point(1, 1));
		}
	}

	public class DemoProgressBarStyle : ProgressBarStyle
	{
		public DemoProgressBarStyle()
		{
			ProgressColor = Colors.Green;
		}
	}
	public class DemoSlideStyle : SliderStyle
	{
		public DemoSlideStyle()
		{
			TrackColor = Colors.Blue;
			ProgressColor = Colors.Green;
			ThumbColor = Colors.Red;
		}
	}

	public class StylesSample : View
	{
		[Body]
		View body() => new VStack
		{
			new Button("Button Style")
				.Frame(200,40)
				.HorizontalLayoutAlignment(LayoutAlignment.Center)
				.VerticalLayoutAlignment(LayoutAlignment.Center)
				.Apply<DemoButtonStyle>(),
			new Text("Progress Bar style"),
			new ProgressBar(() => 0.5).Apply<DemoProgressBarStyle>(),
			new Text("Slider style"),
			new Slider(0.5, 0, 1).Apply<DemoSlideStyle>(),
		};

	}
}
