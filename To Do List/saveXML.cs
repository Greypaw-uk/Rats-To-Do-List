using System;
using System.IO;
using System.Xml;

namespace To_Do_List
{
    class saveXML
    {
        private String xmlpath = @"E:\todo.xml";

        public void XMLSave()
        {
            if (File.Exists(xmlpath))
            {
                File.Delete(xmlpath);
            }

            using (XmlWriter writer = XmlWriter.Create(xmlpath))
            {
                writer.WriteStartElement("root");

                foreach (var thing in MainWindowDataContext.contentList)
                {
                    writer.WriteStartElement("todo");

                    writer.WriteStartElement("title");
                    writer.WriteString(thing.title);
                    writer.WriteEndElement();

                    writer.WriteStartElement("date");
                    writer.WriteString(thing.date);
                    writer.WriteEndElement();

                    writer.WriteStartElement("note");
                    writer.WriteString(thing.note);
                    writer.WriteEndElement();

                    writer.WriteEndElement();

                    writer.Flush();
                }

                writer.WriteEndElement();
                writer.Close();
            }
        }
    }
}
