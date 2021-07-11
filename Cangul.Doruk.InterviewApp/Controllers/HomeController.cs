using Cangul.Doruk.InterviewApp.models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cangul.Doruk.InterviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        public static List<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>()
        {

                new WorkOrder()
                {
                    WorkOrderNumber = 1001,
                    StartDate = new DateTime(2017, 01, 1, 8, 0, 0),
                    FinishDate = new DateTime(2017, 01, 1, 16, 0, 0),
                },
                new WorkOrder()
                {
                    WorkOrderNumber = 1002,
                    StartDate = new DateTime(2017, 01, 1, 16, 0, 0),
                    FinishDate = new DateTime(2017, 01, 2, 0, 0, 0),
                },
                new WorkOrder()
                {
                    WorkOrderNumber = 1003,
                    StartDate = new DateTime(2017, 01, 2, 0, 0, 0),
                    FinishDate = new DateTime(2017, 01, 2, 8, 0, 0),
                },
                new WorkOrder()
                {
                    WorkOrderNumber = 1004,
                    StartDate = new DateTime(2017, 01, 2, 8, 0, 0),
                    FinishDate = new DateTime(2017, 01, 2, 16, 0, 0),
                },
                new WorkOrder()
                {
                     WorkOrderNumber = 1005,
                     StartDate = new DateTime(2017, 01, 2, 16, 0, 0),
                     FinishDate = new DateTime(2017, 01, 3, 0, 0, 0),
                },
                 new WorkOrder()
                {
                     WorkOrderNumber = 1006,
                     StartDate = new DateTime(2017, 01, 3, 0, 0, 0),
                     FinishDate = new DateTime(2017, 01, 3, 8, 0, 0),
                },
                 new WorkOrder()
                {
                     WorkOrderNumber = 1007,
                     StartDate = new DateTime(2017, 01, 3, 8, 0, 0),
                     FinishDate = new DateTime(2017, 01, 3, 16, 0, 0),
                },
                 new WorkOrder()
                {
                     WorkOrderNumber = 1008,
                     StartDate = new DateTime(2017, 01, 3, 16, 0, 0),
                     FinishDate = new DateTime(2017, 01, 4, 0, 0, 0),
                },
                 new WorkOrder()
                {
                     WorkOrderNumber = 1009,
                     StartDate = new DateTime(2017, 01, 4, 0, 0, 0),
                     FinishDate = new DateTime(2017, 01, 4, 8, 0, 0),
                },
        };

        public static List<StopReason> StopReasons { get; set; } = new List<StopReason>()
        {
            new StopReason()
            {
                StopReasonName = "Mola",
                StartDate = new DateTime(2017, 01, 1, 10, 0, 0),
                FinishDate = new DateTime(2017, 01, 1, 10, 10, 0),
            },

            new StopReason()
            {
                StopReasonName = "Arıza",
                StartDate = new DateTime(2017, 01, 1, 10, 30, 0),
                FinishDate = new DateTime(2017, 01, 1, 11, 0, 0),
            },

            new StopReason()
            {
                StopReasonName = "Mola",
                StartDate = new DateTime(2017, 01, 1, 12, 0, 0),
                FinishDate = new DateTime(2017, 01, 1, 12, 30, 0),
            },

            new StopReason()
            {
                StopReasonName = "Mola",
                StartDate = new DateTime(2017, 01, 1, 14, 0, 0),
                FinishDate = new DateTime(2017, 01, 1, 14, 10, 0),
            },

            new StopReason()
            {
                StopReasonName = "Setup",
                StartDate = new DateTime(2017, 01, 1, 15, 0, 0),
                FinishDate = new DateTime(2017, 01, 1, 16, 30, 0),
            },

           new StopReason()
            {
                StopReasonName = "Mola",
                StartDate = new DateTime(2017, 01, 1, 18, 0, 0),
                FinishDate = new DateTime(2017, 01, 1, 18, 10, 0),
            },

           new StopReason()
            {
                StopReasonName = "Mola",
                StartDate = new DateTime(2017, 01, 1, 20, 0, 0),
                FinishDate = new DateTime(2017, 01, 1, 20, 30, 0),
            },

           new StopReason()
            {
                StopReasonName = "Mola",
                StartDate = new DateTime(2017, 01, 1, 22, 0, 0),
                FinishDate = new DateTime(2017, 01, 1, 22, 10, 0),
            },


            new StopReason()
            {
                StopReasonName = "Arge",
                StartDate = new DateTime(2017, 01, 1, 23, 0, 0),
                FinishDate = new DateTime(2017, 01, 2, 8, 30, 0),
            },

            new StopReason()
            {
                StopReasonName = "Mola",
                StartDate = new DateTime(2017, 01, 2, 10, 0, 0),
                FinishDate = new DateTime(2017, 01, 2, 10, 10, 0),
            },

            new StopReason()
            {
                StopReasonName = "Mola",
                StartDate = new DateTime(2017, 01, 2, 12, 0, 0),
                FinishDate = new DateTime(2017, 01, 2, 12, 30, 0),
            },

            new StopReason()
            {
                StopReasonName = "Arıza",
                StartDate = new DateTime(2017, 01, 2, 13, 0, 0),
                FinishDate = new DateTime(2017, 01, 2, 13, 45, 0),
            },

            new StopReason()
            {
                StopReasonName = "Mola",
                StartDate = new DateTime(2017, 01, 2, 14, 0, 0),
                FinishDate = new DateTime(2017, 01, 2, 14, 10, 0),
            },

            new StopReason()
            {
                StopReasonName = "Mola",
                StartDate = new DateTime(2017, 01, 2, 18, 0, 0),
                FinishDate = new DateTime(2017, 01, 2, 18, 10, 0),
            },
             new StopReason()
            {
                StopReasonName = "Arge",
                StartDate = new DateTime(2017, 01, 2, 20, 0, 0),
                FinishDate = new DateTime(2017, 01, 3, 02, 10, 0),
            },
            new StopReason()
            {
                StopReasonName = "Mola",
                StartDate = new DateTime(2017, 01, 3, 4, 0, 0),
                FinishDate = new DateTime(2017, 01, 3, 4, 30, 0),
            },
            new StopReason()
            {
                StopReasonName = "Setup",
                StartDate = new DateTime(2017, 01, 3, 6, 0, 0),
                FinishDate = new DateTime(2017, 01, 3, 9, 30, 0),
            },
            new StopReason()
            {
                StopReasonName = "Mola",
                StartDate = new DateTime(2017, 01, 3, 10, 0, 0),
                FinishDate = new DateTime(2017, 01, 3, 10, 10, 0),
            },
            new StopReason()
            {
                StopReasonName = "Mola",
                StartDate = new DateTime(2017, 01, 3, 12, 0, 0),
                FinishDate = new DateTime(2017, 01, 3, 12, 30, 0),
            },
            new StopReason()
            {
                StopReasonName = "Mola",
                StartDate = new DateTime(2017, 01, 3, 14, 0, 0),
                FinishDate = new DateTime(2017, 01, 3, 14, 10, 0),
            },
            new StopReason()
            {
                StopReasonName = "Arıza",
                StartDate = new DateTime(2017, 01, 3, 15, 0, 0),
                FinishDate = new DateTime(2017, 01, 3, 18, 45, 0),
            },
            new StopReason()
            {
                StopReasonName = "Mola",
                StartDate = new DateTime(2017, 01, 3, 20, 0, 0),
                FinishDate = new DateTime(2017, 01, 3, 20, 30, 0),
            },
            new StopReason()
            {
                StopReasonName = "Mola",
                StartDate = new DateTime(2017, 01, 3, 22, 0, 0),
                FinishDate = new DateTime(2017, 01, 3, 22, 10, 0),
            },
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(CreateResultList());
        }

        private static List<Result> CreateResultList()
        {
            List<Result> Results = new List<Result>();
            HashSet<String> Keys = new HashSet<String>();

            foreach (var workOrder in WorkOrders)
            {
                var result = new Result();
                result.WorkOrderNumber = workOrder.WorkOrderNumber;

                foreach (var stopReasons in StopReasons)
                {
                    if (CheckBetweenTimeStartEndfinishDate(workOrder, stopReasons))
                    {
                        Keys.Add(stopReasons.StopReasonName);
                        AddDictionaryValue(result, stopReasons, workOrder);
                    }
                    else
                    {
                        if (!result.ResultKeyValues.ContainsKey(stopReasons.StopReasonName))
                            result.ResultKeyValues.Add(stopReasons.StopReasonName, 0);
                    }
                }
                Results.Add(result);
            }

            AddSumResultsLastIndex(ref Results,ref Keys);
            return  Results ;
        }

        private static void AddSumResultsLastIndex(ref List<Result> Results,ref HashSet<String> Keys)
        {
            SortedDictionary<String, double> SumDictionary = new SortedDictionary<string, double>();

            foreach (var key in Keys)
            {
                SumDictionary.Add(key, Results.Sum(x => x.ResultKeyValues[key]));
            }
            Results.Add(new Result() { WorkOrderNumber = 0, TotalWorkOrder = Results.Sum(x => x.TotalWorkOrder), ResultKeyValues = SumDictionary });
        }

        private static void AddDictionaryValue(Result result, StopReason stopReason, WorkOrder workOrder)
        {
            Double timeDiff= CalculateTimeDiff(stopReason, workOrder);

            if (result.ResultKeyValues.ContainsKey(stopReason.StopReasonName))
            {
                result.ResultKeyValues[stopReason.StopReasonName] += timeDiff;
            }
            else
            {
                result.ResultKeyValues.Add(stopReason.StopReasonName, timeDiff);
            }
            result.TotalWorkOrder += timeDiff;
        }

        private static double CalculateTimeDiff(StopReason stopReason, WorkOrder workOrder) 
        {
            DateTime StartDate = stopReason.StartDate;
            DateTime FinishDate = stopReason.FinishDate;

            if (workOrder.StartDate > StartDate)
            {
                StartDate = workOrder.StartDate;
            }
            if (workOrder.FinishDate < FinishDate)
            {
                FinishDate = workOrder.FinishDate;
            }
            return (FinishDate - StartDate).TotalMinutes;
        }

        private static bool CheckBetweenTimeStartEndfinishDate(WorkOrder workOrder, StopReason stopReason)
        {
            
             /*Duruş Emir saat aralıkları dışında işe false içinde true dönen kayıt
              *Daha sade ve anlasılır.
             */
             if(workOrder.StartDate>stopReason.StartDate && workOrder.StartDate > stopReason.FinishDate)
             {
                 return false;
             }
             if (workOrder.FinishDate < stopReason.StartDate && workOrder.FinishDate < stopReason.FinishDate)
             {
                 return false;
             }
             return true;

            /*
             * Eski algoritma => Doğru çalısıyor
             * Biraz Daha karışık
             if (workOrder.FinishDate >= stopReason.StartDate && workOrder.StartDate < stopReason.FinishDate)
             {
                 return true;
             }
             else
             {
                 return (stopReason.StartDate >= workOrder.StartDate
                  && stopReason.StartDate < workOrder.FinishDate);
             }
            */

        }
    }
}
