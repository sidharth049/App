using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.EntityFramework.EntityFramework;

namespace App.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        AppDbContext Init();
    }
}
