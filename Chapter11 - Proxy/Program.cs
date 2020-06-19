using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Chapter11 - Proxy");
            Console.WriteLine();

            Simple.Client client = new Simple.Client();
            client.Main();


            Example.IBook book = new Example.BookStoreProxy();
        
            var page1 = book.GetPage(1);
            Console.WriteLine(page1.Text);
            
            var page2 = book.GetPage(2);
            Console.WriteLine(page2.Text);
  
            page1 = book.GetPage(1);
            Console.WriteLine(page1.Text);

            Console.ReadKey();
        }
    }
}
