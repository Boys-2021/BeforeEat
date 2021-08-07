using System;
using static System.Console;

namespace SecondChapter
{
    class Program
    {
         static int Factorial(int x ){
            if(x<1){
               return 0;
            }
            else if(x==1){
               return 1;
            }else{
               checked{
                return x*Factorial(x-1);
               }
            }
         }

         static void Main(string[] args){
            for(int i=1;i<15;i++){
               try{
               WriteLine($"{i}! = {Factorial(i):N0}");
               }catch{
                  WriteLine(i+"! Too large Bokka. OVerflown");
               }
            }
         }
   }
}
