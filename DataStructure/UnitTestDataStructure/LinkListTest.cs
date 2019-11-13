using System;
using DataStructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestDataStructure
{
    [TestClass]
    public class LinkListTest
    {
        [TestMethod]
        public void AddFirst_ShuldAddNodeToTheHeadJustOneNode()
        {
            // Arrange   
            LinkList<int> l = new LinkList<int>();
            Node<int> n1 = new Node<int>(1);

            // Act
            l.AddFirst(1);

            // Assert
            Assert.AreEqual(l._head._data,n1._data);

        }
        [TestMethod]
        public void AddFirst_ShuldAddNodeToTheHeadAndCheckWithIndexer()
        {
            // Arrange   
            LinkList<int> l = new LinkList<int>();

            // Act
            l.AddFirst(1);

            // Assert
            Assert.AreEqual(l[0], l._head._data);

        }
        [TestMethod]
        public void AddFirst_ShuldAddNodeToTheHeadWithTwoNodes()
        {
            // Arrange   
            LinkList<int> l = new LinkList<int>();
            Node<int> n2 = new Node<int>(2);

            // Act
            l.AddFirst(1);
            l.AddFirst(2);

            // Assert
            Assert.AreEqual(l._head._data,n2._data);

        }
        [TestMethod]
        public void AddLast_ShuldAddNodeToTheTailJustOneNode()
        {
            // Arrange   
            LinkList<int> l = new LinkList<int>();
            Node<int> n1 = new Node<int>(1);

            // Act
            l.AddLast(1);

            // Assert
            Assert.AreEqual(l._tail._data, n1._data);

        }

        [TestMethod]
        public void AddLast_ShuldAddNodeToTheTailWithTwoNodes()
        {
            // Arrange   
            LinkList<int> l = new LinkList<int>();
            Node<int> n2 = new Node<int>(2);

            // Act
            l.AddLast(1);
            l.AddLast(2);

            // Assert
            Assert.AreEqual(l._tail._data, n2._data);

        }

        [TestMethod]
        public void AddAfterExistsNode_ShuldAddNodeAfterNodeInTheMiddle()
        {
            // Arrange   
            LinkList<int> l = new LinkList<int>();


            // Act
            l.AddFirst(1);
            l.AddFirst(4);
            l.AddAfterExistsNode(l._head,2);
           

            // Assert
            Assert.AreEqual(l[1],2);

        }
        [TestMethod]
        public void AddAfterExistsNode_ShuldAddNodeAfterNodeInTheEnd()
        {
            // Arrange   
            LinkList<int> l = new LinkList<int>();


            // Act
            l.AddFirst(1);
            l.AddAfterExistsNode(l._head, 2);


            // Assert
            Assert.AreEqual(l._head._next._data, 2);

        }


    }
}
