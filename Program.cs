using System;

namespace Functions_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("your name: ");
           name=Console.ReadLine();
           for(int i=name.Length-1; i>=0;i--)
           {
               Console.Write(name[i]);
           }

           


            



        }
    }
}
