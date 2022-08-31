//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

    Console.WriteLine("введите число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int i = 1;
    if (N <=0)
    {
        Console.Write("введите число больше 0");
    }
    else while ( i <= N)
    {
        Console.WriteLine(Math.Pow(i,3));
        i++;
    }
    