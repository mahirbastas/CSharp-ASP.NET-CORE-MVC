using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using udemy_deneme1.Entities;

namespace udemy_deneme1
{
    public class EmployeeAddViewModel
    {
        public Employee Employee { get; set; }
        public List<SelectListItem> Cities { get; set; }
    }
}