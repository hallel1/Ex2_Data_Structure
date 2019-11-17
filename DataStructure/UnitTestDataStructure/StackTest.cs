using DataStructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;

namespace UnitTestDataStructure
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void Push_ShuldPushOneNode()
        {
               
            Stack<int> s = new Stack<int>();
            //Node<int> n1 = new Node<int>(1);

            s.Push(1);

            Assert.AreEqual(1, s.Pop());

        }
    }
}
