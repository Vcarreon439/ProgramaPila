using System;
using System.Threading;

namespace ProgramaPila
{
    class Program
    {
        static void Main(string[] args)
        {
            Menus menus = new Menus();
            menus.MenuPrincipal();
            Console.Read();
        }
    }
}
