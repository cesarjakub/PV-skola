using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni2410
{
    public class MyOneWayLinkedList<T> : IMyLinkedList<T>, IEnumerable<T>
    {

        #region
        private Node<T>? head = null;
        public Node<T>? Head { get { return head; } }
        public int count = 0;

        public int Count { get { return count; } }

        public void AddToEnd(T element)
        {
            if(head == null)
            {
                head = new Node<T>();

                head.Value = element;
                head.Next = null;
            }
            else
            {
                Node<T> toAdd = new Node<T>();
                toAdd.Value = element;

                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = toAdd;
            }

        }

        public void AddToFront(T element)
        {
            Node<T> node = new Node<T>(element);
            node.Next = head;
            head = node;
            count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("blbej index");
            }
            Node<T>? node = head;
            int i = 0;
            while (node != null)
            {
                if (i == index)
                {
                    return node.Value;
                }
                node = node.Next;
                i++;
            }
            throw new Exception("nikdy se sem nedostanem");
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new LinkedListEnumerator<T>(this);
        }

        public void InsertAfter(T element, int index)
        {
            
        }

        public void InsertBefor(T element, int index)
        {
           
        }

        public void Remove(int index)
        {
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        #endregion

    }
}
