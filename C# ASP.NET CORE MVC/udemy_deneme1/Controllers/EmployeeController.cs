﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using udemy_deneme1.Entities;
using udemy_deneme1.Services;

namespace udemy_deneme1.Controllers
{
    public class EmployeeController : Controller
    {
        private ICalculator _calculator;

        public EmployeeController(ICalculator calculator)
        {
            _calculator = calculator;
        }
        public IActionResult Add()
        {
            var employeeAddViewModel = new EmployeeAddViewModel
            {
                Employee = new Employee(),
                Cities = new List<SelectListItem>
                {
                    new SelectListItem { Text = "Ankara", Value = "6" },
                    new SelectListItem { Text = "İstanbul", Value = "34" }
                }
            };
            return View(employeeAddViewModel);
        }
        [HttpPost]
        public IActionResult Add(Employee employee) 
        {
            return View();
        }

        public string calculate()
        {
            return _calculator.Calculate(100).ToString();
        }
    }
}
