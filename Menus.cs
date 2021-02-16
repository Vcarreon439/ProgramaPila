using System;
using System.Threading;

namespace ProgramaPila
{
    class Menus
    {
        public Menus() 
        {
        
        }

        public void MenuPrincipal()
        {
            Console.Title = "Programa pila";
            Pila trabajo = new Pila();


            do
            {
                Console.Clear();
                Console.Title = "Programa pila";
                Console.WriteLine("Que desea hacer?");
                Console.WriteLine("\t1.- Crear una pila");
                Console.WriteLine("\t2.- Push");
                Console.WriteLine("\t3.- Pop");
                Console.WriteLine("\t4.- Peek");
                Console.WriteLine("\t5.- Recorrido de pila");
                Console.WriteLine("\t6.- Salir");


                switch (Console.ReadLine())
                {
                    case "1":
                        trabajo = new Pila();
                        break;

                    case "2":
                        Console.Clear();
                        Console.Title = "Insercion";
                        trabajo.Push(MenuTipo());
                        break;

                    case "3":
                        Console.Clear();
                        Console.Title = "Función Pop";
                        Object var1 = trabajo.Pop();
                        Console.WriteLine("Dato:{0} Tipo:{1}", var1, var1.GetType());
                        
                        break;

                    case "4":
                        Console.Clear();
                        Console.Title = "Función Peek";
                        Object  var2 = trabajo.Peek();
                        Console.WriteLine("Dato:{0} Tipo:{1}", var2, var2.GetType());
                        break;

                    case "5":
                        Console.Clear();
                        Console.Title = "Función Recorrido";
                        trabajo.Recorrido();
                        Console.ReadKey();
                        break;

                    case "6":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Elija una opción valida");
                        break;
                }

            } while (true);
        }


        private Object MenuTipo()
        {
            Object valor = null;
            bool rep = false;
            do
            {
                try
                {
                    Console.WriteLine("Que tipo de dato desea insertar?");
                    Console.WriteLine("\t1.- Entero");
                    Console.WriteLine("\t2.- Double");
                    Console.WriteLine("\t3.- Cadena");
                    Console.WriteLine("\t4.- Booleano");
                    Console.WriteLine("\t5.- Regresar");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.Write("Elemento a ingresar {Int32}: \t");
                            valor = Convert.ToInt32(Console.ReadLine());
                            break;

                        case "2":
                            Console.Write("Elemento a ingresar {Double}: \t");
                            valor = Convert.ToDouble(Console.ReadLine());
                            break;

                        case "3":
                            Console.Write("Elemento a ingresar {String}: \t");
                            valor = Console.ReadLine();
                            break;

                        case "4":
                            Console.Write("Elemento a ingresar {Bool}: \t");
                            //
                            string selector = Console.ReadLine();
                            //
                            if (selector == "Verdadero" | selector == "verdadero" | selector == "V" | selector == "Si" | selector == "True" | selector == "Treu" | selector == "true" | selector == "treu" | selector == "v" | selector == "si" | selector == "s")
                                valor = true;
                            //
                            if (selector == "Falso" | selector == "F" | selector == "False" | selector == "No"|selector == "falso" | selector == "f" | selector == "false" | selector == "no")
                                valor = false;

                            break;

                        case "5":
                            rep = false;
                            break;

                        default:
                            Console.WriteLine("Elija una opción valida");
                            rep = true;
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Porfavor ingrese conrrectamente el dato");
                    rep = true;
                }

            } while (rep);

            return valor;
        }


    }
}
