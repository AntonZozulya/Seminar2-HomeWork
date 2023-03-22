// Семинар 2, работа с преподователем


// ЗАДАЧА № Демонстрация решения: Напишите программу, которая выводит случайное 
//число из отрезка [10, 99] (100) и показывает наибольшую цифру числа

// Console.Clear();
// int n = new Random().Next(10, 100); // [10, 99]
// Console.WriteLine($"Случайное сгенерированное число {n}");
// int n1 = n / 10;
// int n2 =  n % 10; // остаток при деление на 10 = %
// if ( n1 > n2)
//     Console.WriteLine(n1);
// else
//     Console.WriteLine(n2);


// ЗАДАЧА №11: Напишите программу, которая выводит случайное 
//трехзначное число и удаляет вторую цифру этого числа

// Console.Clear();
// int n = new Random().Next(100, 1000); // [100, 999]
// Console.WriteLine($"Случайное сгенерированное число {n}");
// int n1 = n / 100;
// int n3 = n % 10;
// Console.WriteLine(n1 * 10 + n3);



// ЗАДАЧА №12: Напишите программу, которая принемает 2 числа, и показывает, 
// является ли второе чисор кратное первому, если число 2 не кратно числу 1, 
// то программа выводит остаток от деления

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// if (n % m == 0)
//     Console.WriteLine("кратно");
// else
//     Console.WriteLine($"не кратно, остаток {n % m}");


// ЗАДАЧА №13: Напишите программу, которая принемает число, 
// и проверяет, кратно ли оно одновременно 7 и 23

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n % 161 == 0) // 
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");


// ЗАДАЧА №13(2): Напишите программу, которая принемает число, 
// и проверяет, кратно ли оно одновременно 7 и 23

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n % 7 == 0 && n % 23 == 0)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");



// ЗАДАЧА №16: Напишите программу, которая принемает 2 числа, 
// и проверяет, является ли одной число квадратом другого

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// if (n * n == m || m * m == n ) // или так if (n * n == m ) 
//     Console.WriteLine("Является квадратом");
// else
//     Console.WriteLine("Не является квадратом");