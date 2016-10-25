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

        public void BankHastableAdd()
        {
            StreamReader str = new StreamReader(@"C:\Users\Andrew\Desktop\banki.txt");
            StreamWriter wtr = new StreamWriter(@"C:\Users\Andrew\Desktop\wynik.txt");

            while (!str.EndOfStream)
            {
                string line = str.ReadLine();
                string[] split = line.Split(new[] { " \t" }, StringSplitOptions.None);
                wtr.WriteLine("hashtableOfBanks.Add({0},\"{1}\");", split[0], split[1]);
            }
            str.Close();
            wtr.Close();
        }
    }
}

