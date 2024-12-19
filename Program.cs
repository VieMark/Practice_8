using System; 
namespace Practice
{
    /*Моя первая программа.*/
    class Program
    {
        static void Main()
        {
        // Переменные
        int a = 4, b = 5;
        string slovo = "QWERTYUI";
        int[] massiv = {1, 2, 4, 7, 10, 3};
        int salary = 45000;
        int celsius = 3;
        string vowels = "ВАГОДЬТИцкАжбьясМИ";
        int password = 4519;



        // ПРАКТИКА A
        Console.WriteLine("ПРАКТИКА A");
        int res = Sum(a, b);
        Console.WriteLine($"Задание 1: {res}");

        Console.WriteLine($"Задание 2: {Is_even(5)}");

        Console.WriteLine($"Задание 3: {Flipp(slovo)}");

        Console.WriteLine($"Задание 4: {Find_max(massiv)}");

        Console.WriteLine($"Задание 5: {Salary_year(salary)} руб.");

        // ПРАКТИКА B
        Console.WriteLine("ПРАКТИКА B");
        Console.WriteLine($"Задание 6: {Celsius_to_fahrenheit(celsius)} Фаренгейта");

        Console.WriteLine($"Задание 7: Гласных букв в строке: {Count_vowels(vowels)}");

        Console.WriteLine($"Задание 8: Попыток - {Generate(password)}");



        }

        /* Практика - A */
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static bool Is_even(int number)
        {
            return number%2 == 0;
        }

        static string Flipp(string slovo)
        {
            char[] str = slovo.ToCharArray(); //преобразовывает строку в массив
            Array.Reverse(str); 
            return new String(str);
        }

        static int Find_max(int [] arr)
        {
            return arr.Max();
        }

        static int Salary_year(int salary)
        {
            return salary * 12;
        }



        /* Практика B */

        static int Celsius_to_fahrenheit(int celsius)
        {
            return celsius * 9/5 + 32;
        }

        static int Count_vowels(string S)
        {
            S = S.ToLower();
            char[] C = {'а', 'е', 'ё', 'у', 'ы', 'я', 'и', 'о', 'ю', 'э', 'А', 'Е', 'Ё', 'У', 'Ы', 'Я', 'И', 'О', 'Ю', 'Э'};
            int i = 0;
            foreach (char v in S) 
            { 
                if (C.Contains(v)) 
                { 
                    i++; 
                } 
            }
            return i;
        }

        static int Generate(int password)
        {
            int count = 0;
            string str_password = password.ToString();
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    for (int w = 0; w < 10; w++)
                    {
                        for (int z = 0; z < 10; z++)
                        {
                            string str_x = x.ToString();
                            string str_y = y.ToString();
                            string str_w = w.ToString();
                            string str_z = z.ToString();
                            count++;
                            string generatedpass = str_x + str_y + str_w + str_z;
                            if(generatedpass == str_password)
                            {
                                Console.WriteLine("Ура! Получилось взломать пароль!!! ");
                            }
                        }
                    }
                }
            }
            return count;
        }


    }
}