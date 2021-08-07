using System;
using static System.Console;

namespace SecondChapter
{
    class Program
    {
        static void Main(string[] args){
         try{
            string h = ReadLine();
            WriteLine("I am gonna PArse");
            int k = int.Parse(h);
            WriteLine("Parsed SUccessfully");
         }
         catch{
            Write("Fail");
         }
        }
      }
    
}
