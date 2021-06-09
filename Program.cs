using System;
using System.IO;

namespace PR3_TODO_List
{
    class Program
    {
        static void Main(string[] args)
        {
            StackPendientes stackPendientes = new StackPendientes();            
            stackPendientes.Push("Terminar Proyectos[x] 27/05/2021");            
            stackPendientes.Push("Estudiar para examenes 30/05/2021");
            stackPendientes.Push("Contestar examen de matematicas 04/05/2021");

            StackPendientesCompl stackPendientesCompl = new StackPendientesCompl();          
            stackPendientesCompl.Push("Terminar Proyectos [x] 27/05/2021");
            stackPendientes.Push("Estudiar para examenes [x] 30/05/2021");

            string opcion = "";
            while (opcion != "0")
            {
                opcion = "";
                while (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "5" && opcion != "6" && opcion != "0")
                {
                    Console.WriteLine("1) Mostrar Pendientes");
                    Console.WriteLine("2) Agregar Pendiente");
                    Console.WriteLine("3) Quitar pendiente (Completado)");
                    Console.WriteLine("4) Ver pendientes completados");
                    Console.WriteLine("5) Consultar ultimo pendiente");
                    Console.WriteLine("6) Guardar/Exportar");
                    Console.WriteLine("0) Salir");

                    Console.WriteLine("Por favor, elige una opcion:");
                    opcion = Console.ReadLine();

                     if (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "5" && opcion != "6" && opcion != "0")
                    {
                        Console.WriteLine("Por favor, elige una opcion correctamente");
                    }
                }

                if (opcion == "1")
                {
                    stackPendientes.PrintStack();
                }
                else if (opcion == "2")
                {
                    Console.WriteLine("Pendiente Agregado:");
                    string pendiente = Console.ReadLine();
                    stackPendientes.Push(pendiente);
                }
                else if(opcion == "3")
                {
                    string pendiente = stackPendientes.Pop();
                    Console.WriteLine("Pendiente Removido:");
                    Console.WriteLine(pendiente);
                }
                else if (opcion == "4")
                {
                    stackPendientesCompl.PrintStack();
                }
                else if(opcion == "5")
                {
                    string pendiente = stackPendientes.Peek();
                    Console.WriteLine("Pendiente Consultado:");
                    Console.WriteLine(pendiente);
                }
                else if (opcion == "6")
                {
                    using (StreamWriter sw = new StreamWriter("pendientes.txt"))
                    {
                        sw.WriteLine();        
                    }    
                }                       
                else if (opcion == "0")
                {
                    Console.WriteLine("Hasta luego!");
                }
                
            }    
        }
    }
}
