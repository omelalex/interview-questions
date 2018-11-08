using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Question2<T>
    {
        public static object syncObj;
        //public static int syncObj;

        public List<T> data = new List<T>();

        public int DoStuff()
        {
            lock (syncObj)
            {
                int result = this.ProcessData(this.data);
                return result;
            }
        }

        public void Add(T item)
        {
            lock (syncObj)
            {
                this.data.Add(item);
            }
        }

        public void Remove(T item)
        {
            lock (syncObj)
            {
                data.Remove(item);
            }
        }

        public abstract int ProcessData(IEnumerable<T> data);
    }
}
