using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{

    public class LinkList<T> : LinkListInterface<T>
    {
        public Node<T> _head { get; private set; }
        public Node<T> _tail { get; private set; }
        public LinkList()
        {
            _head = null;
            _tail = null;
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
            Node<T> pointerExistNode;

            pointerExistNode = FindNodeByValue(existNode._data, false);

            if (pointerExistNode == null)
            {
                throw new System.ArgumentException("This node does not exist");
            }

            toAdd._next = pointerExistNode._next;
            pointerExistNode._next = toAdd;

        }

        public void DeleteNode(T val)
        {

            if (_head == null)
                throw new System.ArgumentException("This node does not exist");
            if (_head == _tail)
            {
                if (_head._data.Equals(val))
                {
                    _head = null;
                    _tail = null;
                    return;
                }

                throw new System.ArgumentException("This node does not exist");
            }
            if (_head._data.Equals(val))
            {
                _head = _head._next;
                return;
            }
            if(!DeleteNodeByValue(val))
                throw new System.ArgumentException("This node does not exist");

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
            if (count != index)
                throw new IndexOutOfRangeException();

            return pointerMoveOnList;
        }

        private Node<T> FindNodeByValue(T val, bool needToDelete)
        {
            Node<T> pointerMoveOnList = _head;

            while (pointerMoveOnList != null)
            {
                if (pointerMoveOnList._data.Equals(val))
                {
                    return pointerMoveOnList;
                }
                pointerMoveOnList = pointerMoveOnList._next;
            }
            return null;
        }
        private bool DeleteNodeByValue(T val)
        {
            Node<T> pointerMoveOnList = _head;
            Node<T> pointerPrevNode = _head;

            while (pointerMoveOnList._next != null)
            {
                pointerMoveOnList = pointerMoveOnList._next;
                if (pointerMoveOnList._data.Equals(val))
                {
                    if (pointerMoveOnList == _tail)
                        _tail = pointerPrevNode;

                    pointerPrevNode._next = pointerMoveOnList._next;

                    return true;
                }
                pointerPrevNode = pointerPrevNode._next;
            }
            return false;
        }

    }
}



