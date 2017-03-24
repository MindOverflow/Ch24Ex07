using System.Threading.Tasks;
using static System.Console;

namespace Ch24Ex07
{
    internal static class Program
    {
        private static bool MyTask()
        {
            return true;
        }

        private static int SumIt(object v)
        {
            var x = (int) v;
            var sum = 0;
            for (; x > 0; x--)
            {
                sum = sum + x;
            }
            return sum;
        }

        private static void Main()
        {
            WriteLine("Основной поток выполнения запущен.");

            var task01 = Task<bool>.Factory.StartNew(MyTask);
            WriteLine($"Результат после выполнения задачи MyTask: {task01.Result}");

            var task02 = Task<int>.Factory.StartNew(SumIt, 3);
            WriteLine($"Результат после выполнения задачи SumIt {task02.Result}");

            WriteLine("Основной поток выполнения завершён.");
        }
    }
}
