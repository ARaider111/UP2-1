using System;

class Program
{
  public static void Main (string[] args) 
  {
    Console.WriteLine ("Введите символы без пробелов: ");
    string jewerly = Console.ReadLine();
    Console.WriteLine("Введите строку: ");
    string stones = Console.ReadLine();

    int count = 0;
    for (int i = 0; i < stones.Length; ++i)
    {
      for (int j = 0; j < jewerly.Length; ++j)
      {
        if (stones[i] == jewerly[j])
        {
          ++count;
        }
      }
    }
    Console.WriteLine("Результат: " + count);
  }
}