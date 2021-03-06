﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Didi;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Rudi;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Soltys;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe
{
   public class GliwicePerformTransfer : PerformTransfers
   {

       //private List<BankTransfersParser> _bankTransfersList;
       //private DidiBankTransferParser _DidTransfers;
       //private RudiBankTransferParser _RudiTransfers;
       //private SoltysBankTransferParser _SoltysTransfers;

       private List<BankTransfersParser> _bankTransfersList;
       private DidiBankTransferParser _DidTransfers; // ing
       private RudiBankTransferParser _RudiTransfers; // hsbc
       private SoltysBankTransferParser _SoltysTransfers; //sant


       //private DidiBankTransferParser _DidTransfers;
       //private RudiBankTransferParser _RudiTransfers;


       //public GliwicePerformTransfer()
       //{
       //    _bankTransfersList = new List<BankTransfersParser>();


       //    //_DidTransfers = new DidiBankTransferParser();
       //    //_RudiTransfers = new RudiBankTransferParser();
       //    //_SoltysTransfers = new SoltysBankTransferParser();
       //}

       protected override List<BankTransfersParser> GetAllParsers()
       {
          
       }

       protected override List<TransferHandle> GetAllHandles()
       {
           var generator = new ParsersGenerator();

           _bankTransfersList = generator.GetList("Gliwice");


           //_bankTransfersList.Add(_DidTransfers);
           //_bankTransfersList.Add(_RudiTransfers);
           //_bankTransfersList.Add(_SoltysTransfers);

           return _bankTransfersList;
       }

   }
}
