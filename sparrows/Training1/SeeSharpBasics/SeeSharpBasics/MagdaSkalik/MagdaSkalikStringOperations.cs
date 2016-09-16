using System;
using SeeSharpBasics.BartekZapart;
namespace SeeSharpBasics.MagdaSkalik
{
    public class MagdaSkalikStringOperations : StringOperations
    {
        public override string Substring(string candidate, int start, int length); // beatka, 1, 3 => eat ; bartek, 2, 4 => rtek

        public override string GetName(); // zwrocic swoje imie i nazwisko

        public override string GlueBeginingEnd(string candidate); // bartlomiej  bjaeritmlo

        public override int CountOccurences(string candidate, char needle); // bartek, a => 1 beatka, a => 2, aaaaba, a => 5

        public override int LetterPositionInString(string candidate, char needle); // bartek, k => 5

        public override string LetterReplace(string candidate, char needle, char replace); // beatka, e, s => bsatka ; beatka , a , b => bebtkb

        public override string StringReplace(string candidate, string needle, string replace); // bartlomiej, art, beatka => bbeatkalomiej
    }
}