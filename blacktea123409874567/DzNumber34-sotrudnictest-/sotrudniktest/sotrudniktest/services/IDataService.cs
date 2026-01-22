using sotrudniktest.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sotrudniktest.services
{
    public interface IDataService
    {
        List<User> LoadUser();
        List<TestResult> LoadResults();
        List<Question> LoadQuestion();

        void SaveUsers(List<User> users);
        void SaveResults(List<TestResult> results);
        void SaveQuestions(List<Question> questions);

        void InitialLizeDefaultAdmin();
    }
}
