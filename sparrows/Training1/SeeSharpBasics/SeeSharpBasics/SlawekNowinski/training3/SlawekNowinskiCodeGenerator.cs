using SeeSharpBasics.Training3.Homework;
using System;
using System.IO;

namespace SeeSharpBasics.SlawekNowinski.training3
{
    class SlawekNowinskiCodeGenerator : CodeGenerator
    {
        public override string GetHashmapCode()
        {
            StreamReader str = new StreamReader(@"E:\tocipodstawy2016\3\banki.txt");
            StreamWriter wtr = new StreamWriter("code.txt");
            while (!str.EndOfStream)
            {
                string line = str.ReadLine();

                string[] split = line.Split(new[] { " \t" }, StringSplitOptions.None);

                wtr.WriteLine("result.Add(" + '"' + split[1] + '"' + ", " + split[0] + ")" + ';');
            }
            return "";
        }
        
    }
}
