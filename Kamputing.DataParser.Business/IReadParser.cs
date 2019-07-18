using Kamputing.DataParser.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kamputing.DataParser.Business
{
    public interface IReadParser
    {
        DataSet UnparseContent(string content);
    }
}
