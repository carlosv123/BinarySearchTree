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
        public void add(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            if(root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if(data < current.Data)
                    {
                        current = current.lefchild;
                        if (current == null)
                        {
                            parent.lefchild = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.lefchild;
                        if(current == null)
                        {
                            parent 
                        }
                    }
             
                }
                

                }
            }
        }

        
          
       
        

        
    
}  