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
            bool expected = true;

            Tree t = Utils.setUpTree(values);

            var found = t.search(node);
            Console.WriteLine($"Is {node} in tree {found}");

            Assert.Equal(found, expected);
        }
    }
}
