using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeeSharpBasics.Training3.Homework;
using System.IO;
using System.Collections;

namespace SeeSharpBasics.MagdaSkalik.Homework
{
    public class MagdaCodeGenerator : CodeGenerator
    {
  

        //protected virtual void OpenFile()
        //{
        //    //StreamReader str = new StreamReader(@"D:\materialy\Incread\studia\toci\03\banki.txt");

        //    //string line = str.ReadLine();

        //    //string[] split = line.Split(new[] { " \t" }, StringSplitOptions.None);

        //    //Hashtable bankTable = new Hashtable();
        //    //while (line.Length>0)
        //    //{
        //    //    bankTable.Add(split[0], split[1]);
        //    //}
        //    ////split[0] -> code split[1] -> bank name

        //    ////StreamWriter wtr = new StreamWriter("");

        //    ////wtr.WriteLine();
        //}

        public override string GetHashmapCode()
        {
            StreamReader str = new StreamReader(@"D:\materialy\Incread\studia\toci\03\banki.txt");

            string line = str.ReadLine();

            string[] split = line.Split(new[] { " \t" }, StringSplitOptions.None);

            Hashtable bankTable = new Hashtable();
            while (!String.IsNullOrEmpty(line))
            {
                bankTable.Add(split[0], split[1]);
            }
            StreamWriter wtr = new StreamWriter(@"D:\materialy\Incread\studia\toci\03\bankiplik.txt");

            wtr.WriteLine();

            str.Close();
            wtr.Close();
            return null;
            //kurcze nie wiem

        }
    }
}
