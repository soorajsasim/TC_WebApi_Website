using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonDetails.Models
{
    /// <summary>
    /// DTO class for Person
    /// Property - NumberAsWords is required for UI
    /// </summary>    

    public class PersonDTO
    {
        public string Name { get; set; }
        public string  NumberAsWords { get; set; }

    }
}