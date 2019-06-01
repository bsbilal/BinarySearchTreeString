using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeString
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBinarySearchTree Tree = new StringBinarySearchTree();
            Tree.Add("Ayşe");
            Tree.Add("Fatma");
            Tree.Add("Hayriye");
            Tree.Add("Ali");
            Tree.Add("Demet");

            Tree.InOrder();
            Console.WriteLine("{0}", Tree.GetNodes());
            Console.ReadKey();

        }
    }
}
