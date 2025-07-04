namespace UsingOCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var quiz = new Quiz(QuestionBank.Generate());

            quiz.Print();
        }
    }
}