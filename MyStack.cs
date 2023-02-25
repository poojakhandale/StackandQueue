using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueue
{
    public class MyStack
    {
        public class Mystack<T>
        {
            private LinkedList<T> list = new LinkedList<T>();

            public void Push(T num)
            {
                list.AddFirst(num);
            }

        }

    }
}
