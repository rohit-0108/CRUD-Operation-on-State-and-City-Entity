﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnologyKida.Repository.Interfaces;

namespace TechnologyKida.UI.ViewComponents
{
    public class CountCityViewComponent: ViewComponent
    {
        private ICityRepo _cityRepo;

        public CountCityViewComponent(ICityRepo cityRepo)
        {
            _cityRepo = cityRepo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var cities=await _cityRepo.GetAll();
            int TotalCities=cities.Count();
            return View(TotalCities);
        }

    }
}
