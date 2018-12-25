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

    public Tree(Node root){
      this.root = root;
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
      return getDistance(root, new Node(value), 0);
    }

    public static int distanceBetweenNodes(Tree tree, int a, int b) {
      if (!tree.search(a) || !tree.search(b))
      {
        return -1;
      }

      var root = tree.getRoot();

      if (root.getValue() == a)
      {
        return getDistance(root, new Node(b), 0);
      }
      if (root.getValue() == b)
      {
        return getDistance(root, new Node(a), 0);
      }

      var leftTree = new Tree(root.getLeft());
      var rightTree = new Tree(root.getRight());

      var areInDifferentBranches =  (leftTree.search(a) && rightTree.search(b)) || (leftTree.search(b) && rightTree.search(a));

      if (areInDifferentBranches) {
        return getDistance(root, new Node(a), 0) + getDistance(root, new Node(b), 0);
      } else {
        if (leftTree.search(a)) {
          return  distanceBetweenNodes(leftTree, a, b);
        } else {
          return  distanceBetweenNodes(rightTree, a, b);
        }
      }
    }
  }
}
