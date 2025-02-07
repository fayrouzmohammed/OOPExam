using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    internal abstract class Exam
    {
        protected Exam() { }
        public Exam(int time, int numOfQuestions)
        {
            this.Time = time;
            this.NumOfQs = numOfQuestions;
        }

        public int Time { get; set; }
        public int NumOfQs { get; set; }

        public List<Question> Questions { get; set; } = new List<Question>();


        public virtual void ShowExam()
        {
            double totalMarks = 0;
            double userMarks = 0;

            if (this is PracticalExam)
            {

                PracticalExam practical = (PracticalExam)this;

                practical.ShowExam();
            }
            else if (this is FinalExam)
            {
                FinalExam final = (FinalExam)this;

                final.ShowExam();

                Console.WriteLine("Your marks: " + userMarks + "/" + totalMarks);
            }


            if (Questions.Count == 0 || Questions == null)
            {
                Console.WriteLine("Unavailable Questions.");
                return;
            }

            for (int i = 1; i < Questions.Count; i++)
            {
                var question = Questions[i];
                if (question is MCQQuestions mcqQuestion)
                {
                    Console.WriteLine("Choose the correct answer: ");
                    question.ShowQustion();
                    Console.Write("Your answer: ");
                    string? userAnswer = Console.ReadLine();

                    if (int.TryParse(userAnswer, out int answerId)  && answerId <= mcqQuestion.AnswerList.Count && answerId >= 1)
                    {
                        if (mcqQuestion.AnswerList[answerId - 1].AnswerId.CompareTo(mcqQuestion.RightAnswer.AnswerId) == 0)
                        {
                            Console.WriteLine("Correct Aswer");
                            userMarks += question.Mark;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect Answer");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Asnwer.");
                    }
                }
                else if (question is TrueOrFalseQuestions tAndfQuestion)
                {
                    question.ShowQustion();
                    string? userAnswer = Console.ReadLine();

                    if (userAnswer.Equals(tAndfQuestion.RightAnswer.AnswerText, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Correct Aswer");
                        userMarks += question.Mark;
                    }
                    else
                    {
                        Console.WriteLine("InCorrect Aswer");
                    }
                }

                totalMarks += question.Mark;
            }


        }

    }
}
