using System;
using System.Collections;

namespace DataStructure
{

    public class LinkList<T> : LinkListInterface<T> , IEnumerable
    {
        public Node<T> _head { get; set; }
        public Node<T> _tail { get; set; }
        public LinkList()
        {
            _head = null;
            _tail = null;
        }
        public LinkList(Node<T> n)
        {
            _head = n;
            var pointerMoveOnList = _head;
            while (pointerMoveOnList._next != null)
            {
                
                pointerMoveOnList = pointerMoveOnList._next;
            }
            _tail = pointerMoveOnList;

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
        public void AddBefforeExistsNode(Node<T> existNode, T val)
        {
            Node<T> toAdd = new Node<T>(val);
            if (_head._data.Equals(existNode._data))
                AddFirst(val);

            Node<T> prevNode = GetPrevNodeByVal(existNode._data);
            if(prevNode == null)
                throw new System.ArgumentException("This node does not exist");

            toAdd._next = prevNode._next;
            prevNode._next = toAdd;
            


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
                nodeInIndex._data = value;
            }

        }
        public IEnumerator GetEnumerator()
        {
            var pointerMoveOnList = _head;
            while (pointerMoveOnList != null)
            {
                yield return pointerMoveOnList;
                pointerMoveOnList = pointerMoveOnList._next;

            }

        }
#region private_function

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
            Node<T> pointerPrevNode = GetPrevNodeByVal(val);
            if (pointerPrevNode == null)
                return false;

            if(pointerPrevNode._next == _tail)
                _tail = pointerPrevNode;

            pointerPrevNode._next = pointerPrevNode._next._next;
            return true;

        }
        private Node<T> GetPrevNodeByVal(T val)
        {
            Node<T> pointerMoveOnList = _head;
            Node<T> pointerPrevNode = _head;

            while (pointerMoveOnList._next != null)
            {
                pointerMoveOnList = pointerMoveOnList._next;
                if (pointerMoveOnList._data.Equals(val))
                {                  
                    return pointerPrevNode;
                }
                pointerPrevNode = pointerPrevNode._next;
            }
            return null;
        }

#endregion

    }
}



