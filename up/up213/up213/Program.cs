using System;

class Program
{
    static bool uniqueValue(int[] nums )
    {
        int count = 0;
        foreach (var s in nums)
        { 
            count++;
        }
   
        for (int i = 0; i < count; i++)
        {
            for (int j = 0; j < count; j++)
            {
                if (i!=j  && nums[i] == nums[j])
                {
                    return true;
                }
            }
        }
        return false;
    }
    static void Main()
    {
        string numbers = Console.ReadLine();
        int[] nums = Array.ConvertAll(numbers.Split(' '), int.Parse);
        Console.WriteLine(uniqueValue(nums));
    }
}