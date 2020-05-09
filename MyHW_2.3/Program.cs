//2. Написать метод подсчета количества цифр числа.

//    Выполнил : Ивницкий Дмитрий Николаевич







using System;


    class Program
    {
        static void Main()
        {

        View view = new View();
        CountingDigit(view);
        view.Pause();

        }

    public static void CountingDigit(View view)
    {
        int digit = view.GetInt("ВВедите целое число : ");
        int digitCount = (int)Math.Log10(digit) + 1;
        view.Print($"Количество цифр в {digit}  равно {digitCount}");
    }
    }

