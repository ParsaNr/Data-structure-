using System;

class tree
{
    public int item, height;
    public tree lft, rit;

    public tree(int d)
    {
        item = d;
        height = 1;
    }
}

public class AVLTree
{

    int Max(int a, int b)
    {
        return (a > b) ? a : b;
    }

    int height(tree N)
    {
        if (N == null)
            return 0;

        return N.height;
    }

    tree rightRotate(tree y)
    {
        tree x = y.lft;
        tree T2 = x.rit;

        x.rit = y;
        y.lft = T2;

        y.height = Max(height(y.lft), height(y.rit)) + 1;
        x.height = Max(height(x.lft), height(x.rit)) + 1;

        return x;
    }

    tree leftRotate(tree x)
    {
        tree y = x.rit;
        tree T2 = y.lft;

        y.lft = x;
        x.rit = T2;

        x.height = Max(height(x.lft), height(x.rit)) + 1;
        y.height = Max(height(y.lft), height(y.rit)) + 1;

        return y;
    }

    int getBalance(tree N)
    {
        if (N == null)
            return 0;

        return height(N.lft) - height(N.rit);
    }

    tree insert(tree node, int key)
    {
        if (node == null)
            return (new tree(key));

        if (key < node.item)
            node.lft = insert(node.lft, key);
        else if (key > node.item)
            node.rit = insert(node.rit, key);
        else
            return node;

        node.height = 1 + Max(height(node.lft), height(node.rit));

        int balance = getBalance(node);

        if (balance > 1 && key < node.lft.item)
            return rightRotate(node);

        if (balance < -1 && key > node.rit.item)
            return leftRotate(node);

        if (balance > 1 && key > node.lft.item)
        {
            node.lft = leftRotate(node.lft);
            return rightRotate(node);
        }

        if (balance < -1 && key < node.rit.item)
        {
            node.rit = rightRotate(node.rit);
            return leftRotate(node);
        }

        return node;
    }

    void preOrder(tree node)
    {
        if (node != null)
        {
            Console.Write(node.item + " ");
            preOrder(node.lft);
            preOrder(node.rit);
        }
    }
}