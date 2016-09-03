namespace HornetsTraining.Training1.Overdloading
{
    public class OverloadingExample
    {
        public OverloadingExample()
        {
            Whatever(2.33);
        }

        public void Whatever()
        {
            
        }

        public void Whatever(string name)
        {
            
        }

        public void Whatever(int count)
        {

        }

        public virtual void Whatever(double test) // 1
        {
            
        }
    }

    public class OverloadingExampleChild : OverloadingExample
    {
        public new void Whatever()
        {
            
        }

        public override void Whatever(double test) // 2
        {

        }
    }

    public class OverloadingExampleTesting
    {
        public void Test()
        {
            OverloadingExample inst = new OverloadingExample();

            inst.Whatever();
        }
    }
}