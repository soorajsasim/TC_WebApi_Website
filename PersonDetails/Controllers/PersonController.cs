using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using PersonDetails.Models;
using PersonDetails.Common;


namespace PersonDetails.Controllers
{
    public class PersonController : ApiController
    {
        public PersonDTO OutPerson = new PersonDTO();
        public Person InputPerson = new Person();


        //Post : api/person/post
        [Route("api/person")]
        public IHttpActionResult Post(Person obj)
        {
            ConvertToPersonDTO(obj);
            return Ok(OutPerson);
        }


        /// <summary>
        ///  This method makes use of NumberToWords(), DoubleToDollar() & DoubleToCents() an builds the property NumberAsWords
        /// </summary>
        /// <param name="obj"></param>
        private void ConvertToPersonDTO(Person obj)
        {
            OutPerson.Name = obj.Name;
            OutPerson.NumberAsWords = Conversion.NumberToWords(Conversion.DoubleToDollar(obj.Number)) +
                                        " Dollars and " + Conversion.NumberToWords(Conversion.DoubleToCents(obj.Number)) + " Cents";

        }



    }
}
