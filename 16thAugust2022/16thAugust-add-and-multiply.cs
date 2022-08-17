using System;

namespace consoleApp1;

class addandmultiply 
{
    static void Main(String[] args)
    {
        int i = 2;
        Int32 j = 3;
        int k = i + j;
        Console.WriteLine("The addition of {0} and {1} = {2}", i, j, k);

        Console.WriteLine("enter the values of i");
        i = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the values of j");
        j = Convert.ToInt32(Console.ReadLine());
        k = i * j;
        Console.WriteLine("The multiplication of {0} and {1} = {2}",i,j,k);


        
    }
}


