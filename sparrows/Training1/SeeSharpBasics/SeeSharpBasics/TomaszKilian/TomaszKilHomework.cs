namespace SeeSharpBasics.TomaszKilian
{
    public class TomaszKilHomework
    {
        public override string StringReverse(string candidate)
        {
            string result = "";
            for (int i = candidate.Length - 1; i >= 0; i--)
            {
                result = result + candidate[i];
            }
            return result;
        }

         public override string Substring(string candidate, int start, int length)
        {
            string result = "";
            for (int i = start; i < start + length; i++)
            {
                if (start + length > candidate.Length)
                {

                    break;
                }
                else
                {
                    result = result + candidate[i];

                }



            }

            return result;


        }



         
    }
}