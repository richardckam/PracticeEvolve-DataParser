using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Xml.Serialization;

namespace Kamputing.DataParser.Data
{
    [XmlType("Clients")]
    public class ClientCollection : Collection<ClientObject>
    {
    }
}
