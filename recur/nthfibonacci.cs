using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    
    public static int Fibonacci(int n) {

        Dictionary<int, int> dict = new Dictionary<int, int>();

        if (n == 1 || n== 0)
        {
            return n;
        }
        else
        {
            dict[n] = Fibonacci(n-1) + Fibonacci(n-2);
        }
        return dict[n];
      

    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Fibonacci(n));
    }
}

