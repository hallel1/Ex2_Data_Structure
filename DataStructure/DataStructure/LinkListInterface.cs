using System.Collections;

namespace DataStructure
{
    public interface LinkListInterface<T>
    {
        Node<T> _head { get; set; }
        Node<T> _tail { get; set; }
        void AddFirst(T t);
        void AddLast(T t);
        void AddAfterExistsNode(Node<T> existNode, T newVal);
        void DeleteNode(T val);
        void AddBefforeExistsNode(Node<T> existNode, T newVal);

        IEnumerator GetEnumerator();
        T this[int index] { get; set; }
    }
}
