using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using App.Web.ViewModel;
using App.Model;

namespace App.Web.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "ViewModelToDomainMappingProfile";
            }
        }

        public ViewModelToDomainMappingProfile()
        {
            CreateMap<RecipeViewModel, Recipe>();
        }
    }
}