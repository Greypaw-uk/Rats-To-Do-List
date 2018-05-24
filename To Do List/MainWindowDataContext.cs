using System.Collections.Generic;

namespace To_Do_List
{
    public class MainWindowDataContext
    {
        public List<TodoListEntry> titleList { get; set; } = new List<TodoListEntry>();
    }
}
