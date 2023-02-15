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
        public Node left, right;

        public Node(int d)
        {
            data = d;
            left = right = null;
        }
    }

    public class BinarySearchTree
    {

        // Root of BST
        public Node root;

        // Constructor
        public BinarySearchTree()
        {
            root = null;
        }

        // Inorder traversal of the tree
        public virtual void inorder()
        {
            inorderUtil(this.root);
        }

        // Utility function for inorder traversal of
        // the tree
        public virtual void inorderUtil(Node node)
        {
            if (node == null)
            {
                return;
            }

            inorderUtil(node.left);
            Console.Write(node.data + " ");
            inorderUtil(node.right);
        }

        // adding new node
        public virtual void insert(int data)
        {
            this.root = this.insertRec(this.root, data);
        }

        public virtual Node insertRec(Node node, int data)
        {
            if (node == null)
            {
                this.root = new Node(data);
                return this.root;
            }

            /* Otherwise, recur down the tree */
            if (data <= node.data)
            {
                node.left = this.insertRec(node.left, data);
            }
            else
            {
                node.right = this.insertRec(node.right, data);
            }
            return node;
        }

        public static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();

            tree.insert(50);
            tree.insert(30);
            tree.insert(63);
            tree.insert(70);
            tree.inorder();
        }
    }
}
