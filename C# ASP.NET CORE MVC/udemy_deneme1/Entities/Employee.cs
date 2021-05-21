using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace udemy_deneme1.Entities
{
    public class Employee
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name="Name")]
        public string Name { get; set; }
        [Display(Name = "Surname")]
        public string Surname { get; set; }
        [Display(Name = "Number")]
        public int Number { get; set; }
        [Display(Name = "Cities")]
        public int Cities { get; set; }
    }
}
