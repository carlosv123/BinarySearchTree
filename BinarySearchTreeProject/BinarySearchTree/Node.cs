using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{



    public class Node
    {
        public int data;
        public Node leftchild;
        public Node rightchild; 

        public Node(int data)
        {
            this.data = data;
            leftchild = null;
            rightchild = null; 
        }
        

    }
  
}
