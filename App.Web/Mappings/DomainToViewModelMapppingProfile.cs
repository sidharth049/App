using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using App.Web.ViewModel;
using App.Model;

namespace App.Web.Mappings
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