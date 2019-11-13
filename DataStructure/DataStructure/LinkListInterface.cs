using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public interface LinkListInterface<T>
    {
        void AddFirst(T t);
        void AddLast(T t);
        void AddAfterExistsNode(Node<T> existNode, T newVal);
        void DeleteNode(T val);
        void AddBefforeExistsNode(Node<T> existNode, T newVal);
    }
}
