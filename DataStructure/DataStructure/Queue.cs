using System.Collections;
namespace DataStructure
{
    public class Queue<T> : IEnumerable
    {
        private LinkList<T> q;

        public Queue()
        {
            q = new LinkList<T>();
        }

        public void enqueue(T val)
        {
            q.AddLast(val);
        }

        public T Peek()
        {
            if (q == null)
                throw new System.ArgumentNullException("List is empty");
            return q._head._data;
        }

        public T dequeue()
        {
            if (q == null)
                throw new System.ArgumentNullException("List is empty");

            T val = q._head._data;
            q._head = q._head._next;
            return val;
        }

        public IEnumerator GetEnumerator()
        {
            foreach(Node<int> n in q)
            {
                yield return n._data;
            }

        }

    }
}
