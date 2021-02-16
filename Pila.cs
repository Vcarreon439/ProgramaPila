using System;
using System.Linq;

namespace ProgramaPila
{
    class Pila
    {
        private Nodo Base;
        private Nodo Trabajo;

        public Pila()
        {
            Base = new Nodo();
            Base.Siguiente = null;
        }


        public void Push(Object dato) 
        {
            Nodo temporal = new Nodo();
            temporal.Dato = dato;
            temporal.Siguiente = Base.Siguiente;
            Base.Siguiente = temporal;
        }

        public Object Pop() 
        {
            try
            {
                //
                Object valor;
                //
                Trabajo = Base.Siguiente;
                valor = Trabajo.Dato;
                //
                Base.Siguiente = Trabajo.Siguiente;
                Trabajo.Siguiente = null;

                return valor;
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("Ya no hay elementos en la pila");
                return false;
            }
        }


        public Object Peek()
        {
            try
            {
                //
                Object valor;
                //
                Trabajo = Base.Siguiente;
                valor = Trabajo.Dato;
                //
                return valor;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("La pila esta vacia");
                return false;
            }
        }

        public void Recorrido() 
        {
            Trabajo = Base;

            while (Trabajo.Siguiente!=null)
            {
                Trabajo = Trabajo.Siguiente;

                Object d = Trabajo.Dato;

                Console.WriteLine("Dato:{0} Tipo:{1}]", d, d.GetType());
            }
        }

    }
}
