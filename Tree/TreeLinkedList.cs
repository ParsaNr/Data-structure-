using System.Collections.Generic;

public class Node
{
    public int data;
    public Node Child;
    public Node next;
    public Node(int v)
    {
        data = v;
        Child = null;
        next = null;
    }
}
public class Tree
{
    public Node root;
    public void Insert(int data, int ndata)
    {
        if (root == null)
        {
            root = new Node(ndata);
            return;
        }

        Node P = Search(root, data);

        if (P != null)
        {
            Node n = new Node(ndata);
            if (P.Child == null)
            {
                P.Child = n;
            }
            else
            {
                Node temp = P.Child;
                while (temp.next != null)
                    temp = temp.next;
                temp.next = n;
            }
        }
    }
    public Node Search(Node root, int data)
    {
        if (root == null)
            return null;

        Queue<Node> q = new Queue<Node>();
        q.Enqueue(root);

        while (q.Count > 0)
        {
            int n = q.Count;

            while (n > 0)
            {
                Node p = q.Peek();
                q.Dequeue();

                if (p.data == data)
                    return p;

                if (p.Child != null)
                {
                    Node temp = p.Child;
                    q.Enqueue(temp);
                    while (temp.next != null)
                    {
                        q.Enqueue(temp.next);
                        temp = temp.next;
                    }
                }
                n--;
            }
        }

        return null;
    }
    public void Remove(int data)
    {
        if (root == null)
        {
            return;
        }
        if (root.data == data)
        {
            root = null;
            return;
        }
        Node parent = null;
        Node nodeToRemove = null;
        bool isChildNode = false;
        Queue<Node> q = new Queue<Node>();
        q.Enqueue(root);

        while (q.Count > 0 && nodeToRemove == null)
        {
            int n = q.Count;

            while (n > 0)
            {
                Node p = q.Peek();
                q.Dequeue();

                if (p.Child != null)
                {
                    if (p.Child.data == data)
                    {
                        parent = p;
                        nodeToRemove = p.Child;
                        isChildNode = true;
                        break;
                    }
                    else
                    {
                        Node temp = p.Child;
                        q.Enqueue(temp);

                        while (temp.next != null)
                        {
                            if (temp.next.data == data)
                            {
                                parent = temp;
                                nodeToRemove = temp.next;
                                break;
                            }

                            q.Enqueue(temp.next);
                            temp = temp.next;
                        }
                    }
                }
                n--;
            }
        }
        if (nodeToRemove != null)
        {
            if (isChildNode)
            {
                parent.Child = nodeToRemove.next;
            }
            else
            {
                parent.next = nodeToRemove.next;
            }
            nodeToRemove = null;
        }
    }
}

