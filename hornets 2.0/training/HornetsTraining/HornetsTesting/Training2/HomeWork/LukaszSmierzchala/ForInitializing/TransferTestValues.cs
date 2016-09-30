using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.HornetsTraining.Training2.HomeWork;

namespace HornetsTesting.Training2.HomeWork.LukaszSmierzchala.ForInitializing
{
    public class TransferTestValues
    {
        public List<Transfer> ValuesList { get; private set; }

        public TransferTestValues()
        {
            ValuesList = new List<Transfer>()
            {
                new Transfer()
                {
                    SourceBankAccount = "86216024980000860202631234",
                    DestinationBankAccount = "86216024980000860202632345",
                    Money = 500
                },

                new Transfer()
                {
                    SourceBankAccount = "86216024980000860202631111",
                    DestinationBankAccount = "86216024980000860202635555",
                    Money = 200
                }

            };
        }
    }
}
