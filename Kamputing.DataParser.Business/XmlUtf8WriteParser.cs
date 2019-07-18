using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Kamputing.DataParser.Data;

namespace Kamputing.DataParser.Business
{
    public class XmlUtf8WriteParser : IWriteParser
    {
        #region IWriteParser Implementation
        string IWriteParser.ParseContent(DataSet content)
        {
            MemoryStream writer = new MemoryStream();
            XmlWriter xmlWriter = new XmlTextWriter(writer, Encoding.UTF8) { Formatting = Formatting.Indented };

            XmlSerializer serialiser = new XmlSerializer(typeof(DataSet));
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            serialiser.Serialize(xmlWriter, content, ns);
            byte[] bytes =  writer.ToArray();

            return ASCIIEncoding.Default.GetString(bytes);
        }
        #endregion
    }
}
