using System;
using Xunit;
using BST;

namespace BST.Tests
{
    public class TreeTest
    {
        [Fact]
        public void Test1()
        {
            Tree tree = new Tree();
            int[] values = new int[] {
                1,
                2
            };

            int node = 1;
            int expected = 0;

            Tree t = Utils.setUpTree(values);

            int distanceToRoot = Tree.distanceToRoot(t, node);
            Console.Write("\n Distance To root " + distanceToRoot);

            Assert.Equal(distanceToRoot, expected);
        }

        [Fact]
        public void Test2()
        {
            Tree tree = new Tree();
            int[] values = new int[] {
                1,
                2
            };

            int node = 2;
            int expected = 1;

            Tree t = Utils.setUpTree(values);

            int distanceToRoot = Tree.distanceToRoot(t, node);
            Console.Write("\n Distance To root " + distanceToRoot);

            Assert.Equal(distanceToRoot, expected);
        }

        [Fact]
        public void Test3()
        {
            Tree tree = new Tree();
            int[] values = new int[] {
                1,
                2
            };

            int node = 1;
            int expected = 1;

            Tree t = Utils.setUpTree(values);

            int distanceToRoot = Tree.distanceToRoot(t, node);
            Console.Write("\n Distance To root " + distanceToRoot);

            Assert.Equal(distanceToRoot, expected);
        }
    }
}
