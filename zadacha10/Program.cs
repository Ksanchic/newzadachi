
// Программа, которая принимает на вход трехзначное число и 
//на выходе показывает втроую цифру этого числа

{
Console.WriteLine ("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
int b = a % 100/10;
 if (a > 99 && a < 1000 || a <- 99 && a < -1000)
 {
    Console.WriteLine ("Вторая цифра: "+ b);
 }
 else 
 {
 Console.WriteLine ("Третьей цифры нет");
 }
}