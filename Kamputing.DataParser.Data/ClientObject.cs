using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Kamputing.DataParser.Data
{
    [XmlType("Client")]
    public class ClientObject
    {
        #region Private Variables
        private MatterCollection _matters;
        #endregion

        #region Constructor
        public ClientObject()
        {
        }
        public ClientObject(int clientID) : this()
        {
            ClientID = clientID;
        }
        #endregion


        #region Public Properties
        [XmlAttribute]
        public int ClientID { get; set; }
        [XmlAttribute]
        public string PreferredName { get; set; }
        [XmlAttribute]
        public string Email { get; set; }
        [XmlArrayAttribute("Matters", IsNullable = false)]
        public MatterCollection Matters
        {
            get
            {
                if (_matters == null)
                    _matters = new MatterCollection();
                return _matters;
            }
        }
        #endregion

        public void AddMatter(MatterObject matter)
        {
            Matters.Add(matter);
        }
    }
}
