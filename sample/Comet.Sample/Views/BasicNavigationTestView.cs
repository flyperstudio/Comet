using System;
using System.Collections.Generic;

namespace Comet.Samples
{
	public class BasicNavigationTestView : NavigationView
	{
		[Body]
		View body() => new VStack()
			{
				new Button("Navigate!",()=>{
					Navigation.Navigate(new BasicTestView());
				})
			};
	}
}
