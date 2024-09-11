﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologyKida.UI.ViewModels.StateViewModel
{
    public class CreateStateViewModel
    {
        public string StateName { get; set; }
        [Display(Name="Country Name")]
        public int CountryId { get; set; }

    }
}
