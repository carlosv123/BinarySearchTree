using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{



    public class Node
    {
        internal static int number;
        public int data;
        public Node leftLeaf;
        public Node rightLeaf; 

        public Node(int data)
        {
            this.data = data;
            leftLeaf = null;
            rightLeaf= null; 
        }

        internal void insertData(int data)
        {
            throw new NotImplementedException();
        }

        internal bool search(Node rightLeaf, int s)
        {
            throw new NotImplementedException();
        }

        internal bool search(int s)
        {
            throw new NotImplementedException();
        }
    }
  
}
