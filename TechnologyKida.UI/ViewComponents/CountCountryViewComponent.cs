﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnologyKida.Repository.Interfaces;

namespace TechnologyKida.UI.ViewComponents
{
    public class CountCountryViewComponent : ViewComponent
    {
        private ICountryRepo _countryRepo;

        public CountCountryViewComponent(ICountryRepo countryRepo)
        {
            _countryRepo = countryRepo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var countries = await _countryRepo.GetAll();
            int TotalCountries = countries.Count();
            return View(TotalCountries);
        }
    }
}
