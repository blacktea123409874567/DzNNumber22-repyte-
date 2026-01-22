using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sotrudniktest.model
{
    public class Question
    {
        public string Topic {  get; set; }

        public List<string> Opinion { get; set; }

        public List<int> CorrectAnswers { get; set; }

        public string Text { get; set; }


        public Question() 
        {
            Opinion  = new List<string>();
            CorrectAnswers = new List<int>();
        }

        public bool CheckAnswer(List<int> userAnswers)
        {
            if (userAnswers == null || userAnswers.Count != CorrectAnswers.Count)
            {
                return false;
            }
            return userAnswers.OrderBy(x => x).SequenceEqual(CorrectAnswers.OrderBy(x => x));
        }

    }
}
