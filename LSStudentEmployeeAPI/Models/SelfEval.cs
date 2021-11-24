using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSStudentEmployeeAPI.Models
{
    public class SelfEval
    {
        public string Id { get; set; }
        public string EvaluatingPersonName { get; set; }
        public double JobKnowledge { get; set; }
        public double QualityOfWork { get; set; }
        public double Communication { get; set; }
        public double Initiative { get; set; }
        public double Reliability { get; set; }
        public bool? giveFeedback { get; set; }
        public string FeedbackFor { get; set; }
        public string FeedBack { get; set; }
    }
}
