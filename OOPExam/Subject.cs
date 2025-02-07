using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    internal class Subject
    {
        
        
            public Subject(int subjectId, string subjectName)
            {
                SubjectId = subjectId;
                SubjectName = subjectName;
            }

            public int SubjectId { get; set; }
            public string SubjectName { get; set; }
            public Exam exam { get; set; }

            public void CreateExam()
            {
                Console.WriteLine("PracticalExam => P / FinalExam => F");
                char X = char.Parse(Console.ReadLine() ?? "0");

                if (X == 'P')
                {
                    exam = new PracticalExam();
                }
                else if (X == 'F')
                {
                    exam = new FinalExam();
                }

                Console.Write("Enter Time of Exam in Minutes: ");
                exam.Time = int.Parse(Console.ReadLine() ?? "0");

                Console.Write("Enter Number of Questions: ");
                exam.NumOfQs = int.Parse(Console.ReadLine() ?? "0");

                if (exam is FinalExam)

                {

                //HEAD BODY MARK
                    for (int i = 1 ; i < exam.NumOfQs; i++)
                    {
                        Console.WriteLine("MCQ => 1  /  True/False => 2");
                        char Y = char.Parse(Console.ReadLine() ?? "0");

                        Question question;
                        if (Y == '1')
                        {
                            question = new MCQQuestions();
                            question.Head = "MCQ Questions";
                        }
                        else
                        {
                            question = new TrueOrFalseQuestions();
                            question.Head = "True or False Questions";
                        }

                        Console.Write("body:");
                        question.Body = Console.ReadLine();

                        Console.Write("mark:");
                        question.Mark = int.Parse(Console.ReadLine() ?? "0");



                        if (question is MCQQuestions mcqQuestion)
                        {
                            Console.WriteLine("no. of choices:");
                            int numChoices = int.Parse(Console.ReadLine() ?? "0");

                            for (int j = 1; j < numChoices; j++)
                            {
                            Console.WriteLine("choice " + j);
                                string choice = Console.ReadLine();

                                mcqQuestion.AnswerList.Add(new Answer { AnswerId = j + 1, AnswerText = choice });
                            }

                            Console.WriteLine("the answer: ");
                            int rightAnswer = int.Parse(Console.ReadLine() ?? "0");

                            mcqQuestion.RightAnswer = mcqQuestion.AnswerList.FirstOrDefault(a => a.AnswerId == rightAnswer);
                        }
                        else if (question is TrueOrFalseQuestions tfQuestion)
                        {
                            Console.WriteLine("right answer? (True=> t , False => f):");
                            int rightanswer = int.Parse(Console.ReadLine() ?? "0");

                            if (rightanswer == 't')
                            {
                                tfQuestion.RightAnswer = new Answer { AnswerId = 1, AnswerText = "True" };
                            }
                            else
                            {
                                tfQuestion.RightAnswer = new Answer { AnswerId = 2, AnswerText = "False" };
                            }
                        }

                        exam.Questions.Add(question);
                    }
                }

                else if (exam is PracticalExam)
                {
                    for (int i = 1; i < exam.NumOfQs; i++)
                    {
                        Question question = new MCQQuestions();
                        question.Head = "MCQ Questions";

                        Console.Write("body:");
                        question.Body = Console.ReadLine();

                        Console.Write("Mark: ");
                        question.Mark = int.Parse(Console.ReadLine() ?? "0");

                        Console.WriteLine("no. of choices:");
                        int nochoices = int.Parse(Console.ReadLine() ?? "0");

                        for (int j = 1; j < nochoices; j++)
                        {
                            Console.WriteLine("choice: " + j);
                        
                            string choice = Console.ReadLine();
                            question.AnswerList.Add(new Answer { AnswerId = j, AnswerText = choice });
                        }

                        Console.WriteLine("right answer? ");
                        int rightanswer = int.Parse(Console.ReadLine() ?? "0");
                        question.RightAnswer = question.AnswerList.FirstOrDefault(a => a.AnswerId == rightanswer);

                        exam.Questions.Add(question);
                    }
                }

            }

            public override string ToString()
            {
                return "SubjectId: " + SubjectId + " /  SubjectName: " + SubjectName;
            }
        
    }
}
