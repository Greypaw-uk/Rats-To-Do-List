using System.Diagnostics;
using System.IO;
using System.Xml;

namespace To_Do_List
{
    public class getList
    {
        public string xmlpath = @"E:\todo.xml";
        public FileInfo file;
        XmlDocument xmlDoc = new XmlDocument();

        public void getToDo()
        {
            xmlDoc.Load(xmlpath);

            foreach (XmlNode subnode in xmlDoc.DocumentElement.ChildNodes)
            {
                var subnodeTitle = subnode["title"];
                var subnodeDate = subnode["date"];
                var subnodeNote = subnode["note"];

                Debug.Assert(subnodeTitle != null, "Couldn't get the title node!");

                Debug.Assert(subnodeDate != null, "Couldn't get the date node!");

                Debug.Assert(subnodeNote != null, "Couldn't get the note node!");

                MainWindowDataContext.contentList.Add(new TodoListEntry
                {
                    title = subnodeTitle.InnerText.Trim(),
                    date = subnodeDate.InnerText.Trim(),
                    note = subnodeNote.InnerText.Trim()
                });
            }
        }
    }
}
