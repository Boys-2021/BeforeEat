using System;
using static System.Console;

namespace SecondChapter
{
    class Program
    {
       static string CardinalToOrdinal(int x){
         switch(x){
            case 11:
            case 12:
            case 13:
               return ($"{x}th");
            default:
               int y = x%10;
               string res = y switch {
                  1 => x+"st",
                  2 => x+"nd",
                  3 => x+"rd",
                  _ => x+"th"
               };
               return res;
         }
       }

        static void Main(string[] args){
           for(int i=1; i<41; i++){
              Write(CardinalToOrdinal(i)+" ");
           }
        }
      }
    
}
