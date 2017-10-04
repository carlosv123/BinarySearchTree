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
                        current = current.leftchild;
                        if (current == null)
                        {
                            parent.leftchild = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.leftchild;
                        if(current == null)
                        {
                            parent.rightchild = newNode;
                            break;
                        }
                    }
             
                }
                

             }
         }
         public bool search(Node node, int data)
        {
            if (node == null)
            {
                return false;
            }
            else if (node.Data == data)
            {
                return true;
            } 
            else if(node.Data < data)
            {
                return search(node.rightchild, data);
            }  
            else if(node.Data > data)
            {
                return search(node.leftchild, data);
            }
            return false;
       

        
        }
   }

        
          
       
        

        
    
}  