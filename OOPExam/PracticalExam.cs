using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    internal class PracticalExam : Exam
    {
        public PracticalExam() { }
        public PracticalExam(int time, int numOfQuestions) : base(time, numOfQuestions)
        {
        }

        public new void ShowExam()
        {
            for (int i = 1; i < Questions.Count; i++)
            {
                var question = Questions[i];
                if (question.RightAnswer != null)
                {
                    Console.WriteLine(question.RightAnswer);
                }
              
            }
        }
    }
}
