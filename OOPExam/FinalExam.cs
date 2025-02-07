using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    internal class FinalExam : Exam
    {
        public FinalExam() { }
        public FinalExam(int time, int numOfQuestions) : base(time, numOfQuestions)
        {
        }

        public new void ShowExam()
        {
            for (int i = 1; i < Questions.Count; i++)
            {
                var question = Questions[i];
                Console.WriteLine("Question (" + i + "): " + question.Body);

                if (question.RightAnswer != null)
                {
                    Console.WriteLine(question.RightAnswer.AnswerText);
                }
            }

        }
    }
}
