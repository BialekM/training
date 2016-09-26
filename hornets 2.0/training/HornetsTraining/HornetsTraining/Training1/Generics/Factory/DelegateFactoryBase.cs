using System;
using System.Collections.Generic;
namespace Toci.HornetsTraining.Training1.Generics.Factory
{
    public abstract class DelegateFactoryBase<T>
    {
            protected Dictionary<string, Func<T>> ListOfInstances = new Dictionary<string, Func<T>>();

            public T GetInstance(string key)
            {
                return ListOfInstances.ContainsKey(key) ? ListOfInstances[key]() : default(T);
            }
        
    }
}