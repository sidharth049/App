using App.Service.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service
{
    public class ServiceBase
    {
        public ServiceBase()
        {
            AutoMapperConfiguration.Configure();
        }
    }
}
