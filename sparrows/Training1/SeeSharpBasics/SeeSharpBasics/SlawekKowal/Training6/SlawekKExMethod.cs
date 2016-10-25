namespace SeeSharpBasics.SlawekKowal.Training6
{
    public static class SlawekKExMethod
    {
        public static int SumAll(this SlawekKMyList<int> obj)
        {
            var result = 0;
            foreach (var element in obj) result += (int)element;
            return result;
        }
    }
}