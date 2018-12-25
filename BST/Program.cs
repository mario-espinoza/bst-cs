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
                Console.WriteLine("Debe ingresar parametros separados por espacios:");
                Console.WriteLine("Para inicializar Arbol: \nlista separada por comas de valores enteros\n Ej: input 2,1,3 //output 1,2,3");
                Console.Write("Para Distancia a Raiz: \n Lista separada por comas de valores enteros \n Valor nodo \n Ej: 1,2 1 \n");
                Console.Write("Para Distancia a entre nodos: \n Lista separada por comas de valores enteros \n Valor nodo A\n Valor nodo B\n Ej: 1,2,3,4 1 4\n");
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

                int distanceToRoot = Tree.distanceToRoot(t, node);
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
