using System;

namespace consoleApp3;

class switchcase {
    static void Main(string[] args)
    {
        int i=0, j=0, k = 0;
        int userchoice;
        char symbol = ' ';
        Console.WriteLine("enter the Number shown in Menu \n");
        Console.WriteLine("Menu  : \n 1.Multiply \n 2.Division \n 3.Exit");
        userchoice=Convert.ToInt32(Console.ReadLine());
        if (userchoice != 3)
        {
            Console.WriteLine("Enter value of i");
            i=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of j");
            j = Convert.ToInt32(Console.ReadLine());
        }
        switch (userchoice) {
            case 1:
                symbol = '+';
                k = i*j;
                break;
            case 2:
                symbol = '/';
                k = i/j;
                break;
            case 3:
                Environment.Exit(1);
                break;
            default:
                Environment.Exit(1);
                break;
        }
        Console.WriteLine("The answer of {0} {1} {2} ={3}",i, symbol, j, k);
        Console.ReadLine();

    }
}

