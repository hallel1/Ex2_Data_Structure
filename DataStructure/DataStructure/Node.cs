using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Node<T>
    {
        public T _data { get; set; }
        public Node<T> _next { get; set; }

       // public int _index { get; set; }

        public Node(T t)
        {
            _next = null;
            _data = t;
          //  _index = index;
        }
    }
}
