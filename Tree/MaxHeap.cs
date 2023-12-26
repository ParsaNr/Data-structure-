using System;

class MaxHeap
{
    class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int value)
        {
            data = value;
            left = right = null;
        }
    }

    Node root;

    public MaxHeap()
    {
        root = null;
    }
    public void Insert(int value)
    {
        root = Insert(root, value);
    }
    private Node Insert(Node node, int value)
    {
        if (node == null)
        {
            node = new Node(value);
            return node;
        }

        if (value > node.data)
            node.left = Insert(node.left, value);
        else
            node.right = Insert(node.right, value);

        return node;
    }
    public void Delete(int value)
    {
        root = Delete(root, value);
    }
    private Node Delete(Node root, int value)
    {
        if (root == null)
            return root;

        if (value > root.data)
            root.left = Delete(root.left, value);
        else if (value < root.data)
            root.right = Delete(root.right, value);
        else
        {
            if (root.left == null)
                return root.right;
            else if (root.right == null)
                return root.left;

            root.data = MaxValue(root.left);

            root.left = Delete(root.left, root.data);
        }
        return root;
    }
    private int MaxValue(Node node)
    {
        int maxValue = node.data;
        while (node.right != null)
        {
            maxValue = node.right.data;
            node = node.right;
        }
        return maxValue;
    }
    public void PrintHeap()
    {
        if (root == null)
        {
            Console.WriteLine("Heap is empty");
            return;
        }

        Console.WriteLine("Printing Heap:");
        inorder(root);
    }
    private void inorder(Node root)
    {
        if (root != null)
        {
            inorder(root.left);
            Console.Write(root.data + " ");
            inorder(root.right);
        }
    }
}
