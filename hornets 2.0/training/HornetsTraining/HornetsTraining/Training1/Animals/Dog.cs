namespace HornetsTraining.Training1.Animals
{
    public class Dog
    {
        private int _legsCount; //nie dziedzicznoe, niewidoczne w api obiektu
        protected double Weight; //dziedziczmnoe, niewoidoczne w api obiketu
        public string Name; //dziedziczone, widoczne w api obiektu

        public static int Whatever;

        public string Shape { get; set; }

        public int LegsCountProperty
        {
            get { return _legsCount; }
            set { _legsCount = value; }
        }

        public Dog()
        {
            //Rotweiler rt = new Rotweiler();
        }

        public Dog(string name)
        {
            Name = name;
        }

        public virtual void Feed()
        {
            Weight++;

            if (true)
            {
                
            }
        }

        public int GetLegsCount()
        {
            return _legsCount;
        }

        public void ModifyAnotherAnimal(Dog dog)
        {
            dog._legsCount = 4;
            Name = dog.Name;
            dog.Weight = 13;
            //this.LegsCount
        }
    }
}