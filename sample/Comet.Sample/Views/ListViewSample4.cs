using System;
using System.Collections.Generic;
namespace Comet.Samples
{
	public class ListViewSample4 : View
	{
		List<string> _source = new List<string>{
			"Test",
			"Test1",
			"Test2",
			"Test3",
			"Sample",
			"Sample1",
			"Sample2",
			"Sample3"
		};
		readonly State<string> keyword = string.Empty;
		readonly State<IReadOnlyList<string>> ItemSource = new State<IReadOnlyList<string>>();
		public ListViewSample4()
		{
			ItemSource.Value = new List<string>(_source).AsReadOnly();
			keyword.ValueChanged = (s) => {
				if (string.IsNullOrWhiteSpace(s))
				{
					ItemSource.Value = new List<string>(_source).AsReadOnly();
				}
				else
				{
					ItemSource.Value = _source.Where(i => i.Contains(s, StringComparison.CurrentCultureIgnoreCase)).ToList().AsReadOnly();
				}
			};
		}
		[Body]
		View body() => new VStack{
			new TextField(keyword, "Search"),
			new ListView<string>(ItemSource)
			{
				ViewFor = (s) => new Text(s)
			}
		};
	}
}
