using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cangul.Doruk.InterviewApp.models
{
    public class Result
    {
        public int WorkOrderNumber { get; set; }
        public SortedDictionary<string, Double> ResultKeyValues { get; set; } = new SortedDictionary<string, Double>();
        public double TotalWorkOrder { get; set; }
    }
}
