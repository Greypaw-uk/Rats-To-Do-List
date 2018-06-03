using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;

namespace To_Do_List
{
    public partial class MainWindow : Window
    {
        public FileInfo file;
        public string xmlpath = @"E:\todo.xml";

        MainWindowDataContext context = new MainWindowDataContext();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = context;

            if (File.Exists(xmlpath))
            {
                try
                {
                    getList createToDoList = new getList();
                    createToDoList.getToDo();
                }
                catch (Exception)
                {
                    MessageBox.Show("The contents of todo.xml are not formatted correctly.");
                }
            }
        }

        private void CloseProgram(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public void newItem(object sender, RoutedEventArgs e)
        {
            form2 Form2 = new form2();
            Form2.Show();
        }

        public void removeItem(object sender, RoutedEventArgs e)
        {
            ObservableCollection<TodoListEntry> itemsToRemove = new ObservableCollection<TodoListEntry>();

            foreach (TodoListEntry item in lb_titles.SelectedItems)
            {
                itemsToRemove.Add(item);
            }

            foreach (TodoListEntry item in itemsToRemove)
            {
                ((ObservableCollection<TodoListEntry>)lb_titles.ItemsSource).Remove(item);
            }
            
            saveXML save = new saveXML();
            save.XMLSave();
        }



    }
}