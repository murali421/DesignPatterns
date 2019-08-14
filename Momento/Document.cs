using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Momento
{
    internal class Document
    {
        private string html;

        private sealed class DocumentState
        {
            private string state;

            public DocumentState(string state)
            {
                this.state = state;
            }

            public string State { get { return state; } }
        }

        public void Append(string text)
        {
            html += text;
        }

        public void Italic()
        {
            html = "<i>" + html + "</i>";
        }

        public void Bold()
        {
            html = "<b>" + html + "</b>";
        }

        public object SaveState()
        {
            return new DocumentState(html);
        }

        public void LoadState(object documentState)
        {
            html = (documentState as DocumentState).State;
        }

        public override string ToString()
        {
            return html;
        }
    }
}
