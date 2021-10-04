using System;
using System.Linq;

namespace Training
{
    public class Program
    {
        public string s  { get; set;  }   
        
        public string Inverse(string s) 
        {
            //s =  new string(s.Reverse().ToArray());
            string inv = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                inv += s[i];
               
            }
               
            return inv;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var p = new Program();
            p.s = Console.ReadLine();
           Console.WriteLine(p.Inverse(p.s));

            
        }
    }
}
