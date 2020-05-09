//4. Реализовать метод проверки логина и пароля.На вход подается логин и пароль.
//  На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
//  Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
//  С помощью цикла do while ограничить ввод пароля тремя попытками.
    
//    Выполнил: Ивницкий Дмитрий Николаевич





using System;




class Program
{
    static void Main()

    {
        View view = new View();
        LoginNPassword(view);
        

        view.Pause();

    }

    public static void LoginNPassword(View view)
    {
        string login = "root";
        string password = "GeekBrains";
        int count = 0;


        do
        {
            view.Print("Введите логин : ");
            string l = view.GetString();

            view.Print("Введите пароль : ");
            string p = view.GetString();

            if (l != login && p != password)
            {
                view.Print("Не верный пароль/логин");
                count++;

            }
            else
            {
                view.Print("Пользователь авторизирован!");
                break;
            }
        } while (count < 3);

    }
    
    
    }



