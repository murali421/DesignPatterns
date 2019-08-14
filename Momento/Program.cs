using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Momento
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new Document();
            var documentHistory = new DocumentHistory(document);

            Console.WriteLine($"Inital Document: {document}");

            documentHistory.Snapshot();
            document.Append("Hello World");
            documentHistory.Snapshot();
            document.Italic();
            documentHistory.Snapshot();
            document.Bold();
            documentHistory.Snapshot();

            Console.WriteLine($"Current Document: {document}");

            documentHistory.Restore(2);

            Console.WriteLine($"After Restore: {document}");

            Console.ReadKey();
        }
    }
}
