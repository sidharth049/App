using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using App.Model;
using App.ViewModel;

namespace App.Service.Mappings
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