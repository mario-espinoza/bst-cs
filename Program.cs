using System;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0) {
                Console.WriteLine("debe ingresar parametros");
                return;
            }
            if (args.Length == 1) {
                Console.WriteLine("Construccuion de BST");
                int[] values = ArgumentsUtil.validateTreeArgs(args[0]);
                foreach (var node in values) {
                    Console.WriteLine($"Nodes: {node}");
                }
                return;
            }

            if (args.Length == 2) {
                Console.WriteLine("Distancia Raiz Nodo");
                return;
            }

            if (args.Length == 3) {
                Console.WriteLine("Distancia Entre Nodo");
                return;
            }
            foreach (var arg in args) {
                Console.WriteLine($"Arg: {arg}");
            }
        }
    }
}
