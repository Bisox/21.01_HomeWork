// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int num = Prompt("Введите число");

int cube = 1;
while (cube <= num)
{
    double print = Math.Pow(cube, 3);
    Console.WriteLine(print);
    cube += 1;
}

