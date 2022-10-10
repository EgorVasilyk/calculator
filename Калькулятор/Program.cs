namespace Калькулятор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВЫберите действие из списка: "
               + "1)сложение "
               + "2)вычитание "
               + "3)умножение "
               + "4)деление "
               + "5)возведение в степень "
               + "6)квадратный корень "
               + "7)1% от числа "
               + "8)факториал из числа "
               + "9)выйти");
            string input;

            input = Console.ReadLine();

            float a = Convert.ToInt32(input);
            while (a != 9)
            {
                if (a == 1)
                {
                    Console.WriteLine("Введите первое число: ");
                    string input1 = Console.ReadLine();
                    Console.WriteLine("Введите второе число: ");
                    string input2 = Console.ReadLine();

                    float b = Convert.ToInt32(input1);
                    float c = Convert.ToInt32(input2);

                    Console.WriteLine("Результат: " + (b + c));
                }

                if (a == 2)
                {
                    Console.WriteLine("Введите первое число: ");
                    string input1 = Console.ReadLine();
                    Console.WriteLine("Введите второе число: ");
                    string input2 = Console.ReadLine();

                    float b = Convert.ToInt32(input1);
                    float c = Convert.ToInt32(input2);

                    Console.WriteLine("Результат: " + (b - c));
                }

                if (a == 3)
                {
                    Console.WriteLine("Введите первое число: ");
                    string input1 = Console.ReadLine();
                    Console.WriteLine("Введите второе число: ");
                    string input2 = Console.ReadLine();

                    float b = Convert.ToInt32(input1);
                    float c = Convert.ToInt32(input2);

                    Console.WriteLine("Результат: " + (b * c));
                }

                if (a == 4)
                {
                    Console.WriteLine("Введите первое число: ");
                    string input1 = Console.ReadLine();
                    Console.WriteLine("Введите второе число: ");
                    string input2 = Console.ReadLine();

                    float b = Convert.ToInt32(input1);
                    float c = Convert.ToInt32(input2);

                    Console.WriteLine("Результат: " + (b / c));
                }

                if (a == 5)
                {
                    Console.WriteLine("Введите первое число: ");
                    string input1 = Console.ReadLine();
                    Console.WriteLine("Введите второе число: ");
                    string input2 = Console.ReadLine();

                    int b = Convert.ToInt32(input1);
                    int N = Convert.ToInt32(input2);

                    Console.WriteLine("Результат: " + (Math.Pow(b, N)));
                }

                if (a == 6)
                {
                    Console.WriteLine("Введите число: ");
                    string input1 = Console.ReadLine();

                    float b = Convert.ToInt32(input1);

                    Console.WriteLine("Результат: " + (Math.Sqrt(b)));
                }

                if (a == 7)
                {
                    Console.WriteLine("Введите число: ");
                    string input1 = Console.ReadLine();

                    float b = Convert.ToInt32(input1);

                    Console.WriteLine("Результат: " + (b / 100 + "%"));
                }

                if (a == 8)
                {
                    Console.WriteLine("Введите число: ");
                    string input1 = Console.ReadLine();

                    float x = Convert.ToInt32(input1);

                    float n = 1;
                    float fact = 1;
                    while (n < x)
                    {
                        n = n + 1;
                        fact = fact * n;
                    }
                    Console.WriteLine("Факториал числа равен: " + fact);


                }

                if (a == 9)
                {
                    Console.WriteLine("Выход");
                    break;
                }
                Console.WriteLine("ВЫберите действие из списка: "
               + "1)сложение "
               + "2)вычитание "
               + "3)умножение "
               + "4)деление "
               + "5)возведение в степень "
               + "6)квадратный корень "
               + "7)1% от числа "
               + "8)факториал из числа "
               + "9)выйти");
                a = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}