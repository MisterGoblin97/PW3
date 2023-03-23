namespace PW3._4
{
    class MyIntList
    { 
        private List<int> numberList = new List<int>();

        public double Average {
            get { return CalculateAverage(); }
        }

        //новый геттер для вывода максимального числа
        public double Max {
            get { return CalculateMax(); }
        }

        //новый геттер для вывода минимального числа
        public double Min {
            get { return CalculateMin(); }
        }

        public void AddNumber(int number) 
        { 
            numberList.Add(number);
        }

        public void RemoveNumber(int number) 
        { 
            numberList.Remove(number);  
        }

        private double CalculateAverage()
        {
            int sum = 0;

            foreach (int number in numberList) { 
                sum += number;
            }

            return sum/(double)numberList.Count;
        }

        //Добавленная функция возвращающая максимальное число из списка
        private double CalculateMax() { 
            double max = numberList.Max();
            return max;
        }

        //Добавленная функция возвращающая минимальное число из списка
        private double CalculateMin()
        {
            double min = numberList.Min();
            return min;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyIntList numbers = new MyIntList();

            numbers.AddNumber (1);
            numbers.AddNumber (5);
            numbers.AddNumber (9);
            numbers.AddNumber (300);
            numbers.AddNumber (52);

            Console.WriteLine($"Минимальное число из списка: {numbers.Min}" );
            Console.WriteLine($"Максимальное число из списка: {numbers.Max}");
            Console.WriteLine( $"Среднее число списка равно: {numbers.Average}");
        }
    }
}