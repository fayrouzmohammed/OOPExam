using System.Diagnostics;


namespace OOPExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(25, "OOP");
            subject.CreateExam();

            Console.WriteLine("start the exam ? y/n");
            if (char.Parse(Console.ReadLine()) == 'y')
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                subject.exam.ShowExam();
                Console.WriteLine("The Elapsed Time " + stopwatch.Elapsed);
               
    
            }
        }
    }
}
