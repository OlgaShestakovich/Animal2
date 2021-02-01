using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassAnimal;
namespace MSTest
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void SaveFood_Amount_Is_Five()
        {
            Animal animal = new Animal();
            
            int expected = 5;
            
            int actual = animal.SaveFood(5);
            
            Assert.AreEqual(expected, actual);
           
        }
    }
}
