using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRANHIGS.Classes
{
    public class CaseEntities
    {
        public int caseNumber { get; set; }
        public string taskCase { get; set; }
        public string questionTask { get; set; }
        public Answer[] answers { get; set; }
        public string explanation { get; set; }
    }
    public class Rootobject
    {
        public CaseEntities[] Property1 { get; set; }
    }

    public class Answer
    {
        public string answerText { get; set; }
        public bool correctAnswer { get; set; }
    }
}
