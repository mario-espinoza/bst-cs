using System;

namespace BST
{
    class Program
    {
        private static Tree setUpTree(int[] values) {
            Tree t = new Tree();

            foreach (var node in values) {
                Console.WriteLine($"Nodes: {node}");
                t.insert(node);
            }

            return t;
        }

        static void Main(string[] args)
        {
            if (args.Length == 0) {
                Console.WriteLine("debe ingresar parametros");
                return;
            }

            
            if (args.Length == 1) {
                Console.WriteLine("Construccuion de BST");
                int[] values = ArgumentsUtil.validateTreeArgs(args[0]);
                
                Tree t = setUpTree(values);
                
                t.print();
                return;
            }

            if (args.Length == 2) {
                Console.WriteLine("Distancia Raiz Nodo");

                int[] values = ArgumentsUtil.validateTreeArgs(args[0]);
                int node = ArgumentsUtil.validateNode(args[1]);
                
                Tree t = setUpTree(values);

                int distanceToRoot = t.distanceToRoot(node);
                Console.Write("\n Distance To root " + distanceToRoot);

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
