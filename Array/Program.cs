using System;
using System.Linq.Expressions;
namespace Array;
class Program
{
    public static void Main(string[] args)
    {
        String[] arr = { "Raagavan", "Mani", "Ganesh", "Venkat", "Suresh" };

        Console.WriteLine("enter the name");
        String name = Console.ReadLine();
        bool flag = false;

        for (int i = 0; i < arr.Length; i++)
        {
            if (name.Equals(arr[i],StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("For Loop : \nThe name is present. the index value is: " + i);

                flag = true;
                
            }
        }
        
        if (flag == false)
        {
            Console.WriteLine("For Loop : \nThe name is not present");
        }

        foreach (String i in arr)
        {

            if (name.Equals(i))
            {
                Console.WriteLine("Foreach Loop : \nThe name is present.");
                flag = true;
                
            }
        }
        if (flag == false)
        {
            Console.WriteLine("Foreach Loop : \nThe name is not present");
        }

         int n = int.Parse(Console.ReadLine());
        
        int[] a =new int[n];
        for(int i=0;i<n;i++){
            a[i]=int.Parse(Console.ReadLine());
        }



    }
}
