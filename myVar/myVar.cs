using System;

//Fabian Acosta
//01-28-2023
//myVar Assignment
namespace Test1
{
    internal class myVar
    {
        static void Main(string[] args)
        {
            //myVar is the variable that will be used to test arithmetic operations and if-else statements
            int myVar = 7;
            
            Console.WriteLine(-1 + 4 * myVar);
            Console.WriteLine((35 + 5) % myVar);
            Console.WriteLine(14 + -4 * 6 / 12);
            Console.WriteLine(2 + 12/6 * 1 - myVar % 2);
            //Testing myVar with if statements
            if(myVar * myVar < 10)
            {
                Console.WriteLine("myVar is less than 4");
            }
            else
            {
                Console.WriteLine("myVar is greater than 4");
            }
         }
    }
}