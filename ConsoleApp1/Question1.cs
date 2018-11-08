using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Question1
    {
        public void Run()
        {
            var data = new int[1000 * 1000 * 1000];
            var result1 = this.MethodA(data);
            var result2 = this.MethodB(data);
        }

        private int MethodA(int[] input)
        {
            return input.Length;
        }

        private int MethodB(IEnumerable<int> input)
        {
            return input.Count();
        }
    }
}
