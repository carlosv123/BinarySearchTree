using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            binarysearchtree tree = new binarysearchtree();
            tree.add(10);
            tree.add(15);
            tree.add(20);
            tree.add(30);
            tree.add(45);

            Console.ReadLine();
        }
    }
}
