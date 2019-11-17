using System.Collections;
namespace DataStructure
{
    public class Stack<T> : IEnumerable
    {
        private LinkListInterface<T> stck;

        public Stack(LinkListInterface<T> l)
        {
            // stck = new LinkList<T>(n);
            stck = l;
        }
        public void Push(T val)
        {
            stck.AddFirst(val);
        }

        public T Peek()
        {
            if (stck == null)
                throw new System.ArgumentNullException("List is empty");
            return stck[0];
        }

        public T Pop()
        {
            T val = stck[0];
            stck.DeleteNode(val);
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
