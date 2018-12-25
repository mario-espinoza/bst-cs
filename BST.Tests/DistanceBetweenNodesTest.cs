using System;
using BST;
using Xunit;

namespace BST.Tests {
    public class DistanceBetweenNodesTest {
        [Fact]
        public void DistanceBetweenNodesTest1 () {
            Tree tree = new Tree ();
            String input = "4,3,16,10,7,20,12";
            var values = Utils.validateTreeArgs (input);

            int nodeA = 3;
            int nodeB = 12;
            int expected = 4;

            Tree t = Utils.setUpTree (values);

            int distanceBetweenNodes = Tree.distanceBetweenNodes (t, nodeA, nodeB);

            Console.Write ($"Distance between {nodeA} and {nodeB} in tree");
            t.print ();
            Console.Write ($": {distanceBetweenNodes}\n");

            Assert.Equal (expected, distanceBetweenNodes);
        }

        [Fact]
        public void DistanceBetweenNodesTest2 () {
            Tree tree = new Tree ();
            String input = "4,3,16,10,7,20,12";
            var values = Utils.validateTreeArgs (input);

            int nodeA = 4;
            int nodeB = 4;
            int expected = 0;

            Tree t = Utils.setUpTree (values);

            int distanceBetweenNodes = Tree.distanceBetweenNodes (t, nodeA, nodeB);

            Console.Write ($"Distance between {nodeA} and {nodeB} in tree");
            t.print ();
            Console.Write ($": {distanceBetweenNodes}\n");

            Assert.Equal (expected, distanceBetweenNodes);
        }

        [Fact]
        public void DistanceBetweenNodesTest3 () {
            Tree tree = new Tree ();
            String input = "4,3,16,10,7,20,12";
            var values = Utils.validateTreeArgs (input);

            int nodeA = 10;
            int nodeB = 3;
            int expected = 3;

            Tree t = Utils.setUpTree (values);

            int distanceBetweenNodes = Tree.distanceBetweenNodes (t, nodeA, nodeB);

            Console.Write ($"Distance between {nodeA} and {nodeB} in tree");
            t.print ();
            Console.Write ($": {distanceBetweenNodes}\n");

            Assert.Equal (expected, distanceBetweenNodes);
        }

        [Fact]
        public void DistanceBetweenNodesTest4 () {
            Tree tree = new Tree ();
            String input = "4,3,16,10,7,20,12";
            var values = Utils.validateTreeArgs (input);

            int nodeA = 40;
            int nodeB = 4;
            int expected = -1;

            Tree t = Utils.setUpTree (values);

            int distanceBetweenNodes = Tree.distanceBetweenNodes (t, nodeA, nodeB);

            Console.Write ($"Distance between {nodeA} and {nodeB} in tree");
            t.print ();
            Console.Write ($": {distanceBetweenNodes}\n");

            Assert.Equal (expected, distanceBetweenNodes);
        }
    }
}