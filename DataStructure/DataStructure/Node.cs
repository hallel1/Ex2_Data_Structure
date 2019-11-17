namespace DataStructure
{
    public class Node<T>
    {
        public T _data { get; set; }
        public Node<T> _next { get; set; }

        public Node(T t)
        {
            _next = null;
            _data = t;
        }
        public Node(T t,Node<T> nextNode)
        {
            _next = nextNode;
            _data = t;
        }
    }
}
