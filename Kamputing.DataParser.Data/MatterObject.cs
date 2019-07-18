using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Serialization;

namespace Kamputing.DataParser.Data
{
    [XmlType("Matter")]
    public class MatterObject
    {
        #region Private Variables
        private DocumentCollection _documents;
        #endregion

        #region Constructor
        public MatterObject()
        {
            ClientID = -1;
        }
        public MatterObject(int matterID) : this()
        {
            MatterID = matterID;
        }
        #endregion

        #region Public Properties
        [XmlAttribute]
        public int MatterID { get; set; }

        [XmlAttribute]
        public int ClientID { get; set; }

        [XmlArrayAttribute("Documents", IsNullable = false)]
        public DocumentCollection Documents
        {
            get
            {
                if (_documents == null)
                    _documents = new DocumentCollection();

                return _documents;
            }
        }
        #endregion

        // optional, depending on the format of the output data
        public bool ShouldSerializeClientID()
        {
            return (ClientID >= 0);
        }
        public void AddDocument(DocumentObject document)
        {
            Documents.Add(document);
        }
    }
}
