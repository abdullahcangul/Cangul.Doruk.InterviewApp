using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cangul.Doruk.InterviewApp.models
{
    public class WorkOrder
    {
        public int WorkOrderNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
    }
}
