using System;

namespace BST
{
  public class Tree
  {
    private Node root;
    private int count;

    public Node getRoot() {
      return this.root;
    }

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
        Node.print(root);
    }

    public int Count()
    {
      return count;
    }


    public int distance(Node a, Node b, int distance)
    {
      if (!this.search(a.getValue()))
      {
        return -1;
      }
      if (!this.search(b.getValue()))
      {
        return -1;
      }
      if (a.getValue() == b.getValue())
      {
        return distance;
      }
      if (a.getValue() > b.getValue())
      {
        return this.distance(a, b.getLeft(), distance + 1);
      }
      else
      {
        return this.distance(a.getRight(), b, distance + 1);
      }
    }

    public int distanceToRoot(int value)
    {
      if (this.root.getValue() == value)
      {
        return 0;
      }
      if (this.search(value))
      {
        return -1;
      }
      return (distance(root, new Node(value), 0));
    }
  }
}
