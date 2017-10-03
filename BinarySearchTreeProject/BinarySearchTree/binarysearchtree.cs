using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
   public class binarysearchtree
    {

        Node rightLeaf;
        Node leftLeaf;
        int number;
        
        public bool isLeaf()
        {
            return (rightLeaf == null && leftLeaf == null);
        }
        public void insertData(int data)
        {
            if(number < data)
            {
                if (rightLeaf == null)
                {
                    rightLeaf = new Node(data);
                }
                else
                {
                    rightLeaf.insertData(data);
                }
            }
            else if(Node.number > data)
            {
                if(leftLeaf == null)
                {
                    leftLeaf = new Node(data);
                }
                else
                {
                    leftLeaf.insertData(data);
                }
            }
        }
          public bool search(int s)
        {
            if(number == s)
            {
                return true;
            }
            if(number < s)
            {
                if(rightLeaf == null)
                {
                    return false;
                }
                return rightLeaf.search(rightLeaf, s);
            }
            if (leftLeaf == null)
            {
                return false;
            }
            return leftLeaf.search(s);
        }
        

        
    }
}  