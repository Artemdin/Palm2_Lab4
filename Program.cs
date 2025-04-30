using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int choice;
        do
        {
            Console.WriteLine("Виберіть який блок необхідно виконати: ");
            Console.WriteLine("Для виконання блоку 1, введiть цифру 1");
            Console.WriteLine("Для виконання блоку 2, введiть цифру 2");
            Console.WriteLine("Для виходу з програми введiть 0");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Виконую блок 1");
                   DoBlock_1();
                    break;
                case 2:
                    Console.WriteLine("Виконую блок 2");
                   DoBlock_2();
                    break;
                case 0:
                    Console.WriteLine("Зараз завершимо, тільки натисніть будь ласка ще раз Enter");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Команда '{0}' не розпізнана. Зробіь, будь ласка, вибір із 1, 2, 3, 4, 0.", choice);
                    break;
            }


        } while (choice != 0);

    }
    static void DoBlock_1()
    {
       

        int choice;
        do
        {
          
            Console.WriteLine("\nВиберіть завдання,яке буде виконуватись: ");
            Console.WriteLine("Завдання 1: з використанням лише типу string, та додаванням чисел 1, 2, 3, ...," +
               " n у кінець за\nдопомогою оператора += типу string.");
            Console.WriteLine("\nЗавдання 2: з використанням лише типу string, та додаванням чисел n, n–1, ..., 3, 2, 1 (саме в цьому" +
                "\nпорядку) в початок за допомогою оператора + типу string.");
            Console.WriteLine("\nЗавдання 3: з використанням як string, так і StringBuilder, та додаванням чисел 1, 2, 3, ...,\nn у" +
          "кінець за допомогою метода Append. ");
            Console.WriteLine("\nЗавдання 4: з використанням як string, так і StringBuilder, та додаванням чисел \nn, n–1, ..., 3, 2," +
                "1 (саме в цьому порядку) в початок за допомогою метода Insert.");
            Console.WriteLine("Вкажіть число: ");
            Console.WriteLine("Щоб повернутися в меню,введіть число 0.");
            choice = int.Parse(Console.ReadLine());
           
            Console.WriteLine("\nВведіть число натуральне(строго додатнє) за яким буде сформований рядок! ");
            int n = Math.Abs(int.Parse(Console.ReadLine()));
          
            if (n == 0)
            {
                Console.WriteLine("Не правильно введено число");
                break;
            }
               

            Stopwatch sw = Stopwatch.StartNew();
            sw.Stop();
            switch (choice)
            {
                case 1:
                    sw.Restart();
                    Console.WriteLine("Виконую завдання 1");
                    Task1_1(n);
                    sw.Stop();
                    break;
                case 2:
                    sw.Restart();
                    Console.WriteLine("Виконую завдання 2");
                    Task1_2(n);
                    sw.Stop();
                    break;
                case 3:
                    sw.Restart();
                    Console.WriteLine("Виконую завдання 3");
                   Task1_3(n);
                    sw.Stop();
                    break;
                case 4:
                    sw.Restart();
                    Console.WriteLine("Виконую завдання 4");
                   Task1_4(n);
                    sw.Stop();
                    break;
                case 0:
                    Console.WriteLine("Повертаємося в меню.");
                    break;
                default:
                    Console.WriteLine("Команда '{0}' не розпізнана. Зробіь, будь ласка, вибір із 1, 2, 3, 4, 0.", choice);
                    break;
            }

            Console.WriteLine($"Час виконання: {sw} мс");
            Console.WriteLine("____________________________________________________________________________________________________________________");
        } while (choice != 0);





    }

    static void Task1_1(int n)
    {

        string result = "";

        for (int i = 1; i <= n; i++)
        {
            result += i + " ";
        }

        Console.WriteLine($"Результат: \n{result}");
    }
    static void Task1_2(int n)
    {

        string result = "";

        for (int i = n; i >=   1; i--)
        {
            result = i + " "+result;
        }

        Console.WriteLine($"Результат: \n{result}");
    }
    static void Task1_3(int n)
    {

        StringBuilder str = new StringBuilder();

        for (int i = 1; i <= n; i++)
        {
            str.Append($" {i}");
        }

        string result = str.ToString();
        Console.WriteLine(result);
    }
    static void Task1_4(int n)
    {

        StringBuilder str = new StringBuilder();
        for (int i = n; i >= 1; i--)
        {
            str.Insert(0, i + " ");
        }
    

        string result = str.ToString();
        Console.WriteLine(result);
    }

    static void DoBlock_2()
    {

        int choice;
        do
        {




            Console.WriteLine("\nЗавдання: Прочитати з клавіатури один рядок символів. Скопіювати його, взаємно замінивши при цьому літери" +
                "\n'R', 'S', 'T' на 'K', 'L', 'M', відповідно, і навпаки. ");
            Console.WriteLine("\nВиберіть яким способом хочете виконати завдання: ");
            Console.WriteLine("Щоб виконати завдання використовуючи тільки string,введіть: 1.");
            Console.WriteLine("Щоб виконати завдання використовуючи StringBuilder,введіть: 2.");
            Console.WriteLine("Щоб повернутися в меню,введіть число 0.");
            choice = int.Parse(Console.ReadLine());

            Stopwatch sw = Stopwatch.StartNew();
            sw.Stop();
            switch (choice)
            {
                case 1:
                    
                    Console.WriteLine("Виконую завдання 1");
                    Console.WriteLine("Введіть літери!");
                    string input = Console.ReadLine();
                    sw.Restart();
                    Task2_1(input);
                    sw.Stop();
                    break;
                case 2:
                    
                    Console.WriteLine("Виконую завдання 2");
                    Console.WriteLine("Введіть літери!");
                    string input1 = Console.ReadLine();
                    sw.Restart();
                    Task2_2(input1);
                    sw.Stop();
                    break;
                case 0:
                    Console.WriteLine("Повертаємося в меню.");
                    break;
                default:
                    Console.WriteLine("Команда '{0}' не розпізнана. Зробіь, будь ласка, вибір із 1, 2, 0.", choice);
                    break;
            }

            Console.WriteLine($"Час виконання: {sw} мс");
            Console.WriteLine("____________________________________________________________________________________________________________________");
        } while (choice != 0);








    }

static void Task2_1(string input)
    {

        string result = "";

        foreach (char c in input)
        {
            if ("RST".Contains(c)) result += (char)(c - 7);
            else if ("KLM".Contains(c)) result += (char)(c + 7);
            else result += c;
        }
        Console.WriteLine("Результат: ");
        Console.WriteLine(result);

    }

    static void Task2_2(string input)
    {

        
       StringBuilder str = new StringBuilder();

        foreach (char c in input)
        {
            if ("RST".Contains(c)) str.Append( (char)(c - 7));
            else if ("KLM".Contains(c)) str.Append((char)(c + 7));
            else str.Append(c);
        }

        Console.WriteLine("Результат: ");
        Console.WriteLine(str.ToString());

    }

}
/*   foreach (char c in input)
        {
            if (c == 'R') result += 'K';
            else if (c == 'S') result += 'L';
            else if (c == 'T') result += 'M';
            else if (c == 'K') result += 'R';
            else if (c == 'L') result += 'S';
            else if (c == 'M') result += 'T';
            else result += c; 
        }*/
/* foreach (char c in input)
        {
            if (c == 'R') str.Append('K');
            else if (c == 'S') str.Append('L');
            else if (c == 'T') str.Append('M');
            else if (c == 'K') str.Append('R');
            else if (c == 'L') str.Append('S');
            else if (c == 'M') str.Append('T');
            else str.Append(c);
        }*/