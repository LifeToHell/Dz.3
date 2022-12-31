// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Напишите первое число");

uint a = Convert.ToUInt32(Console.ReadLine());

Console.WriteLine("Напишите второе число");

uint b = Convert.ToUInt32(Console.ReadLine());


if (a < b){  
Console.Write(a + "<" + b);

} 
if (a > b){  
Console.WriteLine(a + ">" + b);

} 
if(a == b){
 Console.WriteLine(a + "=" + b);

}
