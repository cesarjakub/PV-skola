using System.Collections;

namespace cviceni2410
{
    public class LinkedListEnumerator<T> : IEnumerator<T>
    {

        private MyOneWayLinkedList<T> list;
        private Node<T>? currentNode;
        private bool begin;

        public LinkedListEnumerator(MyOneWayLinkedList<T> list)
        {
            this.list = list;
            begin = true;

        }

        public T Current => currentNode.Value;
        object IEnumerator.Current => currentNode.Value;

        

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (begin)
            {
                begin = false;
                currentNode = list.Head;
                return currentNode != null;
            }
            if (currentNode.Next == null)
            {
                return false;
            }
            currentNode = currentNode.Next;
            return true;
        }

        public void Reset()
        {
            begin = true;
        }
    }
}