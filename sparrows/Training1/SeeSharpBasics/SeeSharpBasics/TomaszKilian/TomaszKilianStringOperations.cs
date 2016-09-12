using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpBasics.TomaszKilian
{
    public class TomaszKilianStringOperations : StringOperations
    {
        public override string Substring(string candidate, int start, int length)
        {
            string wynikowa = "";
            for (int i = start; i <= length ; i++)
            {
                wynikowa += candidate[i];
            }
            return wynikowa;



        }

    public override string GetName()
       {
           throw new NotImplementedException();
       }

       public override string GlueBeginingEnd(string candidate)
       {
           string wynikowa = "";
           for (int i = 0, j = candidate.Length - 1; i < j; i++ ,j--)
           {
               wynikowa += candidate[i];
               wynikowa += candidate[j];



           }
           return wynikowa;
       }

       public override int CountOccurences(string candidate, char needle)
       {
           int ileliter = 0;
           int start = 0;
           for (int i = 0; i < candidate.Length; i++)
           {
               if (candidate[i] == needle)
               {
                   start++;
                   
               }
            
              
           }
           return start;


       }

       public override int LetterPositionInString(string candidate, char needle)
       {
           int start = 0;
           for (int i = 0; i < candidate.Length; i++)
           {
               if (candidate[i] == needle)
               {
                   start = i;
               }
           
           }
           return start;



       }

       public override string LetterReplace(string candidate, char needle, char replace)
       {
           string pomocniczy = "";
           

           for (int i = 0; i < candidate.Length; i++)
           {
               if (candidate[i] != needle)
               {
                   pomocniczy += candidate[i];
               }
               else 
               {
                   pomocniczy = pomocniczy + replace;
               }
           }
           return pomocniczy;


       }

       public override string StringReplace(string candidate, string needle, string replace)
       {
           
       }
    }
}
