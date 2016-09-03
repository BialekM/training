namespace HornetsTraining.Training1.HomeWork
{

    public abstract class StringOperations : IStringOperations
    {
        public abstract string GetName(); // podac swoje imie i nazwisko

        public abstract string Substring(string candidate, int start, int length); // zwraca wycinek stringu od start do dlugosci length: beatka, 1, 3 => eat

        public abstract int PositionInString(string candidate, string needle); // pozycja stringu w stringu

        public abstract string StringReplace(string candidate, string needle, string replaceWith); // podmieinc string w stringu beata, at, atk => beatka

        protected int Whatever()
        {
            return 0;
        }

        //private
    }
}