//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да




Console.Write("Введи пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
string numbersize = Convert.ToString(number);
if (numbersize.Length == 5){
if (numbersize[0] == numbersize[4] || numbersize[1] == numbersize[3]){
Console.Write(numbersize + "-" + "является палиндромом");
}
else Console.Write(numbersize + "-" + "не является палиндромом");
}
else Console.Write("Неверное число");



