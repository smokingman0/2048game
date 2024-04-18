using _2048Game.Services;

namespace _2048Game.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        var service = new ToDoListService();
        ToDoList = new ToDoListViewModel(service.GetItems());
    }

    public ToDoListViewModel ToDoList { get; }
}