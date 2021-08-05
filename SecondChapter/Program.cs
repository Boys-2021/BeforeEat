using System;
using static System.Console;

namespace SecondChapter
{
    class Program
    {
        static void Main(string[] args){
          string input = "";
          int count = 1;
          do{
              WriteLine("Enter a good pass");
              input = ReadLine();
              count++;
          }while(input.Length<10&&count<5);
        }
      }
    
}
