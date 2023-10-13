using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA__VSCode.HashTable
{
    public class FirstRecuringChar
    {
        public string FirstValue(int[] arr)
        {
            Hashtable hash= new Hashtable(arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                if(!hash.ContainsKey(arr[i]))
                    hash.Add(arr[i],i);
                else
                    return arr[i].ToString();
            }
            
            return "undefined";

        }
    }

/*FirstRecuringChar fc = new FirstRecuringChar();
int[] array = {2,3,5,6,2,5,6,7};
Console.WriteLine(fc.FirstValue(array));
*/
}