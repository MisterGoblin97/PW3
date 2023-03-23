using System.Text;

namespace PW3._6
{
    class StupidProgram
    {  
        //доделать!!!!!!!
        public static string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                //Генерируем число являющееся латинским символом в юникоде
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                //Конструируем строку со случайно сгенерированными символами
                builder.Append(ch);
            }
            return builder.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            StupidProgram RandomString = new StupidProgram();
            Console.WriteLine("RandomString(5): {0}", RandomString(5));
        }
    }
}