using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sotrudniktest.model
{
    public class TestResult
    {
        public string UserLogin { get; set; }

        public string TestTopic { get; set; }
        public int Score {  get; set; }

        public DateTime Date { get; set; }

        public int MaxScore {  get; set; }


        public override string ToString()
        {
            return $"{Date:dd:MM:yyyy HH:mm} - {TestTopic}: {Score}/{MaxScore}";
        }

        public double GetPercentage()
        {
            return (MaxScore>0) ? (Score*100.0) /(MaxScore) : 0; 
        }

    }
}
