using Kamputing.DataParser.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kamputing.DataParser.Business
{
    public class CsvListedReadParser : IReadParser
    {
        #region IReadParser Interface
        DataSet IReadParser.UnparseContent(string content)
        {
            ClientCollection clients = new ClientCollection();
            MatterCollection matters = new MatterCollection();
            DocumentCollection documents = new DocumentCollection();
            bool isHeaderLine = true;
            foreach (string line in content.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (isHeaderLine)
                {
                    isHeaderLine = false;
                    continue;
                }
                CsvData data = new CsvData(line);
                AddClient(clients, data);
                AddMatter(matters, data);
                AddDocument(documents, data);
            }

            return new DataSet() { Clients = clients, Matters = matters, Documents = documents };
        }
        #endregion

        #region Private Methods
        private static void AddClient(ClientCollection clients, CsvData data)
        {
            ClientObject client = new ClientObject(data.ClientId) { Email = data.Email, PreferredName = data.PreferredName };
            clients.Add(client);
        }

        private static void AddMatter(MatterCollection matters, CsvData data)
        {
            MatterObject matter = new MatterObject(data.MatterId) { ClientID = data.ClientId };
            matters.Add(matter);
        }

        private static void AddDocument(DocumentCollection documents, CsvData data)
        {
            DocumentObject document = new DocumentObject(data.DocumentId) { MatterID = data.MatterId, FileName = data.FileName };
            documents.Add(document);
        }
        #endregion
    }
}
