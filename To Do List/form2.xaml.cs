using System;
using System.IO;
using System.Windows;
using System.Xml;

namespace To_Do_List
{
    public partial class form2 : Window
    {
        private string xmlpath = @"E:\todo.xml";

        public form2()
        {
            InitializeComponent();
        }

        private void Submit(object sender, RoutedEventArgs e)
        {
            var _title = tb_Title.Text;
            var _date = dp_Date.ToString();
            var _note = tb_Note.Text;

            MainWindowDataContext.contentList.Add(new TodoListEntry
            {
                title = _title.Trim(),
                date = _date.Trim(),
                note = _note.Trim()
            });

            saveXML save = new saveXML();
            save.XMLSave();

            this.Close();
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            tb_Title.Text = "";
            dp_Date.SelectedDate = DateTime.Now;
            tb_Note.Text = "";
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
