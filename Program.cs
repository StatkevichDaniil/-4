// Задача25
// int NumberA = ReadInt("Введите число: ");
// int NumberB = ReadInt("Введите степень: ");
// Console.WriteLine("А в степени В равно: " +ToDegree(NumberA, NumberB));
// int ToDegree(int a, int b)
// {
//     int step = 1;
// for (int i = 1; i <= b; i++)
// {
//     step = step *a;
// }
// return step;
// }

// int ReadInt(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
//Задача 27

// int number = ReadInt("Введите число: ");
// int num = SumNumbers(number);
// Console.WriteLine($"Сумма цифр {SumNumbers(num)} ");
// int SumNumbers(int number)
// {
//     int sum = 0;
//    while(number>0)
//    {
//     sum+=number%10;
//     number/=10;
//    }
//    return sum;
// }
// int ReadInt(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// Задача 29

// int [] numbers = new int[8];
// Console.Write("[");
// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers [i] = new Random().Next(0, 10);
//     Console.Write(" "+ Method (i) + " ");
// } 
// Console.Write("]");
// int Method (int a)
// {
//     return numbers[a];
// }