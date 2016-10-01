using System;
using System.Diagnostics;

namespace Toci.HornetsTraining.Training3.Homework.PawelKownacki
{
    public class GenericClasses
    {
        public void GenericMethodOne<T>()
        {
            Debug.WriteLine(String.Format("Metoda 1. {0} ", typeof(T).Name));
        }

        public void GenericMethodTwo<T>()
        {
            Debug.WriteLine(String.Format("Metoda 2. {0} ", typeof(T).Name));
        }

        public void GenericMethodThree<T>()
        {
            Debug.WriteLine(String.Format("Metoda 3. {0} ", typeof(T).Name)); 
        }

        public void GenericMethodFour<T>()
        {
            Debug.WriteLine(String.Format("Metoda 4. {0} ", typeof(T).Name)); 
        }

        public void GenericMethodFive<T>()
        {
            Debug.WriteLine(String.Format("Metoda 5. {0} ", typeof(T).Name)); 
        }
    }
}