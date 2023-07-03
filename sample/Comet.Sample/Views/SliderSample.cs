using System;
using System.Collections.Generic;

namespace Comet.Samples
{
	public class SliderSample : View
	{
		readonly State<double> celsius = 50;

		[Body]
		View body() => new VStack
			{
                //new Slider(value: 12, from: -100, through: 100, by: 0.1f),
                //new Slider(value: () => 12f, from: -100, through: 100, by: 0.1f),
                //new Slider(value: new Binding<float>( getValue: () => 12f, setValue:null), from: -100, through: 100),
                new Slider(value: celsius, minimum: -100, maximum: 100),
				new Text(()=>$"{celsius.Value} Celsius"),
				new Text(()=>$"{celsius.Value * 9 / 5 + 32} Fahrenheit"),
			};

	}
}
