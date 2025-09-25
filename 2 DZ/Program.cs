using System;
using System.Xml.Linq;

namespace MyApp
{
    internal class Program
    {
        enum DataTypes //#1
        {
            Byte,
            SByte,
            Short,
            UsShort,
            Int,
            UInt,
            Long,
            ULong,
            Float,
            Double,
            Decimal,
            Bool,
            Char
        }
        struct Person //#2
        {
            public string name;
            public string city;
            public int yearOfBirth;
            public int pinCode;

            public void Print()
            {
                Console.WriteLine($"Персонаж по имени {name} , из города - {city}, возраст - {yearOfBirth}л {pinCode}");
            }

        }
        enum BottlesShop //#5
        {
            Empty,
            Savings

        }
        struct Shop //#5
        {
            public int NormPrice;
            public int SalePercent;
            public int HolidayPrice;
            public int BottlesNeeded;
            public Shop(int normPrice, int salePercent, int holidayPrice) // заполнение полей с начальными значениями 
            {
                NormPrice = normPrice;
                SalePercent = salePercent;
                HolidayPrice = holidayPrice;
                BottlesNeeded = 0;
            }
            public BottlesShop Calculate() //функция, которая выполняет вычисления и возвращает результат в виде значения перечисления 
            {
                double bottle = NormPrice * (SalePercent / 100.0); // ищём колво бутылок 
                if (bottle <= 0)
                {
                    return BottlesShop.Empty;
                }
                BottlesNeeded = (int)(HolidayPrice / bottle);
                return BottlesShop.Savings;
            }

            struct Drink // №6   напитки 
            {
                public string Name;
                public double AlcoholPercentage;
                public Drink(string name, double alcohol)
                {
                    Name = name;
                    AlcoholPercentage = alcohol;
                }
            }
            struct Student //#6 студент
            {
                public string LastName;
                public string FirstName;
                public int Id;
                public DateTime BirthDate; //хранит дату и время 
                public char AlcoholCategory; // a, b, c, d
                public double DrinkVolume;
                public Drink FavoriteDrink;

                public Student(string lastName, string firstName, int id, DateTime birthDate, char alcoholCategory, double drinkVolume, Drink favoriteDrink)
                {
                    LastName = lastName;
                    FirstName = firstName;
                    Id = id;
                    BirthDate = birthDate;
                    AlcoholCategory = alcoholCategory;
                    DrinkVolume = drinkVolume;
                    FavoriteDrink = favoriteDrink;
                }

                static void Main(string[] args)
                {   //#1
                    Console.WriteLine("#1");
                    DataTypes bytee = DataTypes.Byte;
                    DataTypes sbytee = DataTypes.SByte;
                    DataTypes shortt = DataTypes.Short;
                    DataTypes usshortt = DataTypes.UsShort;
                    DataTypes intt = DataTypes.Int;
                    DataTypes uintt = DataTypes.UInt;
                    DataTypes longg = DataTypes.Long;
                    DataTypes floatt = DataTypes.Float;
                    DataTypes doublee = DataTypes.Double;
                    DataTypes decimall = DataTypes.Decimal;
                    Console.WriteLine($"{bytee}: максимальное значение – {byte.MaxValue}, минимальное значение - {byte.MinValue}" + "\n" + $"{sbytee}: максимальное значение – {sbyte.MaxValue}, минимальное значение - {sbyte.MinValue}" + "\n" + $"{shortt}: максимальное значение – {short.MaxValue}, минимальное значение - {short.MinValue}" + "\n" + $"{usshortt}: максимальное значение – {ushort.MaxValue}, минимальное значение - {ushort.MinValue}");
                    Console.WriteLine($"{intt}: максимальное значение – {int.MaxValue}, минимальное значение - {int.MinValue}" + "\n" + $"{uintt}: максимальное значение – {uint.MaxValue}, минимальное значение - {uint.MinValue}" + "\n" + $"{longg}: максимальное значение – {long.MaxValue}, минимальное значение - {long.MinValue}" + "\n" + $"{floatt}: максимальное значение – {float.MaxValue}, минимальное значение - {float.MinValue}");
                    Console.WriteLine($"{doublee}: максимальное значение – {double.MaxValue}, минимальное значение - {double.MinValue}" + "\n" + $"{decimall}: максимальное значение – {decimal.MaxValue}, минимальное значение - {decimal.MinValue}" + "\n");

                    //#2
                    Console.WriteLine("#2");
                    Person person = new Person();
                    person.name = "Петя";
                    person.city = "Казань";
                    int age = 2005;
                    person.yearOfBirth = 2025 - age;
                    person.pinCode = 1234;
                    person.Print();

                    //#3
                    Console.WriteLine("#3");
                    Console.WriteLine("Строка:");
                    string str = Console.ReadLine();
                    string up = str.ToUpper(); //преобразования строки в верхний регистр
                    string lower = str.ToLower(); // в нижний регистр 
                    for (int l = 0; l < str.Length; l++)
                    {
                        if (str[l] == up[l])
                        {
                            Console.Write(lower[l]);
                        }
                        else { Console.Write(up[l]); }
                    }
                    Console.WriteLine();
                    //#4
                    Console.WriteLine("#4");
                    Console.WriteLine("Строка:");
                    str = Console.ReadLine();
                    Console.WriteLine("Подстрока:");
                    string subString = Console.ReadLine();
                    int k = 0;
                    for (int i = 0; i <= str.Length - subString.Length; i++)
                    {
                        if (str.Substring(i, subString.Length) == subString) //  получение длины строки ( количества символов в ней)
                        {
                            k++; // Сначала возвращает текущее значение переменной k, а затем увеличивает его на 1
                        }
                    }
                    Console.WriteLine(k);

                    //#5
                    Console.WriteLine("#5");
                    Console.WriteLine("Цена бутылки:");
                    int normPrice = int.Parse(Console.ReadLine());
                    Console.Write("Скидка в процентах:");
                    int salePercent = int.Parse(Console.ReadLine());
                    Console.Write("Стоимость отпуска:");
                    int holidayPrice = int.Parse(Console.ReadLine());

                    Shop prices = new Shop(normPrice, salePercent, holidayPrice);

                    BottlesShop status = prices.Calculate();

                    if (status == BottlesShop.Empty)
                    {
                        Console.WriteLine($"Нужно следующее количество бутылок: {prices.BottlesNeeded} ");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }

                    //#6
                    Console.WriteLine("#6");
                    Drink vodka = new Drink("Vodka", 40);
                    Drink beer = new Drink("Beer", 5);
                    Drink wine = new Drink("Wine", 12);
                    Student[] students = new Student[5]; // колво студентов 
                    students[0] = new Student("Иванов", "Иван", 1, new DateTime(2007, 1, 1), 'a', 3.0, vodka);
                    students[1] = new Student("Петров", "Петр", 2, new DateTime(2006, 2, 2), 'b', 4.5, beer);
                    students[2] = new Student("Зарипов", "Закир", 3, new DateTime(2007, 3, 3), 'c', 1.75, wine);
                    students[3] = new Student("Кузнецов", "Кузя", 4, new DateTime(2005, 4, 4), 'd', 1.0, vodka);
                    students[4] = new Student("Смирнов", "Никита", 5, new DateTime(2007, 5, 5), 'b', 3.0, wine);
                    double volume = 0;
                    double totalVolume = 0;
                    foreach (var student in students) // цикл для перебора элементов массива
                    {
                        volume += student.DrinkVolume;
                        totalVolume += student.DrinkVolume * (student.FavoriteDrink.AlcoholPercentage / 100);
                    }
                    Console.WriteLine($"Общий объем выпитой жидкости: {volume}");
                    Console.WriteLine($"Общий объем алкоголя: {totalVolume}");

                    foreach (var student in students)
                    {
                        double studentAlcoholVolume = student.DrinkVolume * (student.FavoriteDrink.AlcoholPercentage / 100);
                        double alcoholPercentageOfTotal = (studentAlcoholVolume / totalVolume) * 100;
                        double liquidPercentageOfTotal = (student.DrinkVolume / totalVolume) * 100;

                        Console.WriteLine($"{student.FirstName} {student.LastName}:");
                        Console.WriteLine($"Алкоголь: {studentAlcoholVolume}л {alcoholPercentageOfTotal}% от общего алкоголя");
                        Console.WriteLine($"л {student.DrinkVolume}л {liquidPercentageOfTotal}% от общего объема");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}