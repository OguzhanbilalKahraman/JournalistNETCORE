using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewStructure.Models
{
    public class WorkChart
    {
        public WorkChart(string _journalistName, List<bool> _chart)
        {
            JournalistName = _journalistName;
            Chart = _chart;

        }
        public string JournalistName { get; set; }

        public List<bool> Chart { get; set; }
    }


}
