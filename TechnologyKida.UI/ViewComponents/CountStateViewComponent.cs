﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnologyKida.Repository.Interfaces;

namespace TechnologyKida.UI.ViewComponents
{
    public class CountStateViewComponent : ViewComponent
    {
        private IStateRepo _stateRepo;

        public CountStateViewComponent(IStateRepo stateRepo)
        {
            _stateRepo = stateRepo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var states = await _stateRepo.GetAll();
            int TotalStates= states.Count();
            return View(TotalStates);
        }

    }
}
