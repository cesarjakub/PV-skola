using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni2410
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public Node(T value, Node<T> next)
        {
            Value = value;
            Next = next;
        }

        public Node(T value)
        {
            Value = value;
            Next = null;
        }
        public Node()
        {

        }
    }
}
