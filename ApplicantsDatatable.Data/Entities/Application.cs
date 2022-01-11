using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicantsDatatable.Data.Entities
{
   public class Application
    {
        public int Id { get; set; }
        [MinLength(5)]
        public string Name { get; set; }
        [MinLength(5)]
        public string FamilyName { get; set; }
        [MinLength(10)]
        public string Address { get; set; }

        public string CountryOfOrigin { get; set; }

        public string EMailAdress { get; set; }
        public bool Hired { get; set; }
        [Range(20, 60)]
        public int Age { get; set; }
    }
}
