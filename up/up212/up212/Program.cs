using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите candidates");
        string array = Console.ReadLine();
        int[] candidates = Array.ConvertAll(array.Split(' '), int.Parse);
        
        Console.WriteLine("Введите target");
        int target = int.Parse(Console.ReadLine());
        
        PrintCombinations(candidates, target);
    }

    static void PrintCombinations(int[] candidates, int target)
    {
        IList<IList<int>> allCombinations = new List<IList<int>>();

        Array.Sort(candidates);

        FindCombinations(candidates, target, 0, new List<int>(), allCombinations);

        foreach (List<int> combination in allCombinations)
        {
            Console.WriteLine("[ " + string.Join(", ", combination) + " ]");
        }
    }

    static void FindCombinations(int[] candidates, int target, int start, List<int> current, IList<IList<int>> result)
    {
        if (target == 0)
        {
            result.Add(new List<int>(current));
            return;
        }

        for (int i = start; i < candidates.Length && candidates[i] <= target; i++)
        {
            if (i > start && candidates[i] == candidates[i - 1])
            {
                continue;
            }

            current.Add(candidates[i]);
            FindCombinations(candidates, target - candidates[i], i + 1, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}




