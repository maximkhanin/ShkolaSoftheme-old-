using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace Task2
{
    public static class ExtensionMethods
    {
        public static void Print(this string[] prArray)
        {
            foreach (var pr in prArray)
            {
                Console.WriteLine("{0}; ", pr);
            }
        }
        
        
        public static void Print(this string[] prArray, ConsoleColor[] colors)
        {
            
            for(int i=0;i<prArray.Length;i++){
                
                Console.WriteLine("{0}-{1}; ", prArray[i],colors[i].ToString());
            }
        }
        
       
        
        
    }
}