using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Kamputing.DataParser.Data
{
    [XmlRootAttribute("DataSet")]
    public class DataSet
    {
        [XmlArrayAttribute]
        public ClientCollection Clients;

        // optional, depending on the format of the output data
        [XmlArrayAttribute(IsNullable = false)]
        public MatterCollection Matters;

        // optional, depending on the format of the output data
        [XmlArrayAttribute(IsNullable = false)]
        public DocumentCollection Documents;
    }
}
