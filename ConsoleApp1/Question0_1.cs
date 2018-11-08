using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Question0_1
    {
        public void Run()
        {
            // What will be allocated in stack and what will be in heap 
            var foo = new Foo();
        }

        class Foo
        {
            int Field1;
            string Field2;
            object Field3;
        }
    }
}
