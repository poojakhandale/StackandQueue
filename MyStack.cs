using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueue
{
    public class Mystack<T>
    {
        private LinkedList<T> list = new LinkedList<T>();

        public void Push(T num)
        {
            list.AddFirst(num);
        }
        public void pop()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("List is empty");
                return;
            }
            T value = list.First.Value;
            list.RemoveFirst();
            System.Console.WriteLine(value);
        }

        public void Peek()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("List is empty");
            }
            T value = list.First.Value;
            Console.WriteLine("The peek element is {0}", value);
        }
    }
}



    
  
