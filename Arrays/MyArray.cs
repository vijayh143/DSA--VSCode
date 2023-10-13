using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA__VSCode.vscode.Arrays
{
    public class MyArray
    {
        public int length;
        private Object[] data;
        public MyArray()
        {
            this.length = 0;
            this.data =new Object[1];
        }

        public object Get(int index)
        {
            return data[index];
        }

        public Object Push(Object item)
        {

            if(this.data.Length == this.length)
            {
                Object[] temp = new Object[this.length];
                Array.Copy(this.data, temp, length);
                this.data =new Object[length+1];
                Array.Copy(temp,data, this.length);

            }
            this.data[this.length]=item;
            this.length++;

            return this.data;
        }

        public object Pop()
        {
            Object poped = data[this.length -1];
            this.data[this.length -1]= null;
            this.length--;
            return poped;

        }

        public Object Delete(int index)
        {
            Object deleted= this.data[index];
            ShiftItems(index);

            return deleted;
        }


        private void ShiftItems(int index)
        {
            for(int i= index; i < this.length -1; i++)
            {
                data[i] = data[i + 1];
            }
            data[this.length -1] = null;
            this.length--;
        }


/*MyArray arr = new MyArray();
arr.Push("Hi");
arr.Push("bye");

arr.Pop();

arr.Push("see ya");
arr.Push("try");

arr.Delete(3);

for(int i = 0; i < arr.length; i++)
    Console.WriteLine(arr.Get(i));*/

    
    }
}