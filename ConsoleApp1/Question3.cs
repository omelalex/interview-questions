using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Question3
    {
        public class Job
        {
            public Guid Id { get; set; }

            public DateTime StartTime { get; set; }

            public DateTime EndTime { get; set; }
        }

        public int MaxJobsRunningSimultaneously(IEnumerable<Job> jobs)
        {
            throw new NotImplementedException();
        }
    }
}
