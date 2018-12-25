# bst-cs #

Esta Solución fue reallizada con dotnet core SDK en osx.

Consta de dos proyectos:

* BST: Contiene la aplicación de consola que implementa Binary Search Tree
* BST.Test: Contiene pruebas unitarias de la aplicación BST

## Ejecución ##

### BST ###

1. Para construir el BST: dotnet run treeDefinition, Ej: dotnet 1,2,4,3 // output 1,2,3,4
2. Para calcular el BST: dotnet run treeDefinition node,  Ej: dotnet 1,2,4,3 4  // output: 2
3. Para calcular el BST: dotnet run treeDefinition nodeA nodeB, Ej: dotnet 1,2,4,3 2 3 //output 2

### BST.Test ###

  Para ejecutar las pruebas unitarias, en la raiz de la solución ejecutar el comando dotnet test

## Teoría ##

Primero tenemos que el problema de la distancia entre el nodo Raiz y un Nodo Hoja es un caso particular de la distancia entre dos Nodos nodos del arbol, así que partiremos con el caso general y luego avanzaremos al particular.

Como los BST tienen la cualidad de estar ordenados, al realizar consultas recursivas y recorrer el arbol por cada una de sus ramas es que obtendremos la solucion al problema. En el caso que uno de los nodos sea el nodo raiz, este problema se reduce al primer problema de la distancia entre un nodo y la raiz.

Para esto generaremos una funcion busqueda que recorra el arbol en busqueda del valor e iremos incrementado en cada iteración la distancia de busqueda, de modo que al final obtendremos el valor usando como condiciones de borde que el valor sea igual (nodo encontrado) o no se encuentre (se detiene la busqueda) por cada iteracion se incrementará la distancia recorrida hasta llegar a la hoja encontrada
