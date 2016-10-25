using System;
using System.IO;

namespace SeeSharpBasics.Training3.Homework.AndrzejIwanski
{
    public class AndrzejIwanskiCodeGenerator : CodeGenerator
    {
        public override string GetHashmapCode()
        {
            throw new System.NotImplementedException();
        }

        public void BankHashtableGenerate()
        {
            StreamReader str = new StreamReader(@"C:\banki.txt");
            StreamWriter wtr = new StreamWriter(@"C:\Studia\wygenerowany_kod.txt");

            while (!str.EndOfStream)
            {
                string line = str.ReadLine();

                string[] split = line.Split(new[] { " \t" }, StringSplitOptions.None);

                //split[0] -> code split[1] -> bank name

                

                wtr.WriteLine("banksHashtable.Add(\"{0}\",\"{1}\");", split[0], split[1]);

            }
            
        }

        public void BankHastableAdd()
        {

            
        }
            
    }
}

