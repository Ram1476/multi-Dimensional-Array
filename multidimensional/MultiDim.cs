using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multidimensional
{
    internal class MultiDim
    {
        public void ExampleMultiArr() 
        {
            int sum = 0;
            int Rowsum;
            int[,] mArray = new int[2, 3]{
                {1,2,3}, {4,5,6}
            };
            for (int row = 0; row  < 2; row++) 
            {
                Rowsum = 0;
                for (int col = 0; col < 3; col++) 
                {
                    Console.Write($"{mArray[row,col]}\t");
                    Rowsum += mArray[row,col];
                }
                sum += Rowsum;
                Console.Write($" = {Rowsum}");
                Console.WriteLine();
            }
            Console.WriteLine($"\nThe Sum of Array is : {sum}");
            Console.ReadLine();
        }
    }
}
