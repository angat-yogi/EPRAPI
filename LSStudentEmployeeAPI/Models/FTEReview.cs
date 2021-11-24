using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSStudentEmployeeAPI.Models
{
    public class FTEReview
    {
        public string Id { get; set; }
        public string EvaluatingPersonName { get; set; }
        public string EvaluatingFor { get; set; }
        public double JobKnowledge { get; set; }
        public double QualityOfWork { get; set; }
        public double Communication { get; set; }
        public double Initiative { get; set; }
        public double Reliability { get; set; }
        public string ConstructiveFeedback { get; set; }
        public string PositiveFeedBack { get; set; }
    }
}
