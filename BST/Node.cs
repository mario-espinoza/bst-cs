using System;

namespace BST
{
  public class Node
  {
    private int value;
    private Node right;
    private Node left;

    public int getValue()
    {
      return this.value;
    }

    public void setValue(int value)
    {
      this.value = value;
    }

    public Node getRight()
    {
      return this.right;
    }

    public void setRight(Node right)
    {
      this.right = right;
    }

    public Node getLeft()
    {
      return this.left;
    }

    public void setLeft(Node left)
    {
      this.left = left;
    }

    public Node(int value)
    {
      this.setValue(value);
      this.setRight(null);
      this.setLeft(null);
    }

    public bool isLeaf(ref Node node)
    {
      return (node.right == null && node.left == null);

    }

    public void insert(ref Node node, int value)
    {
      if (node == null)
      {
        node = new Node(value);
      }
      if (node.value < value)
      {
        insert(ref node.right, value);
      }

      if (node.value > value)
      {
        insert(ref node.left, value);
      }
    }

    public bool search(Node node, int s)
    {
      if (node == null)
        return false;

      if (node.value == s)
      {
        return true;
      }
      if (node.value < s)
      {
        return search(node.right, s);
      }
      if (node.value > s)
      {
        return search(node.left, s);
      }

      return false;
    }



    public static void print(Node n)
    {
      if (n == null)
        return;

      print(n.left);
      Console.Write(" " + n.value);
      print(n.right);
    }

  }
}
