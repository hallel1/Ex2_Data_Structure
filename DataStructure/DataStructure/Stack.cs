using System.Collections;
namespace DataStructure
{
    class Stack<T> : IEnumerable
    {
        private LinkList<T> stck;

        public Stack()
        {
            stck = new LinkList<T>();
        }
        public void Push(T val)
        {
            stck.AddFirst(val);
        }

        public T Peek()
        {
            if (stck == null)
                throw new System.ArgumentNullException("List is empty");
            return stck._tail._data;
        }

        public T Pop()
        {
            if (stck == null)
                throw new System.ArgumentNullException("List is empty");

            T val = stck._head._data;
            stck._head = stck._head._next;
            return val;
        }
        public IEnumerator GetEnumerator()
        {
            
            foreach (Node<int> n in stck)
            {
                yield return n._data;
            }

        }

    }
}
