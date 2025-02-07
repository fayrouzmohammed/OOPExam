using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    internal class Answer : IComparable<Answer>
    {
        public Answer() { }
        public Answer(int answerId, string? answerText)
        {
           this.AnswerId = answerId;
            this.AnswerText = answerText;
        }

        public int AnswerId { get; set; }
        public string? AnswerText { get; set; }

        public int CompareTo(Answer? X)
        {
            if (X == null)
            { return 1; }

            return AnswerId.CompareTo(X.AnswerId);
        }
    }
}

