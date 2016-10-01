using Toci.HornetsTraining.Training1.Generics.Factory;

namespace HornetsTesting.Training1.Generics
{
    public class GenericsTest
    {
        public void Test()
        {
            StringOperationsFactory factory = new StringOperationsFactory();

            factory.GetInstance("adrian").GetName();
        }
    }
}