using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cangul.Doruk.InterviewApp.models
{
    public class Result
    {
        public int WorkOrderNumber { get; set; }
        public Dictionary<string, Double> ResultKeyValues { get; set; } = new Dictionary<string, Double>();
        public double TotalWorkOrder { get; set; }
    }
}
