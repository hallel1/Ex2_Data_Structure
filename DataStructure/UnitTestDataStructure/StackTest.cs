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
        public void Peek_ShuldReturnHeadData()
        {
            const int VALUE = 5;
            var mockList = new Mock<LinkListInterface<int>>();
            var mockObjList = mockList.Object;
            Stack<int> s = new Stack<int>(mockObjList);
            //s.Push(VALUE);
            s.Peek();

            mockList.Setup(_ => _[It.Is<int>(passedValue => passedValue == VALUE)]).Returns(VALUE);
        }
        [TestMethod]
        public void Pop_ShuldDeleteHeadAndReturnData()
        {
            var mockList = new Mock<LinkListInterface<int>>();
            var mockObjList = mockList.Object;
            Stack<int> s = new Stack<int>(mockObjList);
           
            s.Pop();
            int val_Peek = s.Peek();

            mockList.Setup(_ => _.DeleteNode(It.Is<int>(passedValue => passedValue == val_Peek)));

        }
    }
}
