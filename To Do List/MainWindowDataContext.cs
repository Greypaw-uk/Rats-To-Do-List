using System.Collections.ObjectModel;

namespace To_Do_List
{
    public class MainWindowDataContext
    {
        public static ObservableCollection<TodoListEntry> contentList { get; set; } = new ObservableCollection<TodoListEntry>();
    }
}