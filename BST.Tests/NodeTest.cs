

using System;
using Xunit;
using BST;

namespace BST.Tests
{
    public class NodeTest
    {
        [Fact]
        public void Test1()
        {
            Node node = new Node(0);

            Node.print(node);
        }
    }
}

