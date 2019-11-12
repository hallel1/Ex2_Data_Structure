using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure 
{

    class LinkList<T> : LinkListInterface<T>
    {
        private Node<T> _head;
        private Node<T> _tail;
        //private static int _indexNode;

        public LinkList(){
            _head = null;
            _tail = null;
          //  _indexNode++;
        }
        public void AddFirst(T t)
        {
            Node<T> toAdd = new Node<T>(t);
            toAdd._next = _head;

            if (_head == null)
                _tail = toAdd;

            _head = toAdd;

        }

        public void AddLast(T t)
        {
            Node<T> toAdd = new Node<T>(t);
            if (_tail == null)
            {
                _head = toAdd;
                _tail = toAdd;
            }
            else
            {
                _tail._next = toAdd;
            }
            _tail = toAdd;
        }

        public void AddAfterExistsNode(Node<T> existNode, T newVal)
        {
            Node<T> toAdd = new Node<T>(newVal);
            Node<T> pointerFindNode = null;
            Node<T> pointerMoveOnList =_head;

            while (pointerMoveOnList != null)
            {
                if (pointerMoveOnList._data.Equals(existNode._data))
                    pointerFindNode = pointerMoveOnList;

                pointerMoveOnList = pointerMoveOnList._next;
            }

            if (pointerFindNode == null)
                throw new System.ArgumentException("This node does not exist");


            toAdd._next = pointerFindNode._next;
            pointerFindNode._next = toAdd;
        }


    }
}
