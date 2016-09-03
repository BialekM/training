namespace HornetsTraining.Training1.Animals
{
    public class Rotweiler : Dog
    {
        public Rotweiler() : base("parameter")
        {
            
        }

        public Rotweiler(string name) : base(name)
        {
            
        }

        public void TestDZiedziczenia()
        {
            this.Feed();
            this.ModifyAnotherAnimal(new Dog());
            this.GetLegsCount();

            this.Name = "whatever";
            //this.LegsCount = 4;
            this.Weight = 15;
        }

        public override void Feed()
        {
            
        }
    }
}