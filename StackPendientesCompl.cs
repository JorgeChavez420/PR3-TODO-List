using System;
using System.Collections.Generic;

namespace PR3_TODO_List
{
    class StackPendientesCompl
    {
        List<string> completados = new List<string>();

        public int count
        {
            get => this.completados.Count;
        }

        public void Push(string completado)
        {
            this.completados.Add(completado);
        }

        public string Pop()
        {
            string value = this.completados[this.completados.Count - 1];

            this.completados.RemoveAt(this.completados.Count - 1);

            return value;
        }

        public string Peek()
        {
            return this.completados[this.completados.Count - 1];
        }

        public void PrintStack()
        {
            for (int i = this.completados.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(completados[i]);
            }
        }

    }
}