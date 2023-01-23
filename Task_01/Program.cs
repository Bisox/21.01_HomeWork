// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Promt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int Calculation(int number)
{

    int palindrome = 0;


    while (number > 0)
    {

        int digit = number % 10;
        number = number / 10;
        palindrome = palindrome * 10;
        palindrome = palindrome + digit;
    }
    return palindrome;

}

int num = Promt("Введите число");
int palin = Calculation(num);
if (num == palin)
{
    Console.WriteLine($"Число {palin} является палиндромом:  {num}");
}
else
{
    Console.WriteLine($"Число {palin}  не является палиндромом:  {num}");
}
