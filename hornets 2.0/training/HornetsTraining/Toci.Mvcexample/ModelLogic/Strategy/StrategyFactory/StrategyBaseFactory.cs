using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Toci.Mvcexample.ModelLogic.Strategy.StrategyFactory
{
    public abstract class StrategyBaseFactory<T>
    {
        protected Dictionary<int, T> ListOfInstances = new Dictionary<int, T>();

        public T GetInstance(int key)
        {
            return ListOfInstances.ContainsKey(key) ? ListOfInstances[key] : default(T);
        }
    }
}