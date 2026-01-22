using sotrudniktest.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sotrudniktest.services
{
    public class DataService: IDataService
    {

        private const string UserFile = "user.txt";
        private const string ResultFile = "result.txt";
        private const string QuestionFile = "questions.txt";

        public List<User> LoadUser()
        {
            var user = new List<User>();
            if (!File.Exists(UserFile)) 
            {
                return user;
            }
            try
            {
                foreach(string line in File.ReadLines(UserFile))
                {
                    string[] parts = line.Split('|');
                    if (parts.Length >= 4)
                    {
                        user.Add
                            (
                                new User
                                {
                                    Login = parts[0],
                                    Password = parts[1],
                                    FIO = parts[2],
                                    Position = parts[3]
                                }
                            );
                    }
                }
            }
            catch (Exception) 
            {

            }
            return user;
        }
        public List<TestResult> LoadResults()
        {
            var result = new List<TestResult>();
            if (!File.Exists(ResultFile))
            {
                return result;
            }
            try
            {
                foreach (string line in File.ReadLines(UserFile))
                {
                    string[] parts = line.Split('|');
                    if (parts.Length >= 5)
                    {
                        result.Add
                            (
                                new TestResult 
                                {
                                    UserLogin = parts[0],
                                    TestTopic = parts[1],
                                    Date = DateTime.Parse(parts[2]),
                                    Score =int.Parse(parts[2]),
                                    MaxScore = int.Parse(parts[3])
                                }
                            );
                    }
                }
            }
            catch (Exception)
            {

            }
            return result;
        }
        public List<Question> LoadQuestion()
        {
            var question = new List<Question>();
            if (!File.Exists(QuestionFile))
            {
                return question;
            }
            try
            {
                Question current = null;
                
                foreach (string line in File.ReadLines(QuestionFile))
                {
                    if (line.StartsWith("TOPIC:"))
                    {
                        current = new Question { Topic = line.Substring(6) };
                    }
                    else if (line.StartsWith("TEXT:"))
                    {
                        current.Text = line.Substring(5) ;
                    }
                    else if (line.StartsWith("OPINION:") && current != null)
                    {
                        current.Opinion.Add( line.Substring(7));
                    }
                    else if (line.StartsWith("CORRECT:") && current != null)
                    {
                        string[] nums = line.Split(',');
                        foreach (string num in nums)
                        {
                            if (int.TryParse(num, out int CorrectNum))
                                current.CorrectAnswers.Add(int.Parse(num));
                        }
                    }
                    question.Add(current);
                    current = null;
                }
            }
            catch (Exception)
            {

            }
            return question;
        }

        


        public void SaveUsers(List<User> users) 
        {
            try 
            {
                var lines = users.Select(U => $"{U.Login}|{U.Password}|{U.FIO}|{U.Position}");
                File.WriteAllLines(UserFile,lines);
            }
            catch(Exception) 
            {

            }
        }
        public void SaveResults(List<TestResult> results)
        {
            try
            {
                var lines = results.Select(U => $"{U.UserLogin}|{U.TestTopic}|{U.Date}|{U.Score}|{U.MaxScore}");
                File.WriteAllLines(ResultFile, lines);
            }
            catch (Exception)
            {

            }
        }
        public void SaveQuestions(List<Question> questions)
        {
            try
            {
                var lines = new List<string>();
                foreach (var question in questions) 
                {
                    lines.Add($"TOPIC:{question.Topic}");
                    lines.Add($"TEXT:{question.Text}");
                    foreach(var question2 in questions)
                    {
                        lines.Add($"OPTION:{question2}");
                    }
                    lines.Add($"CORRECT:{string.Join(",", question.CheckAnswer)}");
                }
                File.WriteAllLines(QuestionFile, lines);
            }
            catch (Exception)
            {

            }
        }

        public void InitialLizeDefaultAdmin() 
        {
            User Admin = new User() { FIO = "Admin",Login = "Admin",Password = "2444666668888888",Position = "admin" };
        }
    }
}
