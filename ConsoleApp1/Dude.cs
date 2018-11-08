using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Dude
    {
        public static int syncObj;

        public List<int> data = new List<int>();

        public int DoStuff()
        {
            lock (syncObj)
            {
                int result = this.ProcessData(this.data);
                return result;
            }
        }

        public void Add(int item)
        {
            this.data.Add(item);
        }

        public abstract int ProcessData(IEnumerable<int> data);
    }
}
