using HornetsTraining.Training1.Animals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.Animals
{
    [TestClass]
    public class DogTest
    {
        [TestMethod]
        public void DogLegsCountTest()
        {
            Dog dog = new Dog();

            dog.Name = "pies pluto";

            Dog dog2 = new Dog();

            dog2.Name = "inny pies";

            Dog dog3 = new Dog("jeszcze inny");
            Dog dog4 = new Dog();
            Dog dog5 = new Dog();

            Rotweiler rotek = new Rotweiler();

            rotek.TestDZiedziczenia();

            string isWhatever = rotek.Name;
        }
    }
}