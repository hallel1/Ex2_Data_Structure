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

        public LinkList(){
            _head = null;
            _tail = null;
        }
        public void AddFirst(T t)
        {
            Node<T> toAdd = new Node<T>(t);
            toAdd.next = _head;

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
                _tail.next = toAdd;
            }
            _tail = toAdd;
        }

        public void AddAfterExistsNode(Node<T> existNode, T newVal)
        {
            Node<T> toAdd = new Node<T>(newVal);
            
        }

    }
}
