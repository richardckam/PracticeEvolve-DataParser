using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Serialization;

namespace Kamputing.DataParser.Data
{
    [XmlType("Document")]
    public class DocumentObject
    {
        #region Constructor
        public DocumentObject()
        {
            MatterID = -1;
        }
        public DocumentObject(int documentID) : this()
        {
            DocumentID = documentID;
        }
        #endregion

        #region Public Properties
        [XmlAttribute]
        public int DocumentID { get; set; }

        [XmlAttribute]
        public int MatterID { get; set; }

        [XmlAttribute]
        public string FileName { get; set; }
        #endregion

        // optional, depending on the format of the output data
        public bool ShouldSerializeMatterID()
        {
            return (MatterID >= 0);
        }
    }
}
