//1. Написать метод, возвращающий минимальное из трех чисел.

//    Выполнил: Ивницкий Дмитрий Николаевич




using System;




    class Program
    {
        static void Main()
        {
        View view = new View();
        ReturnMin(view);

        view.Pause();



        }

    public static void ReturnMin(View view)
    {
        double min = 0;

        double firstNumber = view.GetInt("Введите первое число");
        
        double secondNumber = view.GetInt("Введите второе число");

        double thirdNumber = view.GetInt("Введите третье число");

        if(firstNumber<secondNumber && firstNumber<thirdNumber)
        {
            min = firstNumber;
            view.Print($"Минимальное число = {min} ") ;
        }
        else
            if(secondNumber<firstNumber && secondNumber<thirdNumber)
        {
            min = secondNumber;
            view.Print($"Минимальное число = {min} ");
        }
        else
        {
            min = thirdNumber;
            view.Print($"Минимальное число = {min} ");
        }

        
        

    }
    }

