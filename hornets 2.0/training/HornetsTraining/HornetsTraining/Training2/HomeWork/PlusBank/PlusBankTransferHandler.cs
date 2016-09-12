namespace HornetsTraining.Training2.HomeWork
{
    public class PlusBankTransferHandler : TransferHandler // Remek
    {
        private PlusBankSQLiteClient dbClient = new PlusBankSQLiteClient();

        public override bool DoInTransfer(Transfer transfer)// dowolna
        {
            //  throw new System.NotImplementedException();
         //   CreateTables();
            dbClient.Query("INSERT INTO in_transfers(source, destination, money, date) VALUES('" + transfer.SourceBankAccount + "', '" + transfer.DestinationBankAccount + "', '" + transfer.Money + "', datetime());");
            return true;
        }

        private void CreateTables()
        {
            dbClient.Query(@"CREATE TABLE transfers (
                            id INTEGER PRIMARY KEY AUTOINCREMENT,
                            source TEXT,
                            destination TEXT,
                            money INTEGER,
                            date DATETIME
                        ); ");
        }

        public override bool DoOutTransfer(Transfer transfer) // dowolna
        {
            //  throw new System.NotImplementedException();

            return false;
        }
    }
}