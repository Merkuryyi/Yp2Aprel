using System;
class Program 
{
    static int findOfJewelry(string jewelry, string stone)
    {
        int count = 0;

        foreach(var st in stone)
        {
            if(jewelry.Contains(st.ToString()))
            {
                count++;
            }
        }

        return count;
    }
    static void Main() 
    {
        string jewelry = Console.ReadLine();
        string stone = Console.ReadLine();
        
        Console.WriteLine(findOfJewelry(jewelry, stone));
    }
}