using System;
using System.Data;
using System.Xml.Linq;

public class AVLtree
{
    public class Node
    {
        public int height;
        public int data;
        public Node rightroot;
        public Node leftroot;
        public Node(int d)
        {
            this.data = d;
        }
    }
    private Node root;
    public static bool Find(Node root, int data)
    {
        if (root == null)
            return false;
        else if (root.data == data)
            return true;
        else if (root.data < data)
            return Find(root.rightroot, data);
        else
            return Find(root.leftroot, data);
    }
    private Node Insert(Node root, int data)
    {
        if (root == null)
        {
            return new Node(data);
        }
        else if (data < root.data)
        {
            root.leftroot = Insert(root.leftroot, data);
        }
        else
        {
            root.rightroot = Insert(root.rightroot, data);
        }

        var balance = Balanced(root);
        if (Balanced(root) > 1)
        {
            Console.WriteLine(root.data + " is Left Heavy..");
        }
        else if (Balanced(root) < -1)
        {
            Console.WriteLine(root.data + " is Right Heavy..");
        }

        return root;
    }
    public void Insertroot(int data)
    {
        root = Insert(root, data);
    }
    public Node Delete(Node root, int data)
    {
        if (root == null)
        {
            return root;
        }
        if (data < root.data)
        {
            root.leftroot = Delete(root.leftroot, data);
        }
        else if (data > root.data)
        {
            root.rightroot = Delete(root.rightroot, data);
        }
        else
        {
            if ((root.leftroot == null) || (root.rightroot == null))
            {
                Node temp = null;
                if (temp == root.leftroot)
                {
                    temp = root.rightroot;
                }
                else
                    temp = root.leftroot;
                if (temp == null)
                {
                    temp = root;
                    root = null;
                }
                else
                    temp = root;
            }
            else
            {
                Node temp = Min(root.rightroot);
                root.data = temp.data;
                root.rightroot = Delete(root.rightroot, temp.data);
            }
        }
        if (root == null)
        {
            return root;
        }
        root.height = Math.Max(Height(root.leftroot), Height(root.rightroot)) + 1;

        int balance = Balanced(root);
        if (Balanced(root) > 1 && Balanced(root.leftroot) >= 0)
        {
            return RotateRight(root);
        }
        else if (Balanced(root) > 1 && Balanced(root.leftroot) < 0)
        {
            root.leftroot = RotateLeft(root.leftroot);
            return RotateRight(root);
        }
        else if (Balanced(root) < -1 && Balanced(root.rightroot) <= 0)
        {
            return RotateLeft(root);
        }
        else if (Balanced(root) < -1 && Balanced(root.rightroot) > 0)
        {
            root.rightroot = RotateRight(root.rightroot);
            return RotateLeft(root);
        }
        return root;
    }
    Node Min(Node node)
    {
        Node temp = node;
        while (temp.leftroot != null)
            temp = temp.leftroot;

        return temp;
    }
    public Node RotateLeft(Node root)
    {
        var newRoot = root.rightroot;
        root.rightroot = newRoot.leftroot;
        newRoot.leftroot = root;
        setHeight(root);
        setHeight(newRoot);

        return newRoot;
    }
    public Node RotateRight(Node root)
    {
        var newRoot = root.leftroot;
        root.leftroot = newRoot.rightroot;
        newRoot.rightroot = root;
        setHeight(root);
        setHeight(newRoot);
        return newRoot;
    }
    private int Height(Node node)
    {
        if (node == null)
            return -1;
        else
            return node.height;
    }
    private void setHeight(Node node)
    {
        node.height = Math.Max(Height(node.leftroot), Height(node.rightroot)) + 1;
    }
    private int Balanced(Node node)
    {
        if (node == null)
            return 0;
        else
        {
            return Height(node.leftroot) - Height(node.rightroot);
        }
    }
    public Node balance(Node node)
    {
        if (Balanced(node) > 1)
        {
            if (Balanced(root.leftroot) < 0)
            {
                root.leftroot = RotateLeft(root.leftroot);
                return RotateRight(root);
            }
        }
        else if (Balanced(node) < -1)
        {
            if (Balanced(root.rightroot) > 0)
            {
                root.rightroot = RotateRight(root.rightroot);
                return RotateLeft(root);
            }
        }
        return root;
    }
}