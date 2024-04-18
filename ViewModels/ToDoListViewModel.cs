using System.Collections.Generic;
using System.Collections.ObjectModel;
using _2048Game.DataModels;

namespace _2048Game.ViewModels;

public class ToDoListViewModel
{
    public ObservableCollection<ToDoItem> ListItems { get; }

    public ToDoListViewModel(IEnumerable<ToDoItem> items)
    {
        ListItems = new ObservableCollection<ToDoItem>(items);
    }
}