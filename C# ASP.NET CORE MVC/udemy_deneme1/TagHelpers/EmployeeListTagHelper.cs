using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using udemy_deneme1.Entities;

namespace udemy_deneme1.TagHelpers
{
    [HtmlTargetElement("employee-list")]
    public class EmployeeListTagHelper : TagHelper
    {
        private List<Employee> _employees; 
        public EmployeeListTagHelper()
        {
            _employees = new List<Employee>
            {
                new Employee{ Id=1, Name="serhat", Surname="bastas", Number=123456, Cities=6 },
                new Employee{ Id=2, Name="ali", Surname="asda", Number=1234561233, Cities=34 },
                new Employee{ Id=3, Name="mehmet", Surname="gfsfw", Number=1234561233, Cities=6 }
            };
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            var query = _employees;

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var employee in query)
            {
                stringBuilder.AppendFormat("<h2><a href='/employee/detail/{0}'>{1}</a></h2>", employee.Id, employee.Name);
            }

            output.Content.SetHtmlContent(stringBuilder.ToString()); 
            base.Process(context, output);
        }
    }
}
