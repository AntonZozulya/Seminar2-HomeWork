Console.Clear();
Console.Write("Введите 3-х значное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int a1 = a / 10;
int a2 = a1 % 10;
Console.WriteLine(a2);