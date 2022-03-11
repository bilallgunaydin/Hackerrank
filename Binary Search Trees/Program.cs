using System;
using System.Collections.Generic;

namespace Binary_Search_Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root=null;
            int T=Int32.Parse(Console.ReadLine());
            while(T-->0){
                int data=Int32.Parse(Console.ReadLine());
                root=insert(root,data);            
            }
            int height=getHeight(root);
            Console.WriteLine(height);
        }
        static int getHeight(Node root)
        {
            if(root==null)
            return -1;

            return Math.Max(getHeight(root.left),getHeight(root.right))+1;
        }

        static Node insert(Node root, int data)
        {
            
            if(root==null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if(data<=root.data)
                {
                    cur=insert(root.left,data);
                    root.left=cur;
                }
                else
                {
                    cur=insert(root.right,data);
                    root.right=cur;
                }

                return root;
            }
        }
    }
    class Node
    {
        public Node left,right;
        public int data;
        public Node(int data)
        {
            this.data=data;
            left=right=null;
        }
    }
}
