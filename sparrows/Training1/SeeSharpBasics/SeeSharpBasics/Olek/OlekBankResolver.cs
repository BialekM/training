using System.IO;
using System.Runtime.Remoting.Messaging;
using SeeSharpBasics.Training3.Homework;

namespace SeeSharpBasics.Olek
{
    public class OlekBankResolver : BankResolver
    {
        public override string GetBankName(string bankCodeId)
        {
            throw new System.NotImplementedException();
            //dla numeru konta 10 1140 ->mBamk
        }

        public override string GetBankCodeForAccount(string account)
        {   // pobrać 4 cyfry i zwrócić nazwę banku
            throw new System.NotImplementedException();
        }
        // D:\TOCI\!_PROJEKTY\banki.txt
        //protected vitrual void OpenFile()
        //{
        //    //StreamReader = new StreamReader("D:\\TOCI\\!_PROJEKTY\\banki.txt");
        //    StreamReader = new StreamReader(@"D:\TOCI\!_PROJEKTY\banki.txt");
        //}
        
    }
}