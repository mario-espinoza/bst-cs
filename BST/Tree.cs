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


    public static int getDistance(Node root, Node node, int distance)
    {
      if (root == null) {
        return -1;
      }
      if (root.getValue() == node.getValue()){
        return distance;
      }

      var leftDistance = getDistance(root.getLeft(), node, distance + 1);

      if (leftDistance != -1) {
        return leftDistance;
      }

      return getDistance(root.getRight(), node, distance + 1);
    }

    public static int distanceToRoot(Tree tree, int value)
    {
      var root = tree.getRoot();
      if (root.getValue() == value)
      {
        return 0;
      }
      if (!tree.search(value))
      {
        return -1;
      }
      return (getDistance(root, new Node(value), 0));
    }
  }
}
