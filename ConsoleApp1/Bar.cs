using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bar
    {
        public Bar()
        {
            SomeValue = 10;
        }

        public int SomeValue { get; }

        public void SomeMethod()
        {
            SomeValue = 20;
        }
    }
}
