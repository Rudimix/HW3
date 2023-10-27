using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class MyDeque<T>
    {
        DoublyNode<T> head;
        DoublyNode<T> tail;
        int count;

        public bool IsEmpty
        {
            get { return count == 0; }
        }

        public void AddFront(T item)
        {
            DoublyNode<T> node = new DoublyNode<T>(item);
            DoublyNode<T> temp = head;
            node.Next = temp;
            head = node;
            if (IsEmpty)
                tail = head;
            else
                temp.Previous = node;
            count++;
        }
        public void AddBack(T item)
        {
            DoublyNode<T> node = new DoublyNode<T>(item);
            if (IsEmpty)
                head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            count++;
        }
        public T RemoveFront()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            T output = head.Data;
            head = head.Next;
            if (head != null)
                head.Previous = null;
            else
                tail = null;
            count--;
            return output;
        }
        public T RemoveBack()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            T output = tail.Data;
            tail = tail.Previous;
            if (tail != null)
                tail.Next = null;
            else
                head = null;
            count--;
            return output;
        }
        public int[] Find(T item)
        {
            List<int> positions = new List<int>();
            DoublyNode<T> current = head;
            int position = 0;
            while (current != null)
            {
                if (current.Data.Equals(item))
                {
                    positions.Add(position);
                }
                current = current.Next;
                position++;
            }
            return positions.ToArray();
        }

        public void Print()
        {
            DoublyNode<T> current = head;
            while (current != null)
            {
                Console.Write($"{current.Data} ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public void Remove(T item)
        {
            DoublyNode<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(item))
                {
                    if (current.Previous != null)
                    {
                        current.Previous.Next = current.Next;
                    }
                    else
                    {
                        head = current.Next;
                    }
                    if (current.Next != null)
                    {
                        current.Next.Previous = current.Previous;
                    }
                    else
                    {
                        tail = current.Previous;
                    }
                    count--;
                    break;
                }
                current = current.Next;
            }
        }
    }
}
