using System;
using static System.Console;

namespace SecondChapter
{
    class Program
    {
        static void Main(string[] args){
        A:
          Write("What is your height?");
          string hi = ReadLine();

          hi = hi switch {
            "a" => "j",
            "b" =>"Vantingale",
             _ => "2"
          };
          Write(hi);
      }
    }
}
