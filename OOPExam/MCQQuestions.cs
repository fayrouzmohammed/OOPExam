using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    internal class MCQQuestions  : Question
    {
        public MCQQuestions() { }
        public MCQQuestions(string? head, string? body, double mark) : base(head, body, mark)
        {
        }

        public override void ShowQustion()
        {
            for (int i = 1; i < AnswerList.Count; i++)
            {
                Console.WriteLine("(" + i + "): " + AnswerList[i].AnswerText);
            }
        }
    }
}