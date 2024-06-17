// 1
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите температуру в Цельсиях: ");
//        string input = Console.ReadLine();
//
//        if (double.TryParse(input, out double celsius))
//        {
//            double fahrenheit = CelsiusToFahrenheit(celsius);
//            Console.WriteLine($"Температура в Фаренгейтах: {fahrenheit:F2}");
//        }
//        else
//        {
//            Console.WriteLine("Неверный ввод. Пожалуйста, введите числовое значение.");
//        }
//    }
//
//    static double CelsiusToFahrenheit(double celsius)
//    {
//        return (celsius * 9 / 5) + 32;
//    }
//}

//2
//using System;
//
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите радиус шара: ");
//        string input = Console.ReadLine();
//
//        if (double.TryParse(input, out double radius) && radius > 0)
//        {
//            double volume = CalculateSphereVolume(radius);
//            Console.WriteLine($"Объем шара: {volume:F2} куб. единиц");
//        }
//        else
//        {
//            Console.WriteLine("Неверный ввод. Пожалуйста, введите положительное числовое значение.");
//        }
//    }
//
//    static double CalculateSphereVolume(double radius)
//    {
//        return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
//    }
//}

//3
//using System;
//
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите стоимость одного ноутбука: ");
//        string inputPrice = Console.ReadLine();
//
//        Console.Write("Введите количество ноутбуков: ");
//        string inputQuantity = Console.ReadLine();
//
//        Console.Write("Введите процент скидки: ");
//        string inputDiscount = Console.ReadLine();
//
//        if (double.TryParse(inputPrice, out double price) &&
//            int.TryParse(inputQuantity, out int quantity) &&
//            double.TryParse(inputDiscount, out double discount))
//        {
//            double totalCost = CalculateTotalCost(price, quantity, discount);
//            Console.WriteLine($"Общая сумма заказа с учетом скидки: {totalCost:F2} единиц");
//        }
//        else
//        {
//            Console.WriteLine("Неверный ввод. Пожалуйста, введите корректные числовые значения.");
//        }
//    }
//
//    static double CalculateTotalCost(double price, int quantity, double discount)
//    {
//        double totalPrice = price * quantity;
//        double discountAmount = totalPrice * (discount / 100);
//        return totalPrice - discountAmount;
//    }
//}

//4
//using System;
//
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите длину окружности: ");
//        string inputLength = Console.ReadLine();
//
//        if (double.TryParse(inputLength, out double length) && length > 0)
//        {
//            double radius = CalculateRadius(length);
//            double area = CalculateCircleArea(radius);
//            Console.WriteLine($"Площадь круга: {area:F2} квадратных единиц");
//        }
//        else
//        {
//            Console.WriteLine("Неверный ввод. Пожалуйста, введите положительное числовое значение.");
//        }
//    }
//
//    static double CalculateRadius(double length)
//    {
//        const double pi = 3.14;
//        return length / (2 * pi);
//    }
//
//    static double CalculateCircleArea(double radius)
//    {
//        const double pi = 3.14;
//        return pi * radius * radius;
//    }
//}

//6
//using System;
//
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите количество дней: ");
//        string inputDays = Console.ReadLine();
//
//        if (int.TryParse(inputDays, out int days) && days >= 0)
//        {
//            int weeks = days / 7;
//            int remainingDays = days % 7;
//            Console.WriteLine($"{days} дней это {weeks} недель и {remainingDays} дней.");
//        }
//        else
//        {
//            Console.WriteLine("Неверный ввод. Пожалуйста, введите неотрицательное целое число.");
//        }
//    }
//}

//7
//using System;
//
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите количество школьников: ");
//        string inputN = Console.ReadLine();
//
//        Console.Write("Введите количество яблок: ");
//        string inputK = Console.ReadLine();
//
//        if (int.TryParse(inputN, out int N) && N > 0 && int.TryParse(inputK, out int K) && K >= 0)
//        {
//            int applesPerStudent = K / N;
//            int applesRemaining = K % N;
//
//            Console.WriteLine($"Каждому школьнику достанется {applesPerStudent} яблок(а).");
//            Console.WriteLine($"В корзине останется {applesRemaining} яблок(а).");
//        }
//        else
//        {
//            Console.WriteLine("Неверный ввод. Пожалуйста, введите положительное целое число для количества школьников и неотрицательное целое число для количества яблок.");
//        }
//    }
//}