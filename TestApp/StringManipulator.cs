using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
 
        public class StringManipulator
        {
            public string ReverseString(string input)
            {
           
              char[] inputArray = input.ToCharArray();
              Array.Reverse(inputArray);            
                return new string(inputArray);
            }

            public bool IsPalindrome(string input)
            {
              
                return input == ReverseString(input);
            }
        }
    
}
