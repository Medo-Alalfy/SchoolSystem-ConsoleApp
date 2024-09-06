using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace School__System.Models
{
    public class Grade
    {
        public string Subject { get; set; }
        public double Score { get; set; }

        public Grade(string subject, double score)
        {
            Subject = subject;
            Score = score;
        }

        public void PrintGrade()
        {
            Console.WriteLine($"Subject: {Subject}, Score: {Score}");
        }
    }
}
