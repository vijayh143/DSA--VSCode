// See https://aka.ms/new-console-template for more information
using System.Collections;
using DSA__VSCode.Arrays;
using DSA__VSCode.HashTable;
using DSA__VSCode.LinkedList;
using DSA__VSCode.vscode.Arrays;
using DSA__VSCode.vscode.HashTable;

Console.WriteLine("Started!");


LinkedList list = new LinkedList(10);

list.Append(20);
list.Append(30);
list.Prepend(5);

list.Reverse();

list.PrintList();
list.Remove(3);
list.PrintList();

Console.WriteLine("Finished");

