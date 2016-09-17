namespace HornetsTraining.Training2.HomeWork
{
    public class PlusBankTransferHandler : TransferHandler // Remek
    {
        private PlusBankSQLiteClient dbClient = new PlusBankSQLiteClient();

        public PlusBankTransferHandler()
        {
            CreateTables();
        }

        public override bool DoInTransfer(Transfer transfer)// dowolna
        {
            dbClient.Query("INSERT INTO transfers(source, type, destination, money, date) VALUES('" + transfer.SourceBankAccount + "', '1', '" + transfer.DestinationBankAccount + "', '" + transfer.Money + "', datetime());"); 
            return true;
        }

        private void CreateTables()
        {
            dbClient.Query(@"CREATE TABLE IF NOT EXISTS transfers (
                            id INTEGER PRIMARY KEY AUTOINCREMENT,
                            type INTEGER,
                            source TEXT,
                            destination TEXT,
                            money INTEGER,
                            date DATETIME
                        ); ");
        }

        public override bool DoOutTransfer(Transfer transfer) // dowolna
        {
            dbClient.Query("INSERT INTO transfers(source, type, destination, money, date) VALUES('" + transfer.SourceBankAccount + "', '2', '" + transfer.DestinationBankAccount + "', '" + transfer.Money + "', datetime());");

            return true;
        }
    }
}