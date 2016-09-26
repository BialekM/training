using System;
using System.Diagnostics;
using HornetsTraining.Training1.HomeWork;

namespace HornetsTraining.Training3.Homework.LukaszCichon
{
    public class GenericClasses
    {
        public void GenericMethodOne<T>() 
        {
            Debug.WriteLine(String.Format("Metoda pierwsza: {0} ", typeof(T).Name));
        }

        public void GenericMethodTwo<T>()
        {
            Debug.WriteLine(String.Format("Metoda druga: {0} ", typeof(T).Name));
        }

        public void GenericMethodThree<T>()
        {
            Debug.WriteLine(String.Format("Metoda trzecia: {0} ", typeof(T).Name));
        }

        public void GenericMethodFour<T>()
        {
            Debug.WriteLine(String.Format("Metoda czwarta: {0} ", typeof(T).Name));
        }

        public void GenericMethodFive<T>()
        {
            Debug.WriteLine(String.Format("Metoda piata: {0} ", typeof(T).Name));
        }

        public void GenericMethodSix<T>()
        {
            Debug.WriteLine(String.Format("Metoda szosta: {0} ", typeof(T).Name));
        }

        public void GenericMethodSeven<T>()
        {
            Debug.WriteLine(String.Format("Metoda siodma: {0} ", typeof(T).Name));
        }

        public void GenericMethodEight<T>()
        {
            Debug.WriteLine(String.Format("Metoda osma: {0} ", typeof(T).Name));
        }

        public void GenericMethodNine<T>()
        {
            Debug.WriteLine(String.Format("Metoda dziewiata: {0} ", typeof(T).Name));
        }

        public void GenericMethodTen<T>()
        {
            Debug.WriteLine(String.Format("Metoda dziesiata: {0} ", typeof(T).Name));
        }
 
    }
}