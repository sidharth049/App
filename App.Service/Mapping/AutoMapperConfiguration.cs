using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Service.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMapppingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}