namespace Task2
{

    class NumberReader  
    {
        public delegate void NumberEnteredDelegate(int number); 
        public event NumberEnteredDelegate NumberEnteredEvent;  

        public int Read()                       
        {
            Console.WriteLine();
            Console.WriteLine("Введите число 1 или 2");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number != 1 && number != 2) throw new FormatException();

            NumberEntered(number);
            return number;

        }
        protected virtual void NumberEntered(int number) 
        {
            NumberEnteredEvent?.Invoke(number);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lastNames = new string[5];

            NumberReader numberReader = new NumberReader();
            numberReader.NumberEnteredEvent += ShowNumber;

                try
                {
                    int num = numberReader.Read();
                    if (num == 1)
                    {
                        lastNames = SortA_Z();
                        foreach (string s in lastNames)
                            Console.WriteLine(s);
                    }

                    if (num == 2)
                    {
                        lastNames = SortZ_A();
                        foreach (string s in lastNames)
                            Console.WriteLine(s);
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Введено некорректное значение");
                }
            
        }

        public static string[] SortA_Z()
        {
            string[] list = new string[] { "Баранов", "Громов", "Исакин", "Панюхин", "Саламатин" };
            return list;
        }
        public static string[] SortZ_A()
        {
            string[] list = new string[] { "Саламатин", "Панюхин", "Исакин", "Громов", "Баранов" };
            return list;
        }

        static void ShowNumber(int number) 
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("Вы ввели число: 1");

                    break;

                case 2:
                    Console.WriteLine("Вы ввели число: 2");

                    break;

            }
        }
    }
}