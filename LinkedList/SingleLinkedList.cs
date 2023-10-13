public class Node{
    public int Value { get; set; }
    public Node? Next { get; set; }

    public Node(int value){
        this.Value = value;
        this.Next = null;
    }

}

public class LinkedList{
    private Node head;
    private Node tail;
    private int length;

    public LinkedList(int value)
    {
        this.head = new Node(value);
        this.tail = this.head; //This is reference when object is created, so this.head.next = this.tail.next.
        this.length =1;
    }

    public void Append(int value)
    {
        Node newNode = new Node(value);
        this.tail.Next=newNode; // when the first append happens, this will make this.head.next = newNode
        this.tail=newNode; // now tail is pointed to newNode, head is remained in its begining position.

        this.length++;

    }

    public void Prepend(int value)
    {
        Node newNode = new Node(value);
        newNode.Next=this.head;
        this.head = newNode;
    
        this.length++;
    }

    public void Insert(int index, int value)
    {
      
        if(index == 0)
        {
            Prepend(value);
            return;
        }
       
        if(index >= this.length)
        {    
            Append(value);
            return;
        }
     


        Node newNode = new Node(value);
        Node current = this.head;

        for (int i=0; i<index-1; i++)
        {
            current = current.Next; // This is one node before we need to insert new value
        }
        Node nextNode = current.Next;//this is one node after we need to insert new value
        newNode.Next = nextNode; 
        current.Next = newNode;

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
            this.head=head.Next;
            this.length--;
            return;
        }
        Node currentNode = this.head;

         for (int i=0; i<index -1; i++)
        {
           currentNode = currentNode.Next; // This is one node before we need to insert new value
        }

        Node deleteNode = currentNode.Next;
        currentNode.Next=deleteNode.Next;

        this.length--;
        return;
        

    }


    public void Reverse()
    {
        if(this.length == 1)
        {
            return;
        }
        Node first= this.head;
        Node second= first.Next;
        this.tail= this.head; // Making the first node as Tail
        for (int i=0; i<this.length -1; i++)
        {
            Node temp= second.Next;
            second.Next =first;
            first =second;
            second= temp;
        }
        this.head.Next=null;
        this.head=first; // Making the last node as Head
    }

    public void PrintList()
    {
        Node currentNode = this.head;
        int[] result= new int[this.length];
        int counter=0;
        while(currentNode != null)
        {
            result[counter]=currentNode.Value;
            counter++;
            currentNode = currentNode.Next;
        }

        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i] + "-->");
        }
        Console.WriteLine();

    }

/*
LinkedList list = new LinkedList(10);

list.Append(20);
list.Append(30);

list.Prepend(0);
// 0 --> 10 --> 20 --> 30 
list.Insert(2,25);


list.Remove(4);

int[] result = list.GetList();

for(int i = 0; i < result.Length; i++)
    Console.Write(result[i] + "-->");
    */

}