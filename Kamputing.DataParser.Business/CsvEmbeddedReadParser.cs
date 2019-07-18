using Kamputing.DataParser.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kamputing.DataParser.Business
{
    public class CsvEmbeddedReadParser : IReadParser
    {
        #region IReadParser Interface
        DataSet IReadParser.UnparseContent(string content)
        {
            ClientCollection clients = new ClientCollection();
            bool isHeaderLine = true;
            foreach (string line in content.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (isHeaderLine)
                {
                    isHeaderLine = false;
                    continue;
                }
                CsvData data = new CsvData(line);
                ClientObject client = GetOrAddClient(clients, data);
                MatterObject matter = GetOrAddMatter(client, data);
                GetOrAddDocument(matter, data);
            }

            return new DataSet() { Clients = clients };
        }
        #endregion

        #region Private Methods
        private static ClientObject GetOrAddClient(ClientCollection clients, CsvData data)
        {
            ClientObject client = clients.Where(c => c.ClientID == data.ClientId).FirstOrDefault();
            if (client == null)
            {
                client = new ClientObject(data.ClientId) { Email = data.Email, PreferredName = data.PreferredName };
                clients.Add(client);
            }

            return client;
        }

        private static MatterObject GetOrAddMatter(ClientObject client, CsvData data)
        {
            MatterObject matter = client.Matters.Where(m => m.MatterID == data.MatterId).FirstOrDefault();
            if (matter == null)
            {
                matter = new MatterObject(data.MatterId);
                client.AddMatter(matter);
            }

            return matter;
        }

        private static DocumentObject GetOrAddDocument(MatterObject matter, CsvData data)
        {
                DocumentObject document = matter.Documents.Where(d => d.DocumentID == data.DocumentId).FirstOrDefault();
            if (document == null)
            {
                document = new DocumentObject(data.DocumentId) { FileName = data.FileName };
                matter.AddDocument(document);
            }

            return document;
        }
        #endregion
    }
}
