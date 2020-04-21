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

        public void DateToOneFormat_DateWithSlash_InvertedDateWithDash()  
        {   
            string original = "10/11/1977";
            string prueba = "1977-11-10";

            Assert.AreEqual(prueba,Library.DateFormat.DateToOneFormat(original));
        }

        [Test]

        // Test 2 con TDD.
        
        public void DateToAnotherFormat_DateWithSlash_DateWithDash() 
        {   
            string original = "10/11/1977";
            string prueba = "10-11-1977";

            Assert.AreEqual(prueba,Library.DateFormat.DateToAnotherFormat(original));
        }

        [Test]

        // Test 3 con TDD.
        
         public void DateToOneFormat_WrongDate_DateWithZeros()  
        {   
            string original = "10/11/1977454";
            string prueba = "00-00-00";

            Assert.AreEqual(prueba,Library.DateFormat.DateToOneFormat(original));
        }

        [Test]

        // Test 4 con TDD.
        
         public void DateToAnotherFormat_WrongDate_DateWithZeros()  
        {   
            string original = "10/11/1977454";
            string prueba = "00-00-00";

            Assert.AreEqual(prueba,Library.DateFormat.DateToAnotherFormat(original));
        }

        [Test]

        // Test 5 con TDD.
        
         public void DateToOneFormat_DateWithIncorrectDigits_DateWithZeros()  
        {   
            string original = "1*011/1977";
            string prueba = "00-00-00";

            Assert.AreEqual(prueba,Library.DateFormat.DateToOneFormat(original));
        }

         [Test]

        // Test 6 con TDD.
          public void DateToOneFormat_DateWithNumbersAndLetters_DateWithZeros()  
        {   
            string original = "10A/11/1977";
            string prueba = "00-00-00";

            Assert.AreEqual(prueba,Library.DateFormat.DateToOneFormat(original));
        }

    }
}