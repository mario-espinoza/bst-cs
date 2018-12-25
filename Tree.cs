using System;

namespace BST
{
  class Tree
  {
    private Node root;
    private int count;

    public Tree()
    {
      root = null;
      count = 0;
    }
    public bool isEmpty()
    {
      return root == null;
    }

    public void insert(int d)
    {
      if (isEmpty())
      {
        root = new Node(d);
      }
      else
      {
        root.insert(ref root, d);
      }

      count++;
    }

    public bool search(int s)
    {
      return root.search(root, s);
    }

    public bool isLeaf()
    {
      if (!isEmpty())
        return root.isLeaf(ref root);

      return true;
    }

    public void print()
    {
      if (!isEmpty())
        root.print(root);
    }

    public int Count()
    {
      return count;
    }
  }
}
