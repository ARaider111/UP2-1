using System;

class Program
{
  static bool CheckRepetitions(int[] nums, int n)
  {
    SortArray(nums, n);
    for (int i = 0; i < n - 1; ++i)
    {
      if (nums[i] == nums[i + 1])
      {
        return true;
      }
    } 
    return false;
  }
  
  static void SortArray(int[] nums, int n)
  {
    for (int i = 0; i < n; ++i)
    {
      for (int j = 0; j < n - 1; ++j)
      {
        if (nums[j] > nums[j + 1])
        {
          int temp = nums[j];
          nums[j] = nums[j + 1];
          nums[j + 1] = temp;
        }
      }
    }
  }
  
  public static void Main (string[] args) 
  {
    int n = 0;
    Console.WriteLine ("Введите количество чисел в массиве: ");
    n = int.Parse(Console.ReadLine());

    int[] nums = new int[n];
    for (int i = 0; i < n; ++i)
    {
      Console.Write("Введите число: ");
      nums[i] = int.Parse(Console.ReadLine());
    }

    bool isRepeatingNumbers = CheckRepetitions(nums, n);

    Console.WriteLine(isRepeatingNumbers);
  }
}