using System;
using NUnit.Framework;
using System.IO;
using linkedList;


namespace linkedListTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void test_node_returns_data()
        {
            Node node = new Node("A");
            Assert.AreEqual(node.data, "A");
        }

        [Test]
        public void test_add_node_to_list()
        {
            var linkedList = new LinkedList();
            linkedList.createNode("A");
            linkedList.createNode("B");
            Assert.AreEqual(linkedList.head.data, "B");
            Assert.AreEqual(linkedList.head.next.data, "A");
        }

        [Test]
        public void test_print_nodes()
        {
            var linkedList = new LinkedList();
            linkedList.createNode("A");
            linkedList.createNode("B");
            linkedList.createNode("B");
            linkedList.printNodes();
            using (var stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);
                linkedList.printNodes();
                var result = stringWriter.ToString().Trim();
                Assert.AreEqual(result, "B->B->A");
            }

        }

        [Test]
        public void test_remove_nodes()
        {
            var linkedList = new LinkedList();
            linkedList.createNode("E");
            linkedList.createNode("B");
            linkedList.createNode("E");
            linkedList.createNode("E");
            linkedList.createNode("B");
            linkedList.createNode("B");
            linkedList.createNode("B");
            linkedList.createNode("B");
            linkedList.createNode("A");
            linkedList.createNode("A");
            linkedList.createNode("A");
            linkedList.createNode("A");
            linkedList.createNode("A");
            linkedList.createNode("A");
            linkedList.createNode("A");
            linkedList.createNode("B");
            linkedList.deleteRepeated();
            using (var stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);
                linkedList.printNodes();
                var result = stringWriter.ToString().Trim();
                Assert.AreEqual(result, "B->A->A->B->E->B->E");
            }

        }

    }
}
