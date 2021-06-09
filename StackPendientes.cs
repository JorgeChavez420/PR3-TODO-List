using System;
using System.Collections.Generic;

namespace PR3_TODO_List
{
    class StackPendientes
    {
        List<string> pendientes = new List<string>();

        public int count
        {
            get => this.pendientes.Count;
        }

        public void Push(string pendiente)
        {
            this.pendientes.Add(pendiente);
        }

        public string Pop()
        {
            string value = this.pendientes[this.pendientes.Count - 1];

            this.pendientes.RemoveAt(this.pendientes.Count - 1);

            return value;
        }

        public string Peek()
        {
            return this.pendientes[this.pendientes.Count - 1];
        }

        public void PrintStack()
        {
            for (int i = this.pendientes.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(pendientes[i]);
            }
        }

    }
}