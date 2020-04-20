using NUnit.Framework;

namespace Library.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]

        // Test 1.

        public void Test1()  
        {   

            string original = "10/11/1977";
            string prueba = "1977-11-10";

            Assert.AreEqual(prueba,Library.DateFormat.DateToOneFormat(original));
        }

        [Test]

        // Test 2 con TDD.
        public void Test2() 
        {   

            string original = "10/11/1977";
            string prueba = "10-11-1977";

            Assert.AreEqual(prueba,Library.DateFormat.DateToAnotherFormat(original));
        }
    }
}