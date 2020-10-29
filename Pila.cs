using System;
using System.Linq;

namespace ProgramaPila
{
    class Pila
    {
        //Declaracion del numero de elementos como constante
        const int num_elementos = 10;
        //delcaracion del arreglo que simula una pila
        private int[] pilas = new int[num_elementos];
        //decalracion de la variable que contiene en maximo numero de elementos
        int max_pila = num_elementos - 1;
        //declaracion de la variable tope
        int tope;

        #region MyEnumerator
        /*
        public MyEnumerator GetEnumerator()
        {
            return new MyEnumerator(this, tope);
        }

        // Declare la clase MyEnumerator:  
        //_______________________________________________________________________________________________
        public class MyEnumerator                                                                          
        {
            //variable de control                                                                     
            int nIndex;
            //Objeto pila
            Pila objn;
            //Metodo MyEnumerador para la sentencia foreach
            public MyEnumerator(Pila coleccion, int posicion)
            {
                //objn = a coleccionen la que se esta trabajando
                objn = coleccion;
                //Posicion 
                nIndex = posicion+1;
            }

            public bool MoveNext()
            {
                //Comprueba que sea mayor a 0
                if (nIndex > 0) 
                { 
                    //Decremento de control
                    nIndex--;
                    //retorna verdadero
                    return (nIndex < objn.pilas.Length);
                }
                else
                {
                    //retorna falso para no pasar los limites
                    return false;
                }
            }

            //"Imprime" el valor en la posicion nIndex
            public int Current => objn.pilas[nIndex];
        }
        //_______________________________________________________________________________________________
        */
        #endregion

        //agregar el constructor que inicialice la variable tope
        public Pila(int top) 
        {
            tope = top;              
        }

        public void insertar_pila(int dato) 
        {
            if (valida_pilaLlena())
            {
                tope++;
                pilas[tope] = dato;
                //Agregar un mensaje VALIDANDO que el elemento se Inserto
                Console.WriteLine("Elemento {0} insertado en la posicion {1}", dato, tope+1);
            }
            else
            {
                //Agregar un mensaje Validando cual elemento no se inserto
                Console.WriteLine("PILA LLENA NO SE PUEDEN INSERTAR MAS ELEMENTOS");
                Console.WriteLine("Elemento {0} no se inserto", dato);
            }
        
        }

        private bool valida_pilaLlena() 
        {
            if (tope == max_pila)
                return false;
            else
                return true;
        }

        /*
         * 
           Metodo sacar un elemento de la pila mandado llamar a otro metodo que valida si
           se pueden sacar elementos, se debe mostrar el valor del elemento eliminado y en 
           caso de que no existan mas elementos en la pila enviar el mensaje indicando 
           que no se pueden eliminar mas elementos porque no se pueden eliminar mas elementos
           porque no hay mas datos en la pila
        *
        */

        public void sacar_elemento() 
        {
            if (valida_pilaVacia())
                Console.WriteLine("No hay elementos en la pila");
            else
                Console.WriteLine("Elemento {0} en la pila, es {1}", tope, pilas[tope]);
                tope--;
        }

        bool valida_pilaVacia()
        {
            if (tope >= 0)
                return false;
            else
                return true;
        }

        
        public void mostrar_elementos()
        {
            Array.Reverse(pilas);

            Console.WriteLine("-----------------Metodo mostrar elementos-------------------------------");
            foreach (var item in pilas)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------------------------------");
        }
        

    }
}
