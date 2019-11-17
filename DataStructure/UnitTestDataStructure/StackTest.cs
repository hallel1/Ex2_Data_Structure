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
            const int VALUE_TO_PUSH = 5;
            var mockList = new Mock<LinkListInterface<int>>();
            var mockObjList = mockList.Object;
            Stack<int> s = new Stack<int>(mockObjList);

            s.Push(VALUE_TO_PUSH);

            mockList.Verify(_=>_.AddFirst(It.Is<int>(passedValue => passedValue == VALUE_TO_PUSH)));

        }

        [TestMethod]
        public void Peek_ShuldPopOneNode()
        {
            //var n2 = new Node<int>(2);
            //var n1 = new Node<int>(1,n2);

            //var mockList = new Mock<LinkListInterface<int>>(n1);
            const int VALUE = 5;
            var mockList = new Mock<LinkListInterface<int>>();
            var mockObjList = mockList.Object;
            Stack<int> s = new Stack<int>(mockObjList);
            s.Push(VALUE);
            s.Peek();

            mockList.Setup(_ => _[It.Is<int>(passedValue => passedValue == VALUE)]).Returns(VALUE);
            //mockList.Verify(_ => _.AddFirst(It.Is<int>(passedValue => passedValue == VALUE_TO_PUSH)));

        }

    }
}
