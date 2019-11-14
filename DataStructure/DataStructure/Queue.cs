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

        public T Pop(LinkList<T> l)
        {
            if (l == null)
                throw new System.ArgumentNullException("List is empty");

            T val = l._head._data;
            l._head = l._head._next;
            return val;
        }


    }
}
