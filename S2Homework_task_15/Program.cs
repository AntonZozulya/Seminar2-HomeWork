

// ПЕРВЫЙ ВАРИАНТ ПРОГРАММЫ, С СООБЩЕНИЕМ ЧТО ПН,ВТ,СР,ЧТ,ПТ - БУДНИЕ ДНИ

// Console.Write("Введите день недели: ");
//     int n = Convert.ToInt32(Console.ReadLine()!); 
//     while (n < 1 || n > 7) 
//     {
//         Console.Write("Вы ошиблись, \nВведите день недели: "); 
//         n = Convert.ToInt32(Console.ReadLine()!);
//     }
//     if(n == 1)
//         Console.Write("НЕ ВЫХОДНОЙ ДЕНЬ");
//     else if(n == 2) // else if - иначе если
//         Console.Write("НЕ ВЫХОДНОЙ ДЕНЬ");
//     else if(n == 3) // else if - иначе если
//         Console.Write("НЕ ВЫХОДНОЙ ДЕНЬ");
//     else if(n == 4) // else if - иначе если
//         Console.Write("НЕ ВЫХОДНОЙ ДЕНЬ");
//     else if(n == 5) // else if - иначе если
//         Console.Write("НЕ ВЫХОДНОЙ ДЕНЬ");
//     else if(n == 6) // else if - иначе если
//         Console.Write("ВЫХОДНОЙ ДЕНЬ");
//     else
//         Console.Write("ВЫХОДНОЙ ДЕНЬ");



// ВТОРОЙ ВАРИАНТ ПРОГРАММЫ БЕЗ СООБЩЕНИЯ О БУДНЯХ ДНЯХ

Console.Clear();
Console.Write("Введите день недели: ");
    int n = Convert.ToInt32(Console.ReadLine()!); 
    while (n < 6 || n > 7) 
    {
        Console.Write("Вы ошиблись, \nВведите НЕ будний день недели: "); 
        n = Convert.ToInt32(Console.ReadLine()!);
    }
    if(n == 6)
        Console.Write("ВЫХОДНОЙ ДЕНЬ");
    else 
        Console.Write("ВЫХОДНОЙ ДЕНЬ");