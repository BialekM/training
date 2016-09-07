namespace HornetsTraining.Training1.HomeWork.AdrianPankiewicz
{
    public static class GenericMethodsCollection<T>
    {
        public static void Swap(ref T first, ref T second)
        {
            T firstRef = first;
            first = second;
            second = firstRef;
        }
    }
}