﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.ViewModel
{
    public class RecipeViewModel : ViewModelBase
    {
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public string Preparation { get; set; }
        public int CreatedBy { get; set; }

        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
