using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Queue<T>
    {

        public void Push(LinkList<T> l, T val)
        {
            l.AddLast(val);
        }

        public T Peek(LinkList<T> l)
        {
            if (l == null)
                throw new System.ArgumentNullException("List is empty");
            return l._head._data;
        }

        public void Pop(LinkList<T> l)
        {
            if (l == null)
                throw new System.ArgumentNullException("List is empty");

            l._head = l._head._next;
        }


    }
}
