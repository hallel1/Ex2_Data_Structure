using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure 
{

    class LinkList<T> : LinkListInterface
    {
        private Node<T> head;

        public LinkList(){
            head = null;
        }
        public void AddFirst(T t)
        {
            Node<T> tmp = new Node<T>(t);
            tmp.next = head;
            head = tmp;
        }
    }
}
