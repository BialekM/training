using System;
using System.Collections;
using System.IO;
using SeeSharpBasics.Training3.Homework;

namespace SeeSharpBasics.MarcinGala.Training3
{
    public class MarcinCodeGenerator : CodeGenerator
    {
        public override string GetHashmapCode()
        {
            OpenFile();
            return "";
        }

        protected override void OpenFile()
        {
            Hashtable result = new Hashtable();
            StreamReader str = new StreamReader(@"D:\Materialy programowanie\3\homework\banki.txt");
            StreamWriter wtr = new StreamWriter(@"D:\Materialy programowanie\3\homework\bankCode.txt");

            string[] line = str.ReadToEnd().Split("\r\n\t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0, j = 1; i < line.Length; i += 2, j += 2)
            {
                result.Add("hash.Add(\"" + line[i] + "\",", "\"" + line[j] + "\");");
            }

            foreach (DictionaryEntry bank in result)
            {
                Console.WriteLine("{0} {1}", bank.Key, bank.Value); //Dziala prawidlowo
                wtr.WriteLine("{0} {1}", bank.Key, bank.Value);  //Pytanie!!!
            }

        }

    }
}