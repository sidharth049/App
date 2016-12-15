using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using App.Model;
using App.ViewModel;

namespace App.Service.Mappings
{
    public class DomainToViewModelMapppingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "DomainToViewModelMapppingProfile";
            }
        }

        public DomainToViewModelMapppingProfile()
        {
            CreateMap<Recipe, RecipeViewModel>();
        }
        
    }
}