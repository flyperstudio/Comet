﻿using System;
using System.Collections.ObjectModel;

namespace Comet.Samples
{
	public class Issue125b : NavigationView
	{
		private class TodoItem
		{
			public string Name { get; set; }
			public bool Done { get; set; }
		}

		readonly ObservableCollection<TodoItem> items = new ObservableCollection<TodoItem>{
			new TodoItem{
				Name = "Hi",
				Done = true,
			},
			new TodoItem
			{
				Name ="Finish Tasky",
			}
		};


		[Body]
		View body() =>
			new ListView<TodoItem>(items)
			{
				ViewFor = (item) => new HStack
					{
						new Text(item.Name).Alignment( Alignment.Leading),
						new Spacer(),
						new Toggle(item.Done).Alignment(Alignment.Center)
					}.Margin(6).FillHorizontal()
			}.Title("Tasky");
	}
}
