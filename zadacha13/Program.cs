// программа, которая выводит третью цифру заданного 
//числа или сообщает, что третьей цифры нет

{
    int num;
Console.WriteLine ("Введите число");
string a = Console.ReadLine ();

 if (a.Length <=2)
 {
    Console.WriteLine ("Третьей цифры нет");
 }
 else 
 
      Console.WriteLine ("Третья цифра: " +a[2]);
 }
