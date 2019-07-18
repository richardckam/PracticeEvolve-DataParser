using System;
using System.Collections.Generic;
using System.Text;

namespace Kamputing.DataParser.Business
{
    public struct CsvData
    {
        public CsvData(string csvLine)
        {
            string[] values = csvLine.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            ClientId = Int32.Parse(values[0]);
            PreferredName = values[1];
            Email = values[2];
            MatterId = Int32.Parse(values[3]);
            DocumentId = Int32.Parse(values[4]);
            FileName = values[5];
        }
        public int ClientId { get; set; }
        public string PreferredName { get; set; }
        public string Email { get; set; }
        public int MatterId { get; set; }
        public int DocumentId { get; set; }
        public string FileName { get; set; }
    }
}
