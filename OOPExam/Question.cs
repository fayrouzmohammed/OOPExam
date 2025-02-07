using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    internal abstract class Question
    {
        protected Question() { }

        public Question(string? head, string? body, double mark)
        {
            this.Head = Head;
            this.Body = Body;
            this.Mark = Mark;
        }

        public string? Head { get; set; }
        public string? Body { get; set; }
        public double Mark { get; set; }

        public List<Answer> AnswerList { get; set; } = new List<Answer>();
        public Answer RightAnswer { get; set; }

        public abstract void ShowQustion();

        public override string ToString()
        {
            return "Head :" + Head +" Body: " + Body + " Mark :" + Mark;
        }
    }
}
