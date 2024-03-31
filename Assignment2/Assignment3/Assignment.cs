using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Student
{
    public class Assignment
    {
        public string AssignmentID { get; set; }
        public int Score { get; set; }
        public int MaxScore { get; set; }

        public Assignment(string assignmentID, int score, int maxScore)
        {
            this.AssignmentID = assignmentID;
            this.Score = score;
            this.MaxScore = maxScore;
        }

        public Assignment()
        {
            MaxScore = 100;
        }
    }
}
