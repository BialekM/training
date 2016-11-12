using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Autofac;

namespace Toci.DesignPatterns.PluginDependencyInjection.DllInjectorForAutofac
{
    public class AutofacDllInjector : IDiDllInjector
    {
        private const string NameOfTypeContainsDependancies = "Register";
        private const string NameOfMethodReturnDependancies = "GetTypesToRegister";
        private const string NameOfMethodReturnGenericDependancies = "GetGenericTypesToRegister";
        //private const string PathPrefix = "../../../";
        private const string PathPrefix = "D:/GitRepository/warriorRep/hornets 2.0/training/HornetsTraining/";
        private const string PathMidfix = "/bin/Debug/";
        private const string PathPostfix = ".dll";
        private const string Seperator = ".";

        private Dictionary<Type, Type> _typesToRegister;
        private Dictionary<Type, Type> _genericTypesToRegister;

        public void InjectDll(string name)
        {
            string myPath = PathPrefix + name + PathMidfix + name + PathPostfix;
            var x = Path.GetFullPath(myPath);

            Assembly assembly = Assembly.LoadFrom(PathPrefix + name + PathMidfix + name + PathPostfix);

            _typesToRegister = (Dictionary<Type, Type>)assembly.
                GetType(name + Seperator + NameOfTypeContainsDependancies).
                GetMethod(NameOfMethodReturnDependancies).
                Invoke(null, null);

            _genericTypesToRegister = (Dictionary<Type, Type>) assembly.
                GetType(name + Seperator + NameOfTypeContainsDependancies).
                GetMethod(NameOfMethodReturnGenericDependancies).
                Invoke(null, null);
            
        }

        public void RegisterDependencies(object register)
        {
            ContainerBuilder builder = (ContainerBuilder)register;

            foreach (var type in _typesToRegister)
            {
                builder.RegisterType(type.Value).As(type.Key);
            }

            foreach (var type in _genericTypesToRegister)
            {
                builder.RegisterGeneric(type.Value).As(type.Key);
            }
        }
    }
}