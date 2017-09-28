using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
   public class binarysearchtree
    {

        public Node root;

        public binarysearchtree()
        {
            root = null;
        }
        public int addnumber(int data)
        {
            Node newnode = new Node(int data);
            newnode.data = i;
            if (root == null)
                root = newnode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                }
             }
            if (current == null)
            {
                parent.rightchild = newndode;
            }
            else
            {
               if(current == null)
                {
                    parent.leftchild = new Node; 
                }
            }
           public search(Node node,int data)
        {
            if (node.data != data)
            {
                return null;
            }
            else
            {
                if (node == null)
                {
                    return null;
                }
                else if (data < node.data)
                {
                    return search(leftchild);
                }
                else (data > node.data)
                {
                    return search(rightchild);
                }
            }
        } 

            

        }
    }
}  