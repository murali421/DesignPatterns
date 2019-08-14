using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Momento
{
    internal class DocumentHistory
    {
        private List<object> history = new List<object>();

        private readonly Document document;

        public DocumentHistory(Document document)
        {
            this.document = document;
        }

        public void Snapshot()
        {
            var momento = document.SaveState();
            history.Add(momento);
        }

        public void Restore(int index)
        {
            if (index < history.Count())
            {
                var momento = history[index];                
                document.LoadState(momento);
            }
        }

    }
}
