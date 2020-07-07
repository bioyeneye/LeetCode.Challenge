using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrangingCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfFullStairCase = ArrangeCoins(100);
            Console.WriteLine($"Number of full staircase rows: {numberOfFullStairCase}");
        }
        
        private static int ArrangeCoins(int n) {
        
            if(n < 1) return 0;
        
            List<int> shape = new List<int>();

            while(shape.Sum() < n){
                if(shape.Count == 0) {
                    shape.Add(1);
                }
                else{
                    int currentSum = shape.Sum();
                    int rem = n - currentSum;
                    int index = shape.Count;
                    if(shape[index-1] >= rem){
                        shape.Add(rem);
                    } else{
                        shape.Add(++index);
                    }
                }
            }
        
            return shape.Max();
        }
    }
}