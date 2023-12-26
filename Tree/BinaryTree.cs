using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BinaryTree
    {
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
        public void insert(tree root, int x)
        {
            tree q;
            tree p = new tree(x);
            p.right = p.left = null;
            q = root;
            if (root == null)
                root = p;
            while (true)
            {
                if (x < p.data)
                {
                    if (q.left == null)
                        q.left = p;
                    else
                        q = q.left;
                }
                else if (x > p.data)
                {
                    if (q.right == null)
                        q.right = p;
                    else
                        q = q.right;
                }
                else
                    break;
            }
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
        public tree Find(int item, tree root)
        {
            if (root != null)
            {
                if (item == root.data)
                    return root;
                if (item < root.data)
                    return Find(item, root.left);
                else
                    return Find(item, root.right);
            }
            return null;
        }
        public int MinValue(tree node)
        {
            int minv = node.data;

            while (node.left != null)
            {
                minv = node.left.data;
                node = node.left;
            }

            return minv;
        }
        public tree Remove(tree root, int item)
        {
            if (root == null) 
                return root;
            if (item < root.data)
                root.left = Remove(root.left, item);
            else if (item > root.data)
                root.right = Remove(root.right, item);

            else
            {
                if (root.left == null)
                    return root.right;
                else if (root.right == null)
                    return root.left;

                root.data = MinValue(root.right);

                root.right = Remove(root.right, root.data);
            }

            return root;
        }
    }
}
