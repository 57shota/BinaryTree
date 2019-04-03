using System;

namespace BinaryTree{
    
    class MainClass{
        
        public static void Main(string[] args){
            
            Console.WriteLine("--- Assignment2 / Binary tree ---");

            BinaryTree tree = new BinaryTree();

            tree.Root = new MyBinaryTreeNode(2);
            tree.Root.Left = new MyBinaryTreeNode(7);
            tree.Root.Left.Left = new MyBinaryTreeNode(2);
            tree.Root.Left.Right = new MyBinaryTreeNode(6);
            tree.Root.Left.Right.Left = new MyBinaryTreeNode(5);
            tree.Root.Left.Right.Right = new MyBinaryTreeNode(11);
            tree.Root.Right = new MyBinaryTreeNode(5);
            tree.Root.Right.Right = new MyBinaryTreeNode(9);
            tree.Root.Right.Right.Left = new MyBinaryTreeNode(4);
            tree.Dump();

        }
    }
}
