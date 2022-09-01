// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("введите пятизначное число");
int fiveNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(fiveNumber);
if (stringNumber[0] == stringNumber[4] && stringNumber[1] == stringNumber[3])
{
    Console.WriteLine("введенное число это палиндром");
}
else 
{
    Console.WriteLine("введенное число не палиндром");
}

