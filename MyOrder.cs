using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class MyOrder
    {
        private List<int> list;

        public MyOrder()
        {
            list = new List<int>();
        }

        public int Count
        {
            get { return list.Count; }
        }

        public void Push(int item)
        {
            list.Add(item);
        }

        public int Pop()
        {
            int item = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return item;
        }

        public int Front()
        {
            return list[1];
        }

        public void Clear()
        {
            list.Clear();
        }

    }
}
