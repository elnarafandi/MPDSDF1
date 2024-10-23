using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MPDSDF1.Task1
{
    internal class Student
    {
        public int StudentId;
        public string Name;
        private string _email;
        private List<int> _scores;

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                bool result =Regex.IsMatch(value, pattern);
                if (result)
                {
                    _email = value;
                }
                else
                {
                    throw new WrongFormatException("Email format is wrong");
                }
            }
        }


        public List<int> Scores
        {
            get
            {
                return _scores;
            }
            set
            {
                
                foreach (int score in value)
                {
                    if (score < 0)
                    {
                        throw new ArgumentException("Score can not be negative");
                    }
                    
                }
                _scores = value;
            }
        }

        public void AddScore(int score)
        {
            Scores.Add(score);
        }

        public double GetAverageScore()
        {
            double sum = 0;
            int count = 0;
            foreach (int score in Scores)
            {
                sum+=score;
                count++;
            }
            double result =sum/count;

            return result ;
        }

        //public double AverageScore
        //{
        //    get
        //    {
        //        return _scores.Count > 0 ? _scores.Average() : 0.0;
        //    }
        //}
    }
}
