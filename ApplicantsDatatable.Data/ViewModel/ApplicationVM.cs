using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicantsDatatable.Data.ViewModel
{
    public class ApplicationVM
    {
        public int? Id { get; set; }
        [Required]
        [MinLength(5)]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [MinLength(5)]
        [Display(Name = "Family Name")]
        public string FamilyName { get; set; }
        [Required]
        [MinLength(10)]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Country Of Origin")]
        public string CountryOfOrigin { get; set; }
        [Required]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z")]
        [Display(Name = "Email")]
        public string EMailAdress { get; set; }
        [Required]
        [Display(Name = "Hired")]
        public bool Hired { get; set; }
        [Display(Name = "Age")]
        [Required]
        [Range(20, 60)]
        public int Age { get; set; }
    }
}
