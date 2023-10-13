using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DSA__VSCode.Arrays
{
    public class ReverseString
    {
        public string Reverse(string str) 
        {
            int lenth= str.Length;
            if(str == null || lenth < 2)
                return "Invalid input";

            string reverse = string.Empty;
            
            for( int i = lenth -1; i >= 0; i-- )
            {
                reverse += str[i].ToString();
              
            }

            return reverse;

        }

       // ReverseString rs = new ReverseString();
       // Console.WriteLine(rs.Reverse("hi vijay"));
        
    }
}