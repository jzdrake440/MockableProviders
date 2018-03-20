using System;
using System.Linq;

namespace PeekAssemblyQualifiedName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(typeof(Queryable).AssemblyQualifiedName);
            Console.ReadLine();
        }
    }
}
