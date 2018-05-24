using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Xml;
using System.Xml.Linq;

namespace To_Do_List
{
    public partial class MainWindow : Window
    {
        public FileInfo file;
        public string xmlpath = @"C:\todo.xml";
        XmlDocument xmlDoc = new XmlDocument();


        public MainWindow()
        {
            InitializeComponent();

            var context = new MainWindowDataContext();
            DataContext = context;

            xmlDoc.Load(xmlpath);

            foreach (XmlNode childNode in xmlDoc.DocumentElement.ChildNodes)
            {
                if (childNode.Name.ToLower() != "todo")
                {
                    Debug.Assert(false, "Expected a todo node, but got " + childNode.Name, childNode.ToString());
                    continue;
                }
                else
                {
                    foreach (XmlNode subnode in childNode)
                    {
                        context.titleList.Add(new TodoListEntry { title = subnode["title"].InnerText, date = subnode["date"].InnerText, note = subnode["note"].InnerText });
                    }
                }
            }
        }

        public void SaveFile(object sender, RoutedEventArgs e)
        {

        }

        private void CloseProgram(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SaveChanges(object sender, RoutedEventArgs e)
        {

        }
    }
}





