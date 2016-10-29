namespace Toci.DesignPatterns.PluginDependencyInjection
{
    public interface IDiDllInjector
    {
        void InjectDll(string name); //base64

        void RegisterDependencies(); // ICOntainer container lista parametrow ?
    }
}