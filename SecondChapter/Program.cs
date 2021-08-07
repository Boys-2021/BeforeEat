using System;
using static System.Console;

namespace SecondChapter
{
    class Program
    {
       /// <summary>
       ///  asdadasd
       /// </summary>
       /// <param name="x">asdasd</param>
       /// <returns>sada</returns>
         static int Fib(int x ) => 
            x switch{
               0 => 0,
               1 => 1,
               _ => Fib(x-2)+Fib(x-1)
            };

         static void Main(string[] args){
            for(int i=1;i<15;i++){
               try{
               WriteLine($"{i}! = {Fib(i):N0}");
               }catch{
                  WriteLine(i+"! Too large Bokka. OVerflown");
               }
            }
         }
   }
}
