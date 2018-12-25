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
            int[] tree1 = new int[] {
                1,
                2
            };

            foreach (var value in tree1) {
                Console.WriteLine($"node: {value}");
                tree.insert(value);
            }
            var root = tree.getRoot();
            tree.print();
        }
    }
}
