// программа, которая принимает на вход цифру, обозначающую день
//недели, и проверяет, является ли этот день выходным
{
    Console.WriteLine ("Введите цифру, означающую день недели");
    int dayweek = int.Parse (Console.ReadLine());
             if (dayweek >7)
        {
          Console.WriteLine ("Ошибка: в неделе всего 7 дней");
        }
     else
             if (dayweek ==6 || dayweek == 7) 
        {
          Console.WriteLine ("Выходной день");
        }
     else
           if (dayweek <= 5)
       {
          Console.WriteLine ("Будний день");
       }
}