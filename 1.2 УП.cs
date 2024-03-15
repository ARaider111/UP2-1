using System;
using System.Collections.Generic;

class Program 
{
  static List<List<int>> CombinationSum(int[] numbers, int target)
  {
    List<List<int>> result = new List<List<int>>();
    Array.Sort(numbers);
    FindCombinations(numbers, target, new List<int>(), result, 0);
    return result;
  }

  static void FindCombinations(int[] numbers, int target, List<int> current, List<List<int>> result, int start)
  {
    if (target == 0)
    {
        result.Add(new List<int>(current));
        return;
    }

    for (int i = start; i < numbers.Length; ++i)
    {
      if (i > start && numbers[i] == numbers[i - 1])
      {
        continue;
      }
      else if (numbers[i] > target)
      {
        break;
      }

      current.Add(numbers[i]);

      FindCombinations(numbers, target - numbers[i], current, result, i + 1);

      current.RemoveAt(current.Count - 1);
    }
  }
  public static void Main (string[] args)
  {
    int n = 0;
    Console.WriteLine ("Введите количество чисел: ");
    n = int.Parse(Console.ReadLine());

    int[] numbers = new int [n];
    for (int i = 0; i < n; ++i)
    {
      Console.Write($"Введите число {i}: ");
      numbers[i] = int.Parse(Console.ReadLine());
    }

    int target = 0;
    Console.WriteLine("Введите число для поиска: ");
    target = int.Parse(Console.ReadLine());

    List<List<int>> result = CombinationSum(numbers, target);

    foreach (List<int> combination in result)
    {
        Console.WriteLine($"[{string.Join(", ", combination)}]");
    }
  }
}