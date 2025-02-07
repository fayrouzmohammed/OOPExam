using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    internal class TrueOrFalseQuestions : Question
    {
        public TrueOrFalseQuestions() { }
        public TrueOrFalseQuestions(string? head, string? body, double mark) : base(head, body, mark)
        {
        }

        public override void ShowQustion()
        {
            Console.WriteLine("header : " + Head + Body );
        }
    }
}
