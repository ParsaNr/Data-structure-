using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TreeLinkedList
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node child;
        }
        public Node Insert(Node parent, int data)
        {
            parent.child = new Node()
            {
                data = data,
                next = parent.child
            };
            return parent.child;
        }
        public class tree
        {
            public int data;
            public tree right;
            public tree left;
            public tree(int data)
            {
                this.data = data;
            }
        }
        public tree root = null;
        public void print()
        {
            int h = height(root);
            for (int i = 1; i <= h; i++)
                traSurface(root, i);
        }
        public static void inorder(tree root)
        {
            if (root != null)
            {
                inorder(root.left);
                Console.WriteLine(root.data);
                inorder(root.right);
            }
        }
        public static void postorder(tree root)
        {
            if (root != null)
            {
                inorder(root.left);
                inorder(root.right);
                Console.WriteLine(root.data);
            }
        }
        public static void preorder(tree root)
        {
            if (root != null)
            {
                Console.WriteLine(root.data);
                inorder(root.left);
                inorder(root.right);
            }
        }
        public int height(tree root)
        {
            int lheight = height(root.left);
            int rheight = height(root.right);

            if (lheight > rheight)
                return lheight + 1;
            else
                return rheight + 1;

        }
        public void traSurface(tree root, int level)
        {
            if (level == 1)
                Console.WriteLine(root.data);
            else if (level > 1)
            {
                traSurface(root.left, level + 1);
                traSurface(root.right, level + 1);
            }
        }
        public tree Remove(tree n, int item)
        {
            if (n == null)
                return null;

            if (item > n.data)
            {
                if (item == n.right.data)
                {
                    tree res = n.right;
                    n.right = null;
                    return res;
                }
                else
                    return Remove(n.right, item);
            }
            else
            {
                if (item == n.left.data)
                {
                    tree res = n.left;
                    n.left = null;
                    return res;
                }
                else
                    return Remove(n.left, item);
            }
        }
    }
}
