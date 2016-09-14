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

        public  List<StringOperations> LoadFromAssembly()
        {
            AssemblyLoader al = new AssemblyLoader();

            var instances = al.GetTypesInstancesList<StringOperations>();

            return (List<StringOperations>)instances;
        }


        private SubstringDelegate AppendSubstring(List<StringOperations> list)
        {
             SubstringDelegate del=null;
            foreach (var item in list)
            {
                del += item.Substring;
            }

            return del;
        }

        private PositionInStringDelegate AppendPositionInString(List<StringOperations> list)
        {
            PositionInStringDelegate del = null;
            foreach (var item in list)
            {
                del += item.PositionInString;
            }

            return del;
        }

        private StringReplaceDelegate AppendStringReplace(List<StringOperations> list)
        {
            StringReplaceDelegate del = null;
            foreach (var item in list)
            {
                del += item.StringReplace;
            }

            return del;
        }

        public void AllDelgates(List<StringOperations> list,ref SubstringDelegate subDel,ref PositionInStringDelegate posInStrDel, ref StringReplaceDelegate repDel )
        {
            subDel = AppendSubstring(list);
            posInStrDel=AppendPositionInString(list);
            repDel = AppendStringReplace(list);

        }
    }
}