namespace Toci.DesignPatterns.PluginDependencyInjection
{
    public interface IDiDllInjector
    {
        void InjectDll(string name); //base64

        void RegisterDependencies(object register); // ICOntainer container lista parametrow ?
    }
}