using System.Collections.Generic;

namespace Toci.HornetsTraining.Training1.Generics.Factory
{
    public abstract class FactoryBase<T>
    {
        protected Dictionary<string, T> ListOfInstances = new Dictionary<string, T>();

        public T GetInstance(string key)
        {
            return ListOfInstances.ContainsKey(key) ? ListOfInstances[key] : default(T);
        }
    }
}