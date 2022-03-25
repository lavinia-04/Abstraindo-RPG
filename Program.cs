using System;
using AbsRPG.src.Entities;

namespace AbsRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            Ninja ninja = new Ninja("Wedge", 23, "ninja");

            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));

             Console.WriteLine(arus.Attack(2));
             Console.WriteLine(arus.Attack(7));

             Console.WriteLine(ninja.Attack(1));
             Console.WriteLine(ninja.Attack(7));
        }
    }
}
