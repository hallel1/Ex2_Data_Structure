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
        public LinkList()
        {
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
            Node<T> pointerMoveOnList = _head;

            while (pointerMoveOnList != null)
            {
                if (pointerMoveOnList._data.Equals(existNode._data))
                {
                    toAdd._next = pointerMoveOnList._next;
                    pointerMoveOnList._next = toAdd;
                    return;
                }
                pointerMoveOnList = pointerMoveOnList._next;
            }

            if (pointerMoveOnList == null)
                throw new System.ArgumentNullException("This node does not exist");

        }


        public T this[int index]
        {

            get
            {
                return FindNodeByIndex(index)._data;
            }
            set
            {
                Node<T> nodeInIndex = FindNodeByIndex(index);
                Node<T> toAdd = new Node<T>(value);
                toAdd._next = nodeInIndex._next;
                nodeInIndex._next = toAdd;
            }

        }
        private Node<T> FindNodeByIndex(int index)
        {
            int count = 0;
            Node<T> pointerMoveOnList = _head;
            while (count != index && pointerMoveOnList != null)
            {
                count++;
                pointerMoveOnList = pointerMoveOnList._next;
            }
            if(count != index)
                throw new IndexOutOfRangeException();
            
            return pointerMoveOnList;
        }
    }
 }



