using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonDetails.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonDetails.Models;
using System.Web.Http.Results;




namespace PersonDetails.Controllers.Tests
{
    [TestClass()]
    public class PersonControllerTests
    {
        /// <summary>
        /// This test method validates the post method 
        ///  Private method 'ConvertToPersonDTO()' is also covered in this test method
        /// </summary>

        [TestMethod()]
        public void PostTest()
        {
            // arrange 
            var testPerson = createTestPerson();
            var controller = new PersonController();
            var expected = createTestPersonDTO();
            //act
            var result = controller.Post(testPerson) as OkNegotiatedContentResult<PersonDTO>; ;
            //assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expected.Name, result.Content.Name);
            Assert.AreEqual(expected.NumberAsWords, result.Content.NumberAsWords);

        }
        /// <summary>
        /// This method is repsonsible for creating the test data used in post 
        /// </summary>
        /// <returns>Person</returns>
        private Person createTestPerson()
        {
             Person personTestObj = new Person();
            personTestObj.Name = "A";
            personTestObj.Number = 10.25;
            return personTestObj;
        }

        /// <summary>
        /// This method is repsonsible for creating the expected result object  
        /// </summary>
        /// <returns>PersonDTO</returns>
        private PersonDTO createTestPersonDTO()
        {
            PersonDTO testPersonDTO = new PersonDTO();
            testPersonDTO.Name = "A";
            testPersonDTO.NumberAsWords = "ten Dollars and twenty-five Cents";
            return testPersonDTO;
        }
    }
}