using System;
using System.Runtime.Remoting.Messaging;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt;
            string result;
            Console.WriteLine("Enter the string");
            txt = Console.ReadLine();
            //Program p=new Program();
            result = Reverse(txt);
            Console.WriteLine(result);

        }
        public static string Reverse(string txt) 
        {
            string rev=string.Empty;
            char[] ca= txt.ToCharArray();
            for(int i=ca.Length-1; i>=0; i--) 
            {
                rev += ca[i];
            }
            return rev;
        }        
    }
}
