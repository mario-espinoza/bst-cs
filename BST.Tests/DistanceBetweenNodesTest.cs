using System;
using Xunit;
using BST;

namespace BST.Tests
{
    public class DistanceBetweenNodesTest
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
            String input = "1,2";
            var values = Utils.validateTreeArgs(input);

            int node = 1;
            int expected = 0;

            Tree t = Utils.setUpTree(values);

            int distanceToRoot = Tree.distanceToRoot(t, node);
            Console.Write("\n Distance To root " + distanceToRoot);

            Assert.Equal(distanceToRoot, expected);
        }

        [Fact]
        public void Test4()
        {
            Tree tree = new Tree();
            String input = "4,3,16,10,7,20,12";
            var values = Utils.validateTreeArgs(input);

            int nodeA = 3;
            int nodeB = 12;
            int expected = 4;

            Tree t = Utils.setUpTree(values);

             int distanceToRoot = Tree.distanceBetweenNodes(t, nodeA, nodeB);
            Console.Write("\n Distance To root " + distanceToRoot);

            Assert.Equal(distanceToRoot, expected);
        }

        [Fact]
        public void Test5()
        {
            Tree tree = new Tree();
            String input = "4,3,16,10,7,20,12";
            var values = Utils.validateTreeArgs(input);

            int nodeA = 4;
            int nodeB = 4;
            int expected = 0;

            Tree t = Utils.setUpTree(values);

             int distanceToRoot = Tree.distanceBetweenNodes(t, nodeA, nodeB);
            Console.Write("\n Distance To root " + distanceToRoot);

            Assert.Equal(distanceToRoot, expected);
        }

        [Fact]
        public void Test6()
        {
            Tree tree = new Tree();
            String input = "4,3,16,10,7,20,12";
            var values = Utils.validateTreeArgs(input);

            int nodeA = 10;
            int nodeB = 3;
            int expected = 3;

            Tree t = Utils.setUpTree(values);

            int distanceToRoot = Tree.distanceBetweenNodes(t, nodeA, nodeB);
            Console.Write("\n Distance To root " + distanceToRoot);

            Assert.Equal(distanceToRoot, expected);
        }

        [Fact]
        public void Test7()
        {
            Tree tree = new Tree();
            String input = "4,3,16,10,7,20,12";
            var values = Utils.validateTreeArgs(input);

            int nodeA = 40;
            int nodeB = 4;
            int expected = -1;

            Tree t = Utils.setUpTree(values);

            int distanceToRoot = Tree.distanceBetweenNodes(t, nodeA, nodeB);
            Console.Write("\n Distance To root " + distanceToRoot);

            Assert.Equal(distanceToRoot, expected);
        }
    }
}
