using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA__VSCode.LinkedList
{
    public class Node
    {
        public int Value { get; set; }

        public Node? NextNode { get; set; }

        public Node? PrevNode { get; set; }

        public Node(int value)
        {
            this.Value = value;
            this.NextNode = null;
            this.PrevNode = null;
        }
        
    }

    public class DoublyLinkedList
    {
        private Node head;
        private Node tail;
        private int length=0;

        public DoublyLinkedList(int value)
        {
            this.head = new Node(value);
            this.tail=this.head;
            this.length=1;
        }

        public void Append(int value)
        {
            Node newNode = new Node(value);
            this.tail.NextNode=newNode;
            newNode.PrevNode=this.tail;
            this.tail=newNode;

            this.length++;

        }

        public void Prepend(int value)
        {
            Node newNode = new Node(value);
            newNode.NextNode=this.head;
            this.head.PrevNode=newNode;
            this.head = newNode;
    
            this.length++;
        }

        public void Insert(int index, int value)
        {

            if (index == 0)
            {
                Prepend(value);
                return;
            }

            if (index >= this.length)
            {
                Append(value);
                return;
            }



            Node newNode = new Node(value);
            Node current = this.head;

            for (int i = 0; i < index - 1; i++)
            {
                current = current.NextNode; // This is one node before we need to insert new value
            }
            Node nextNode = current.NextNode;//this is one node after we need to insert new value
            newNode.NextNode = nextNode;
            newNode.PrevNode = current;
            nextNode.PrevNode=newNode;
            current.NextNode = newNode;

            this.length++;
        }


    public void Remove(int index)
    {
        if( index > this.length || index < 0 )
        { 
            Console.WriteLine("Incorrect index: " + index);
            return;
        }
        if(index == 0)
        {
            this.head=head.NextNode;
            this.length--;
            return;
        }
        Node currentNode = this.head;
       
        for (int i=0; i<index-1; i++)
        {
            currentNode = currentNode.NextNode; // This is one node before we need to insert new value
        }
        Node deleteNode = currentNode.NextNode;
        
        currentNode.NextNode=deleteNode.NextNode.NextNode;
        deleteNode.NextNode.PrevNode=currentNode;
       

        this.length--;
        return;
        

    }


        public void PrintList()
        {
            Node currentNode= this.head;
            int[] result = new int[this.length];
            int counter= 0;
            while(currentNode != null)
            {
                result[counter] = currentNode.Value;
                currentNode= currentNode.NextNode;
                counter++;
            }

            for(int i=0; i<result.Length; i++)
            {
                Console.Write(result[i] + "-->");
            }
            Console.WriteLine();
        }
    }
}