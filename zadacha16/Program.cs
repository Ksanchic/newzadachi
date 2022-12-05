// программа,которая принимает на вход 2 числа и проверяет, является 
// ли одно число квадратом другого 
{
int a;
int b;
Console.WriteLine ("Введите два числа: ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());


  if ((a * a == b)| (b * b == a))
  {
    Console.WriteLine ("да");
  }
 
else
{
    Console.WriteLine ("нет");
}
}
