using Toci.HornetsTraining.Training2.HomeWork;

namespace Toci.HornetsTraining.Training3.Reflection
{
    public class Entity
    {
        private string AccountNumber;
        private string Name;
        private string Value;

        private string Stamp {get; set; }
        private string Income { get; set; }
        private string ParentName { get; set; }

        public void GenericMethod<T>(T handler) where T : TransferHandler
        {
            
        }
    }
}