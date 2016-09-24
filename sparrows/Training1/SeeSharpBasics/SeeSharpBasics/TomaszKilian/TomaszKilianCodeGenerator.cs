using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeeSharpBasics.Training3.Homework;

namespace SeeSharpBasics.TomaszKilian 
{
    public class TomaszKilianCodeGenerator:CodeGenerator
    {
        public override string GetHashmapCode()
        {
            return null;
        }
        
        
            
        protected virtual void OpenFile()
          {
            StreamReader str = new StreamReader(@"C:\Dell\banki.txt");

            string line = str.ReadLine();

            string[] split = line.Split(new[] {" \t"}, StringSplitOptions.None);

            Console.WriteLine("poka {0}",line);
            //split[0] -> code split[1] -> bank name

            StreamWriter wtr = new StreamWriter("");

            wtr.WriteLine();
        }

        }


    }

