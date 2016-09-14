using System;
using System.Collections.Generic;
using HornetsTesting.Common;

using HornetsTraining.Training1.HomeWork;

namespace HornetsTesting.Training2.Delegates.MichalMazur
{
    public class LoadAllHomework
    {
        public delegate string SubstringDelegate(string candidate, int start, int lenght);
        public delegate int PositionInStringDelegate(string candidate, string needle);
        public delegate string StringReplaceDelegate(string candidate, string needle, string replaceWith);

        public static List<StringOperations> LoadFromAssembly()
        {
            AssemblyLoader al = new AssemblyLoader();

            var instances = al.GetTypesInstancesList<StringOperations>();

            return (List<StringOperations>)instances;
        }


        public static SubstringDelegate AppendSubstringMethod(List<StringOperations> list)
        {
             SubstringDelegate del=null;
            foreach (var item in list)
            {
                del += item.Substring;
            }

            return del;
        }

        //public Dictionary<string, string> TestAll(List<StringOperations> list,Func<string, int, int, string> testDelegate)
        //{
        //    Dictionary<string, string> dict = new Dictionary<string, string>();
        //    foreach (var item in list)
        //    {
                
        //    }
            
       // }

    }
}