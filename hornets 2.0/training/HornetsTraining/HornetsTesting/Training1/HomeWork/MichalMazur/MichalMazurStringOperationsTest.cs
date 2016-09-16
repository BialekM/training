using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using HornetsTesting.Common;
using HornetsTraining.Training1.HomeWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training2.Delegates.MichalMazur
{
    [TestClass]
    public class MichalMazurStringOperationsTest
    {
        public LoadAllHomework ah = new LoadAllHomework();
        public LoadAllHomework.SubstringDelegate substringDelegate = null;
        public LoadAllHomework.PositionInStringDelegate positionInStringDelegate = null;
        public LoadAllHomework.StringReplaceDelegate stringReplaceDelegate = null;
       
        List<string> resultOfSubstring = new List<string>();
        List<int> resultOfPositionInString = new List<int>();
        List<string> resultOfReplaceString = new List<string>();
        private List<StringOperations> homework;

        [TestMethod]

        public void TestHomework()
        {      
            homework = ah.LoadFromAssembly();        
            ah.AllDelgates(homework, ref substringDelegate,ref positionInStringDelegate, ref stringReplaceDelegate);
            PrintResult();
           

        }

        private void PrintResult()
        {
            try
            {
                Testing("komputer", 2, 3, "mpu", "gto");
            }
            catch
            {

            }
            Debug.WriteLine("resultOfSubstring\t resultOfPositionInString\t resultOfReplaceString");
            try
            {
                for (int i = 0; i < homework.Count; i++)
                {
                    Debug.WriteLine(resultOfSubstring[i] + "\t {0} " + resultOfReplaceString[i],
                        resultOfPositionInString[i]);
                }
            }
            catch
            {

            }
        }
        private void Testing(string cadidate, int start, int lenght, string needle, string replace)
        {
             foreach (LoadAllHomework.SubstringDelegate item in substringDelegate.GetInvocationList())
            {
                resultOfSubstring.Add(item(cadidate, start, lenght));
            }
             foreach (LoadAllHomework.PositionInStringDelegate item in positionInStringDelegate.GetInvocationList())
             {
                 resultOfPositionInString.Add(item(cadidate, needle));
             }
             foreach (LoadAllHomework.StringReplaceDelegate item in stringReplaceDelegate.GetInvocationList())
            {
                resultOfReplaceString.Add(item(cadidate, needle, replace));
            }        

        }
           
    }
}