using System;

namespace Toci.HornetsTraining.Training2.HomeWork.NBP
{
    [Serializable]
    public class TransferReport
    {
        /// <summary>
        /// Numer przelewu
        /// </summary>
        public string TransferStamp;

        /// <summary>
        /// Opis
        /// </summary>
        public string Description;

        /// <summary>
        /// Kwota przed przelewem
        /// </summary>
        public double MoneyBefore;

        /// <summary>
        /// Kwota po przelewie
        /// </summary>
        public double MoneyNow;

        /// <summary>
        /// Różnica
        /// </summary>
        public double MoneyChange;

        /// <summary>
        /// Data transakcji 
        /// </summary>
        public DateTime CreatedTime;

        /// <summary>
        /// 
        /// </summary>
        public string SourceBankAccount;

        /// <summary>
        /// 
        /// </summary>
        public string DestinationBankAccount;

        /// <summary>
        /// 
        /// </summary>
        public double Money;

        /// <summary>
        /// 
        /// </summary>
        [NonSerialized]
        public Transfer Transfer;


        /// <summary>
        /// Przerzuca informacje z transferu do raportu, brak dziedziczenia spowodowany
        /// zaprzeczeniem logiki (TransferReport mógłbybyć bazowo raportem, ale nie transferem)
        /// </summary>
        public void InfoFromTransfer()
        {
            SourceBankAccount = Transfer.SourceBankAccount;
            DestinationBankAccount = Transfer.DestinationBankAccount;
            Money = Transfer.Money;
        }
    }
}