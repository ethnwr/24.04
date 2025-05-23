using System;

public class Program()
{
    // Задание 1
    static void Program1()
    {
        int a, b, c, quantity, remains;
        Console.WriteLine("Введите первую сторону прямоугольника: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите вторую сторону прямоугольника: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите сторону квадрата: ");
        c = Convert.ToInt32(Console.ReadLine());

        quantity = a * b / (c * c);
        remains = (a * b) - quantity * (c * c);

        if (c <= b &&  c <= a)
        {
            Console.WriteLine($"Количество квадратов, которое можно разместить в прямоугольнике: {quantity}");
            if (remains != 0)
            {
                Console.WriteLine($"Площадь незанятой части прямоугольника: {remains}");
            }
        }
        else
        {
            Console.WriteLine("В прямоугольнике нельзя разместить ни одного квадрата!");
        }
    }

    // Задание 2
    static void Program2()
    {
        int P;
        int k = 0;
        int s = 10000;
        do
        {
            Console.WriteLine("Введите процент: ");
            P = Convert.ToInt32(Console.ReadLine());
        } while (P < 0 | P > 25);

        while (s < 11000)
        {
            s += s / 100 * P;
            k++;
        }

        Console.WriteLine(s);
        Console.WriteLine(k);
    }

    // Задание 3
    static void Program3()
    {
        int a = 3, b = 7, c = 0;
        Console.WriteLine();
        if (a < b)
        {
            for (int i = a; i <= b; i++)
            {
                while (c != i)
                {
                    c++;
                    Console.Write(i);

                }
                Console.WriteLine();
                c = 0;
            }
        }
    }

    // 4 Задание
    static void Program4()
    {
        int n;
        Console.WriteLine("Введите N: ");
        n = Convert.ToInt32(Console.ReadLine());
        if (n > 0)
        {
            string s = n.ToString();
            char[] ar = s.ToCharArray();
            Array.Reverse(ar);
            s = new String(ar);
            n = Convert.ToInt32(s);
            Console.WriteLine(n);
        }
        else
        {
            Console.WriteLine("Вы ввели число меньше или равное нулю!");
        }
    }
    static void Main()
    {
        Program1 ();
        Program2 ();
        Program3 ();
        Program4 ();
    }
}
