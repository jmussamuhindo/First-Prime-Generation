using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace PRIME1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] numbers = new int[n, 2];
            for (int i=0;i<n;i++)
            {
                string line = Console.In.ReadLine();
                int index = line.IndexOf(" ");
                numbers[i, 0] =Convert.ToInt32(line.Substring(0,index));
                numbers[i, 1] =Convert.ToInt32(line.Substring(index+1));
            }
            for (int j = 0; j < n; j++)
            {
                int a = numbers[j, 0];
                int b = numbers[j, 1];
                var result = new ArrayList();
                if (a == 1)
                    a++;
                for (int p = a; p <= b; p++)
                {
                    bool check = true;
                    var l = Math.Floor(Math.Sqrt(p));
                    
                    for (var s = 2; s <= l; s++)
                    {
                        if (p % s == 0)
                        {
                            check = false;
                            break;
                        }
                    }
                    if (check)
                        result.Add(p);
                }
                Console.WriteLine(string.Join("\n", result.ToArray()));
                if (j != n - 1)
                    Console.WriteLine();
             }
        }
    }
}