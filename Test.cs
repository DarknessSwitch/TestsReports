using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsReports
{
    class Test
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public List<Question> Questions { get; set; }
        public int TimeGiven { get; set; }
        public int PassingScore { get; set; }
    }
}
