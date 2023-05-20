namespace SkillFactory_Module_9._6
{

    class MyException : Exception
    {
        public MyException(string message) : base(message)
        {
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception[] exceptions = new Exception[]
             {
                new ArgumentException(),
                new DivideByZeroException(),
                new IndexOutOfRangeException(),
                new FormatException(),
                new IOException(),
                new MyException("Моё исключение")
             };

            foreach (Exception exeption in exceptions)
            {
                try
                {
                    throw exeption;
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            Console.ReadKey();
        }
    }
}