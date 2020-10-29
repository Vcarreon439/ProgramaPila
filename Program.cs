using System;

namespace ProgramaPila
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila objn = new Pila(-1);

            objn.insertar_pila(12);
            objn.insertar_pila(13);
            objn.insertar_pila(14);
            objn.insertar_pila(15);
            objn.insertar_pila(16);
            objn.insertar_pila(17);
            objn.insertar_pila(18);
            objn.insertar_pila(19);
            objn.insertar_pila(20);
            objn.insertar_pila(21);
            objn.insertar_pila(22);
           
            objn.mostrar_elementos();

            Console.ReadKey();
        }
    }
}
