using System;
#if DNX451
using Microsoft.Framework.Runtime;
#else
using Microsoft.Dnx.Runtime;
#endif

namespace DnxConsoleApp
{
    public class Program
    {
        public Program(ILibraryManager libraryManager)
        {
            foreach(var library in libraryManager.GetLibraries())
            {
                Console.WriteLine(library.Name);
            }
        }

        public void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine();
            Console.WriteLine("*** Press ENTER to Exit ***");
            Console.ReadLine();
        }
    }
}
