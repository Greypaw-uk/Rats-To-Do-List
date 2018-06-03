using System.ComponentModel;
using System.Windows.Data;

namespace To_Do_List
{
    public class TodoListEntry : INotifyPropertyChanged
    {
        private string _title;
        private string _date;
        private string _note;

        public string title
        {
            get { return _title; }
            set
            {
                _title = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("title"));
            }
        }

        public string date
        {
            get { return _date; }
            set
            {
                _date = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("date"));
            }
        }

        public string note
        {
            get { return _note; }
            set
            {
                _note = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("note"));
            }
        }

        public ListCollectionView selectedListEntry { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
} 