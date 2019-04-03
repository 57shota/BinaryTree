using System;
namespace BinaryTree{

    // Node of tree
    class MyBinaryTreeNode{
        
        public int Data;
        public MyBinaryTreeNode Left;
        public MyBinaryTreeNode Right;

        public MyBinaryTreeNode(){
            
            this.Data = 0;
            this.Left = null;
            this.Right = null;

        }

        public MyBinaryTreeNode(int value){
            
            this.Data = value;
            this.Left = null;
            this.Right = null;

        }
    }

    class BinaryTree {

        public enum TraversalOrder{
            
            PreOrder,
            InOrder,
            PostOrder

        }

        public MyBinaryTreeNode Root;

        public BinaryTree(){
            
            this.Root = null;

        }

        public void Dump()
        {
            this.PrintTree(this.Root, 0);
            return;
        }

        private void PrintTree(MyBinaryTreeNode node, int role, string indent = "")
        {
            string prefix = "";
            switch (role)
            {
                case 0: // root node
                    prefix = "──  Root ";
                    break;
                case -1: // left node
                    prefix = indent + "├──  left  ";
                    break;
                case 1: // right node
                    prefix = indent + "└──  right ";
                    break;
                default:
                    break;
            }

            if (role != 0)
            {
                Console.WriteLine($"{indent}│");
            }

            if (node == null)
            {
                Console.WriteLine($"{prefix} null");
            }
            else
            {
                Console.WriteLine($"{prefix} {node.Data}");
                string padding = (role == -1) ? "│    " : "     ";

                this.PrintTree(node.Left, -1, indent + padding);
                this.PrintTree(node.Right, 1, indent + padding);
            }

            //log.debug(prefix + nodeConnection + nodeName);
            return;
        }



    }







}

