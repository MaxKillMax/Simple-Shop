using System;
using System.Collections.Generic;
// Весь интерфейс
namespace Storage
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop;
            shop = new Shop();
            Operations operations = new Operations();
            operations.MainMenu();
        }
    }

    class Operations : UserDatabase
    {
        string Answer;
        Shop shop;

        // Ссылка сюда открывает главное меню
        internal void MainMenu()
        {
            shop = new Shop();
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("   ГЛАВНОЕ МЕНЮ");
            Console.WriteLine("Выберите действие и напишите его цифру:");
            Console.WriteLine("1. Посмотреть каталог товаров.");
            Console.WriteLine("2. Посмотреть свой профиль.");
            Console.WriteLine("3. Выйти из магазина.");
            Answer = Console.ReadLine();

            switch (Answer)
            {
                case "1": Shop();
                    break;
                case "2": if (!base.Active) Login();
                    else Profile();
                    break;
                case "3":
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("Введено неправильное значение");
                    MainMenu();
                    break;
            }
        }

        // Ссылка сюда от главного меню открывает меню логина
        internal void Login()
        {
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Если у вас есть аккаунт, введите его логин");
            Console.WriteLine("Чтобы выйти в главное меню, введите меню/menu");
            Answer = Console.ReadLine();

            switch (Answer)
            {
                case "меню": MainMenu();
                    break;
                case "menu": MainMenu();
                    break;
                default:

                    if (base.Name != Answer)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Несуществующее имя");
                        MainMenu();
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Введите пароль");
                        Answer = Console.ReadLine();

                        if (base.Pass != Answer)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Неправильный логин или пароль");
                            MainMenu();
                        }
                        else
                        {
                            base.Active = true;
                            Profile();
                        }
                    }
                    break;
            }
        }

        // Ссылка сюда после процесса логина или регистрации
        internal void Profile()
        {
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("У нас проходит акция: если вы потратите больше 1000 рублей, то вы получите скидку 50% на презервативы.");
            Console.WriteLine($"{base.Name}:");
            Console.WriteLine($"Текущий баланс: {base.Balance}");
            Console.WriteLine("Введите 1, чтобы выйти из аккаунта");
            Console.WriteLine("Введите 2, чтобы перейти в главное меню");
            Answer = Console.ReadLine();

            switch (Answer)
            {
                case "1":
                    base.Active = false;
                    MainMenu();
                    break;
                case "2":
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("Такого варианта ответа нет. Вы автоматически перешли в меню");
                    Console.WriteLine("");
                    break;
            }

        }

        // Ссылка сюда от главного меню открывает меню разных категорий товаров
        internal void Shop()
        {
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Выберите действие и напишите его цифру:");
            Console.WriteLine("1. Презервативы"); 
            Console.WriteLine("2. Лубриканты");
            Console.WriteLine("3. Одежда");
            Answer = Console.ReadLine();

            switch (Answer)
            {
                case "1": Condoms();
                    break;
                case "2": Lubricants();
                    break;
                case "3": Сlothes();
                    break;
                default:
                    Console.WriteLine("Введено неправильное значение");
                    Shop();
                    break;
            }
        }

        // Ссылка сюда от категорий
        internal void Condoms()
        {
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Выберите действие и напишите его цифру:");
            Console.WriteLine("1. Просмотреть описание ");
            shop.Products[0].GetName();
            Console.WriteLine("2. Просмотреть описание ");
            shop.Products[1].GetName();
            Console.WriteLine("3. Выйти в главное меню.");
            Answer = Console.ReadLine();

            switch (Answer)
            {
                case "1":
                    shop.Products[0].Info();
                    CompleteBuy(0);
                    break;
                case "2":
                    shop.Products[1].Info();
                    CompleteBuy(1);
                    break;
                case "3": MainMenu();
                    break;
                default: Condoms();
                    break;
            }
        }

        // Ссылка сюда от категорий
        internal void Lubricants()
        {
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Выберите действие и напишите его цифру:");
            Console.WriteLine("1. Просмотреть описание ");
            shop.Products[2].GetName();
            Console.WriteLine("2. Просмотреть описание ");
            shop.Products[3].GetName();
            Console.WriteLine("3. Выйти в главное меню.");
            Answer = Console.ReadLine();

            switch (Answer)
            {
                case "1":
                    shop.Products[2].Info();
                    CompleteBuy(2);
                    break;
                case "2":
                    shop.Products[3].Info();
                    CompleteBuy(3);
                    break;
                case "3":
                    MainMenu();
                    break;
                default:
                    Condoms();
                    break;
            }
        }

        // Ссылка сюда от категорий
        internal void Сlothes()
        {
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Выберите действие и напишите его цифру:");
            Console.WriteLine("1. Просмотреть описание ");
            shop.Products[4].GetName();
            Console.WriteLine("2. Просмотреть описание ");
            shop.Products[5].GetName();
            Console.WriteLine("3. Выйти в главное меню.");
            Answer = Console.ReadLine();

            switch (Answer)
            {
                case "1":
                    shop.Products[4].Info();
                    CompleteBuy(4);
                    break;
                case "2":
                    shop.Products[5].Info();
                    CompleteBuy(5);
                    break;
                case "3":
                    MainMenu();
                    break;
                default:
                    Condoms();
                    break;
            }
        }

        // Ссылка сюда для подтверждения покупки
        internal void CompleteBuy(int Index)
        {
            Console.WriteLine("");
            Console.WriteLine("Выберите действие и напишите его цифру:");
            Console.WriteLine("1. Приобрести товар");
            shop.Products[Index].GetName();
            Console.WriteLine("2. Выйти в главное меню.");
            Answer = Console.ReadLine();

            switch (Answer)
            {
                case "1":
                    if (!base.Active)
                    {
                        Console.WriteLine("Нужно авторизироваться, чтобы совершать покупки.");
                    }
                    else
                    {
                        var Money = shop.Products[Index].SpentMoney();
                        if (base.Spent >= 1000 && shop.Products[Index] is Condom)
                        {
                            base.Balance -= (int)Money / 2;
                            base.Spent += (int)Money / 2;
                            Console.WriteLine("-----------------------------------------------------------------");
                            Console.WriteLine("Покупка успешно произведена.");
                            break;
                        }

                        if (base.Balance >= Money)
                        {
                            base.Balance -= (int)Money;
                            base.Spent += (int)Money;
                            Console.WriteLine("-----------------------------------------------------------------");
                            Console.WriteLine("Покупка успешно произведена.");
                        }
                        else Console.WriteLine("Недостаточно средств или товар закончился");
                    }
                    break;
            }
            MainMenu();
        }
    }
}
