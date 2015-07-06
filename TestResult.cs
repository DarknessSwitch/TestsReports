using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsReports
{
    class TestResult
    {
        public Test Test { get; set; }
        public User User { get; set; }
        public int Result { get; set; }
        public int TimeTaken { get; set; }
    }
}
