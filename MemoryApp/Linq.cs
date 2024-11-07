using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryApp
{
    internal class Files
    {
        public static IEnumerable<string> GetFiles() 
            => Directory.EnumerateFiles(@"C:\Users\Mitsu\OneDrive\Documents");
        public static IEnumerable<string> GetDocuments() 
            => GetFiles().Where(f => Path.GetExtension(f) == ".pdf");
        public static IEnumerable<string> GetInvoices()
            => GetDocuments().Where(f => f.StartsWith("FACTURE_"));
        public static void PrintInvoices()
        {
            foreach (var invoice in GetInvoices())
            {
                Console.WriteLine(invoice);
            }
        }
    }
}
