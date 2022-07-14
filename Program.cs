using System;
namespace ConsoleApp9
{
    class Program
    {
        static void Main()
        {
            
            Addition addition=new Addition();
            Multipication multipication=new Multipication();
            Substraction substraction=new Substraction();   
            Division division=new Division();
            int n1 = 9;
            int n2 = 3;


            Console.WriteLine($"addition: first number={n1},second number={n2},result={addition.Operate(n1, n2)}");
            Console.WriteLine($"multipication: first number={n1},second number={n2},result={multipication.Operate(n1, n2)}");
            Console.WriteLine($"substraction: first number={n1},second number={n2},result={substraction.Operate(n1, n2)}");
            Console.WriteLine($"division: first number={n1},second number={n2},result={division.Operate(n1, n2)}");
           
           
           

               

        }
    }
}